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
    /// Class ClientsCalls.
    /// </summary>
    public static class ClientsCalls
    {
        /// <summary>
        /// clients as an asynchronous operation.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <returns>Task&lt;List&lt;Client&gt;&gt;.</returns>
        /// <exception cref="HttpRequestException">Throws an exception if the <see cref="P:System.Net.Http.HttpResponseMessage.IsSuccessStatusCode" /> property for the HTTP response is false.</exception>
        public static async Task<List<Client>> ClientsAsync(this WowClient self)
        {
            var request = new RestRequest
            {
                Resource = "clients"
            };

            var result = await self.Client.ExecuteAsync<List<Client>>(request);

            return result;
        }

        /// <summary>
        /// Clientses the specified self.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <returns>List&lt;Client&gt;.</returns>
        public static List<Client> Clients(this WowClient self)
        {
            var request = new RestRequest
            {
                Resource = "clients"
            };

            var result = AsyncHelpers.RunSync(()=>self.Client.ExecuteAsync<List<Client>>(request));

            return result;
        }

        /// <summary>
        /// get client details as an asynchronous operation.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <returns>Task&lt;ClientDetails&gt;.</returns>
        /// <exception cref="HttpRequestException">Throws an exception if the <see cref="P:System.Net.Http.HttpResponseMessage.IsSuccessStatusCode" /> property for the HTTP response is false.</exception>
        public async static Task<ClientDetails> GetClientDetailsAsync(this WowClient self, string clientId)
        {
            var request = new RestRequest
                {
                    Resource = "clients/{clientId}"
                };

            request.AddUrlSegment("clientId", clientId);

            var result = await self.Client.ExecuteAsync<ClientDetails>(request);

            return result;

        }

        /// <summary>
        /// Gets the client details.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <returns>ClientDetails.</returns>
        public static ClientDetails GetClientDetails(this WowClient self, string clientId)
        {
            var request = new RestRequest
            {
                Resource = "clients/{clientId}"
            };

            request.AddUrlSegment("clientId", clientId);

            var result = AsyncHelpers.RunSync(() => self.Client.ExecuteAsync<ClientDetails>(request));

            return result;

        }

    }
}