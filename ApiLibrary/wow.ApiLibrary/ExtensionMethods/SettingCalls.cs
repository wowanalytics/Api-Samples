using System;
using System.Collections.Generic;
using RestSharp;

namespace wow.ApiLibrary.ExtensionMethods
{
    public static class SettingCalls
    {
        // this WowClient self, 
        public static List<string> GetLeadTypes(this WowClient self)
        {
            var request = new RestRequest
                {
                    Resource = "settings/leadtypes",
                    RequestFormat = DataFormat.Json
                };

            request.AddHeader("api-version", "1");

            var result = self.Client.Execute<List<string>>(request);

            if (result.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception(result.ErrorMessage);
            }

            return result.Data;
        }
    }
}