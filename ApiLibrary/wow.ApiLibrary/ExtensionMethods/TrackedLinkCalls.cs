using System;
using System.Globalization;
using System.Net.Http;
using wow.ApiLibrary.Models;
using PortableRest;
using System.Threading.Tasks;

namespace wow.ApiLibrary.ExtensionMethods
{
    /// <summary>
    /// Class TrackedLinkCalls.
    /// </summary>
    public static class TrackedLinkCalls
    {
        /// <summary>
        /// Gets the tracked links.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="take">The take.</param>
        /// <returns>Task&lt;RecieveTrackedLinks&gt;.</returns>
        /// <exception cref="HttpRequestException">
        /// Throws an exception if the <see cref="P:System.Net.Http.HttpResponseMessage.IsSuccessStatusCode" /> property for the HTTP response is false.
        /// </exception>
        public async static Task<RecieveTrackedLinks> GetTrackedLinksAsync(this WowClient self, string clientId, int take)
        {
            var request = new RestRequest
                {
                    Resource = "client/{clientId}/trackedlinks/{take}"
                };

            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("take", take.ToString(CultureInfo.InvariantCulture));

            var result = await self.Client.ExecuteAsync<RecieveTrackedLinks>(request);

            return result;
        }

        /// <summary>
        /// Gets the tracked links.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="take">The take.</param>
        /// <returns>RecieveTrackedLinks.</returns>
        public static RecieveTrackedLinks GetTrackedLinks(this WowClient self, string clientId, int take)
        {
            var request = new RestRequest
            {
                Resource = "client/{clientId}/trackedlinks/{take}"
            };

            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("take", take.ToString(CultureInfo.InvariantCulture));

            var result = AsyncHelpers.RunSync(() => self.Client.ExecuteAsync<RecieveTrackedLinks>(request));

            return result;
        }

        /// <summary>
        /// Marks the tracked links processed.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="processId">The process identifier.</param>
        /// <returns>Task&lt;System.Boolean&gt;.</returns>
        /// <exception cref="HttpRequestException">
        /// Throws an exception if the <see cref="P:System.Net.Http.HttpResponseMessage.IsSuccessStatusCode" /> property for the HTTP response is false.
        /// </exception>
        public async static Task<bool> MarkTrackedLinksProcessedAsync(this WowClient self, string clientId, Guid processId)
        {
            var request = new RestRequest
                {
                    Resource = "client/{clientId}/trackedlinks/markprocessed/{processId}"
                };

            request.AddHeader("api-version", "1");
            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("processId", processId.ToString());

            var result = await self.Client.ExecuteAsync<BasicResult>(request);

            return result.Result;
        }

        /// <summary>
        /// Marks the tracked links processed.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="processId">The process identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool MarkTrackedLinksProcessed(this WowClient self, string clientId, Guid processId)
        {
            var request = new RestRequest
            {
                Resource = "client/{clientId}/trackedlinks/markprocessed/{processId}"
            };

            request.AddHeader("api-version", "1");
            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("processId", processId.ToString());

            var result = AsyncHelpers.RunSync(() => self.Client.ExecuteAsync<BasicResult>(request));

            return result.Result;
        }
    }
}