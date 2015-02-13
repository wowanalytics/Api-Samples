using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using PortableRest;

namespace wow.ApiLibrary.ExtensionMethods
{
    /// <summary>
    /// Class SettingCalls.
    /// </summary>
    public static class SettingCalls
    {
        // this WowClient self, 
        /// <summary>
        /// get lead types as an asynchronous operation.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <returns>Task&lt;List&lt;System.String&gt;&gt;.</returns>
        /// <exception cref="HttpRequestException">
        /// Throws an exception if the <see cref="P:System.Net.Http.HttpResponseMessage.IsSuccessStatusCode" /> property for the HTTP response is false.
        /// </exception>
        public async static Task<List<string>> GetLeadTypesAsync(this WowClient self)
        {

            var request = new RestRequest
                {
                    Resource = "settings/leadtypes"
                };

            var result = await self.Client.ExecuteAsync<List<string>>(request);

            return result;
        }

        /// <summary>
        /// Gets the lead types.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <returns>List&lt;System.String&gt;.</returns>
        public static List<string> GetLeadTypes(this WowClient self)
        {

            var request = new RestRequest
            {
                Resource = "settings/leadtypes"
            };

            var result = AsyncHelpers.RunSync(() => self.Client.ExecuteAsync<List<string>>(request));

            return result;
        }
    }
}