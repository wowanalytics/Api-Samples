using System;
using System.Globalization;
using RestSharp;
using wow.ApiLibrary.Models;

namespace wow.ApiLibrary.ExtensionMethods
{
    public static class TrackedLinkCalls
    {
        public static RecieveTrackedLinks GetTrackedLinks(this WowClient self, string clientId, int take)
        {
            var request = new RestRequest
                {
                    Resource = "client/{clientId}/trackedlinks/{take}",
                    RequestFormat = DataFormat.Json
                };

            request.AddHeader("api-version", "1");
            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("take", take.ToString(CultureInfo.InvariantCulture));

            var result = self.Client.Execute<RecieveTrackedLinks>(request);

            if (result.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception(result.ErrorMessage);
            }

            return result.Data;
        }

        public static bool MarkTrackedLinksProcessed(this WowClient self, string clientId, Guid processId)
        {
            var request = new RestRequest
                {
                    Resource = "client/{clientId}/trackedlinks/markprocessed/{processId}",
                    RequestFormat = DataFormat.Json
                };

            request.AddHeader("api-version", "1");
            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("processId", processId.ToString());

            var result = self.Client.Execute<BasicResult>(request);

            if (result.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception(result.ErrorMessage);
            }

            return result.Data.Result;
        }
    }
}