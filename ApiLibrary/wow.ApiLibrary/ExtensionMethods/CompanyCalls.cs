using System;
using System.Collections.Generic;
using System.Net;
using RestSharp;
using wow.ApiLibrary.Models;

namespace wow.ApiLibrary.ExtensionMethods
{
    public static class CompanyCalls
    {
        public static CompanyDetails CompanyDetails(this WowClient self, string clientId, Guid leadId)
        {
            var request = new RestRequest
                {
                    Resource = "client/{clientid}/company/{leadid}"
                };

            request.AddHeader("api-version", "1");
            request.AddUrlSegment("leadid", leadId.ToString());
            request.AddUrlSegment("clientid", clientId);

            var result = self.Client.Execute<CompanyDetails>(request);

            result.CheckAndHandleErrors();

            return result.Data;
        }

    }
}