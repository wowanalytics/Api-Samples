using System;
using System.Collections.Generic;
using System.Net;
using RestSharp;
using wow.ApiLibrary.Models;

namespace wow.ApiLibrary.ExtensionMethods
{
    public static class ClientsCalls
    {
        public static List<Client> Clients(this WowClient self)
        {
            var request = new RestRequest
                {
                    Resource = "clients"
                };

            request.AddHeader("api-version", "1");

            var result = self.Client.Execute<List<Client>>(request);

            if (result.ResponseStatus != ResponseStatus.Completed || result.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(result.ErrorMessage);
            }

            return result.Data;
        }

        public static ClientDetails GetClientDetails(this WowClient self, string clientId)
        {
            var request = new RestRequest
                {
                    Resource = "clients/{clientId}"
                };

            request.AddHeader("api-version", "1");
            request.AddUrlSegment("clientId", clientId);

            var result = self.Client.Execute<ClientDetails>(request);

            if (result.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception(result.ErrorMessage);
            }

            return result.Data;

        }

    }
}