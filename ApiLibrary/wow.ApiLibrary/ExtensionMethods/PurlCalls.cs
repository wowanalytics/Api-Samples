using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PortableRest;
using wow.ApiLibrary.Models;

namespace wow.ApiLibrary.ExtensionMethods
{
    public static class PurlCalls
    {
        public static async Task<ShortCodeDetails> CreatePurlAsync(this WowClient self, string clientId, PurlDetails purlDetails)
        {
            if (purlDetails == null)
            {
                throw new ArgumentNullException("purlDetails");
            }

            var request = new RestRequest
            {
                Resource = "client/{clientId}/purl/create",
                Method = HttpMethod.Post,
                ContentType = ContentTypes.Json
            };

            request.AddUrlSegment("clientId", clientId);
            request.AddParameter(purlDetails);

            var result = await self.Client.ExecuteAsync<ShortCodeDetails>(request);

            return result;

        }

        public static ShortCodeDetails CreatePurl(this WowClient self, string clientId, PurlDetails purlDetails)
        {
            if (purlDetails == null)
            {
                throw new ArgumentNullException("purlDetails");
            }

            var request = new RestRequest
            {
                Resource = "purl/client/{clientId:guid}/create",
                Method = HttpMethod.Post
            };

            request.AddUrlSegment("clientId", clientId);
            request.AddParameter(purlDetails);

            var result = AsyncHelpers.RunSync(() =>  self.Client.ExecuteAsync<ShortCodeDetails>(request));

            return result;

        }
    }
}
