using System;
using System.Configuration;
using System.Threading;
using System.Xml;
using Common.Logging;
using Quartz;
using SalesForceCrm.SalesForceService;
using wow.ApiLibrary;

namespace SalesForceCrm
{
    /// <summary>
    /// A sample job that just prints info on console for demostration purposes.
    /// </summary>
    public class SalesForceJob : IJob
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(SalesForceJob));


        /// <summary>
        /// Called by the <see cref="T:Quartz.IScheduler"/> when a <see cref="T:Quartz.ITrigger"/>
        /// fires that is associated with the <see cref="T:Quartz.IJob"/>.
        /// </summary>
        /// <param name="context">The execution context.</param>
        /// <remarks></remarks>
        public void Execute(IJobExecutionContext context)
        {
            // get the API Key
            var apiKey = ConfigurationManager.AppSettings["apiKey"];
            // get the client id
            var clientId = ConfigurationManager.AppSettings["clientId"];
            // get the salesforce user id
            var salesforceUser = ConfigurationManager.AppSettings["salesforceUser"];
            // get the salesforce password
            var salesforcePassword = ConfigurationManager.AppSettings["salesforcePassword"];
            // get the salesforce token
            var salesforceToken = ConfigurationManager.AppSettings["salesforceToken"];

            // setup the WOW Api Library
            var restClient = new WowClient(apiKey);
            
            try
            {
                // get the lastest leads from the WOW Api
                var leads = restClient.GetLatestLeads(clientId, 30, 100);

                if (leads.Error == null)
                {
                    // we did not get an error gettin the leads
                    if (leads.Data.Count > 0)
                    {
                        // we have leads to process
                        // so lets setup the salesforce service
                        // Build the Url required
                        var url = "https://login.salesforce.com/services/Soap/u/21.0";

                        var service = new SforceService();
                        service.Url = url;

                        service.Timeout = 60000;
                        var loginResult = service.login(salesforceUser, salesforcePassword + salesforceToken);
                        service.Url = loginResult.serverUrl;
                        service.SessionHeaderValue = new SessionHeader();
                        service.SessionHeaderValue.sessionId = loginResult.sessionId;


                        foreach (var lead in leads.Data)
                        {
                            QueryResult qr = null;

                            service.QueryOptionsValue = new QueryOptions();
                            service.QueryOptionsValue.batchSize = 250;
                            service.QueryOptionsValue.batchSizeSpecified = true;

                            var accountSql =
                                "Select a.Name from Account a " +
                                "where a.Name like '%" + lead.CompanyName + "%'";

                            qr = service.query(accountSql);

                            if (qr.records == null)
                            {
                                // we don't have a company with the same name
                                // do we already have a lead called this?
                                var leadSql = "SELECT Company FROM Lead l" +
                                              "where l.Company like '%" + lead.CompanyName + "%'";

                                qr = service.query(leadSql);

                                if (qr.records == null)
                                {
                                    var description = string.Format("From WOW Analytics\r\r{0}", lead.PermaLink);

                                    // the lead does not already exist so we will add it
                                    var records = new sObject[1];
                                    var sObj = new sObject { type = "lead" };
                                    var fieldElements = new System.Xml.XmlElement[6];
                                    fieldElements[0] = GetNewXmlElement("Company", lead.CompanyName);
                                    fieldElements[1] = GetNewXmlElement("Description", description);
                                    fieldElements[2] = GetNewXmlElement("LastName", lead.CompanyName);

                                    sObj.Any = fieldElements;
                                    records[0] = sObj;

                                    var upsertResults = service.upsert("id", records);

                                    if (upsertResults != null && upsertResults.Length > 0)
                                    {
                                        // get the first result
                                        var result = upsertResults[0];
                                        var error = string.Empty;

                                        // check to see if we have any errors
                                        if (!result.success)
                                        {
                                            if (result.errors.Length > 0)
                                            {
                                                // get the first error
                                                error = result.errors[0].message;
                                            }
                                            // throw an error
                                            var message =
                                                string.Format("Unable to create lead due to one or more errors - {0}",
                                                              error);

                                            logger.ErrorFormat(message);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

           
        }

        private XmlElement GetNewXmlElement(string Name, string nodeValue)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement xmlel = doc.CreateElement(Name);
            xmlel.InnerText = nodeValue;
            return xmlel;
        }
    }

}