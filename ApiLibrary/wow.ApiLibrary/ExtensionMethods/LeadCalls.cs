using System;
using System.Collections.Generic;
using RestSharp;
using wow.ApiLibrary.Models;

namespace wow.ApiLibrary.ExtensionMethods
{
    public static class LeadCalls
    {
        public static List<Lead> GetLatestLeads(this WowClient self, string clientId, int lastMinutes, int numberToGet = 10)
        {
            if (lastMinutes > 60)
            {
                throw new ArgumentException("You can only get the leads for the last 60 minutes", "lastMinutes");
            }

            var request = new RestRequest
                {
                    Resource = "latestleads/{clientId}/{minutes}/{numberToGet}",
                    RequestFormat = DataFormat.Json
                };

            request.AddHeader("api-version", "1");
            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("minutes", lastMinutes.ToString());
            request.AddUrlSegment("numberToGet", numberToGet.ToString());

            var result = self.Client.Execute<List<Lead>>(request);

            if (result.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception(result.ErrorMessage);
            }


            return result.Data;

        }

        public static ApiPagedList<Lead> GetLeads(this WowClient self, string clientId, string type, DateTime startDate, DateTime endDate, int page, int take)
        {

            var request = new RestRequest
                {
                    Resource = "client/{clientId}/leads/{type}/{startDate}/{endDate}/{page}/{take}",
                    RequestFormat = DataFormat.Json
                };

            request.AddHeader("api-version", "1");
            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("type", type);
            request.AddUrlSegment("startDate", startDate.ToString("yyyy-MM-dd"));
            request.AddUrlSegment("endDate", endDate.ToString("yyyy-MM-dd"));
            request.AddUrlSegment("page", page.ToString());
            request.AddUrlSegment("take", take.ToString());

            var result = self.Client.Execute<ApiPagedList<Lead>>(request);

            if (result.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception(result.ErrorMessage);
            }


            return result.Data;

        }

        public static Lead GetLead(this WowClient self, string clientId, Guid leadId)
        {
            var request = new RestRequest
            {
                Resource = "client/{clientId}/lead/{leadId}",
                RequestFormat = DataFormat.Json
            };

            request.AddHeader("api-version", "1");
            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("leadId", leadId.ToString());
            
            var result = self.Client.Execute<Lead>(request);

            if (result.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception(result.ErrorMessage);
            }

            return result.Data; 
        }

        public static List<LeadTypeCount> GetLeadTypes(this WowClient self, string clientId, DateTime startDate, DateTime endDate)
        {
            var request = new RestRequest
                {
                    Resource = "client/{clientId}/leads/types/{startDate}/{endDate}",
                    RequestFormat = DataFormat.Json
                };

            request.AddHeader("api-version", "1");
            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("startDate", startDate.ToString("yyyy-MM-dd"));
            request.AddUrlSegment("endDate", endDate.ToString("yyyy-MM-dd"));

            var result = self.Client.Execute<List<LeadTypeCount>>(request);

            if (result.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception(result.ErrorMessage);
            }

            return result.Data;
        }

        public static List<LeadTypeCount> GetLeadTypes(this WowClient self, string clientId)
        {
            var request = new RestRequest
            {
                Resource = "client/{clientId}/leads/types",
                RequestFormat = DataFormat.Json
            };

            request.AddHeader("api-version", "1");
            request.AddUrlSegment("clientId", clientId);

            var result = self.Client.Execute<List<LeadTypeCount>>(request);

            if (result.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception(result.ErrorMessage);
            }

            return result.Data;
        }
        
    }
}