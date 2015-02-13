using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using wow.ApiLibrary.Models;
using System.Threading.Tasks;
using PortableRest;

namespace wow.ApiLibrary.ExtensionMethods
{
    /// <summary>
    /// Class CompanyCalls.
    /// </summary>
    public static class CompanyCalls
    {
        /// <summary>
        /// Companies the details.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="leadId">The lead identifier.</param>
        /// <returns>Task&lt;CompanyDetails&gt;.</returns>
        /// <exception cref="HttpRequestException">
        /// Throws an exception if the <see cref="P:System.Net.Http.HttpResponseMessage.IsSuccessStatusCode" /> property for the HTTP response is false.
        /// </exception>
        public async static Task<CompanyDetails> CompanyDetailsAsync(this WowClient self, string clientId, Guid leadId)
        {
            var request = new RestRequest
                {
                    Resource = "client/{clientid}/company/{leadid}"
                };

            request.AddUrlSegment("leadid", leadId.ToString());
            request.AddUrlSegment("clientid", clientId);

            var result = await self.Client.ExecuteAsync<CompanyDetails>(request);

            return result;
        }

        /// <summary>
        /// Companies the details.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="leadId">The lead identifier.</param>
        /// <returns>CompanyDetails.</returns>
        public static CompanyDetails CompanyDetails(this WowClient self, string clientId, Guid leadId)
        {
            var request = new RestRequest
            {
                Resource = "client/{clientid}/company/{leadid}"
            };

            request.AddUrlSegment("leadid", leadId.ToString());
            request.AddUrlSegment("clientid", clientId);

            var result = AsyncHelpers.RunSync(() => self.Client.ExecuteAsync<CompanyDetails>(request));

            return result;
        }

    }
}