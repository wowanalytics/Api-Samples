using System;
using System.Collections.Generic;
using wow.ApiLibrary.Models;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using PortableRest;

namespace wow.ApiLibrary.ExtensionMethods
{
    /// <summary>
    /// Class LeadCalls.
    /// </summary>
    public static class LeadCalls
    {
        /// <summary>
        /// get latest leads as an asynchronous operation.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="lastMinutes">The last minutes.</param>
        /// <param name="numberToGet">The number to get.</param>
        /// <returns>Task&lt;List&lt;Lead&gt;&gt;.</returns>
        /// <exception cref="System.ArgumentException">You can only get the leads for the last 60 minutes;lastMinutes</exception>
        /// <exception cref="ArgumentException">You can only get the leads for the last 60 minutes</exception>
        /// <exception cref="HttpRequestException">
        /// Throws an exception if the <see cref="P:System.Net.Http.HttpResponseMessage.IsSuccessStatusCode" /> property for the HTTP response is false.
        /// </exception>
        public async static Task<List<Lead>> GetLatestLeadsAsync(this WowClient self, string clientId, int lastMinutes, int numberToGet = 10)
        {
            if (lastMinutes > 60)
            {
                throw new ArgumentException("You can only get the leads for the last 60 minutes", "lastMinutes");
            }

            var request = new RestRequest
            {
                Resource = "latestleads/{clientId}/{minutes}/{numberToGet}"
            };

            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("minutes", lastMinutes.ToString());
            request.AddUrlSegment("numberToGet", numberToGet.ToString());

            var result = await self.Client.ExecuteAsync<List<Lead>>(request);

            return result;

        }

        /// <summary>
        /// Gets the latest leads.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="lastMinutes">The last minutes.</param>
        /// <param name="numberToGet">The number to get.</param>
        /// <returns>List&lt;Lead&gt;.</returns>
        /// <exception cref="System.ArgumentException">You can only get the leads for the last 60 minutes;lastMinutes</exception>
        public static List<Lead> GetLatestLeads(this WowClient self, string clientId, int lastMinutes, int numberToGet = 10)
        {
            if (lastMinutes > 60)
            {
                throw new ArgumentException("You can only get the leads for the last 60 minutes", "lastMinutes");
            }

            var request = new RestRequest
            {
                Resource = "latestleads/{clientId}/{minutes}/{numberToGet}"
            };

            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("minutes", lastMinutes.ToString());
            request.AddUrlSegment("numberToGet", numberToGet.ToString());

            var result = AsyncHelpers.RunSync(() => self.Client.ExecuteAsync<List<Lead>>(request));

            return result;

        }

        /// <summary>
        /// get leads as an asynchronous operation.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="type">The type.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="page">The page.</param>
        /// <param name="take">The take.</param>
        /// <returns>Task&lt;LeadApiPagedList&gt;.</returns>
        /// <exception cref="HttpRequestException">
        /// Throws an exception if the <see cref="P:System.Net.Http.HttpResponseMessage.IsSuccessStatusCode" /> property for the HTTP response is false.
        /// </exception>
        public async static Task<LeadApiPagedList> GetLeadsAsync(this WowClient self, string clientId, string type, DateTime startDate, DateTime endDate, int page, int take)
        {

            var request = new RestRequest
            {
                Resource = "client/{clientId}/leads/{type}/{startDate}/{endDate}/{page}/{take}",
                ContentType = ContentTypes.Json
            };

            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("type", type);
            request.AddUrlSegment("startDate", startDate.ToString("yyyy-MM-dd"));
            request.AddUrlSegment("endDate", endDate.ToString("yyyy-MM-dd"));
            request.AddUrlSegment("page", page.ToString());
            request.AddUrlSegment("take", take.ToString());


            var result = await self.Client.ExecuteAsync<LeadApiPagedList>(request);

            return result;

        }

        /// <summary>
        /// Gets the leads.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="type">The type.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="page">The page.</param>
        /// <param name="take">The take.</param>
        /// <returns>LeadApiPagedList.</returns>
        public static LeadApiPagedList GetLeads(this WowClient self, string clientId, string type, DateTime startDate, DateTime endDate, int page, int take)
        {

            var request = new RestRequest
            {
                Resource = "client/{clientId}/leads/{type}/{startDate}/{endDate}/{page}/{take}",
                ContentType = ContentTypes.Json
            };

            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("type", type);
            request.AddUrlSegment("startDate", startDate.ToString("yyyy-MM-dd"));
            request.AddUrlSegment("endDate", endDate.ToString("yyyy-MM-dd"));
            request.AddUrlSegment("page", page.ToString());
            request.AddUrlSegment("take", take.ToString());


            var result = AsyncHelpers.RunSync(() => self.Client.ExecuteAsync<LeadApiPagedList>(request));

            return result;

        }

        /// <summary>
        /// Gets the lead.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="leadId">The lead identifier.</param>
        /// <returns>Task&lt;Lead&gt;.</returns>
        /// <exception cref="HttpRequestException">Throws an exception if the <see cref="P:System.Net.Http.HttpResponseMessage.IsSuccessStatusCode" /> property for the HTTP response is false.</exception>
        public async static Task<Lead> GetLeadAsync(this WowClient self, string clientId, Guid leadId)
        {
            var request = new RestRequest
            {
                Resource = "client/{clientId}/lead/{leadId}"
            };

            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("leadId", leadId.ToString());

            var result = await self.Client.ExecuteAsync<Lead>(request);

            return result;
        }

        /// <summary>
        /// Gets the lead.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="leadId">The lead identifier.</param>
        /// <returns>Lead.</returns>
        public static Lead GetLead(this WowClient self, string clientId, Guid leadId)
        {
            var request = new RestRequest
            {
                Resource = "client/{clientId}/lead/{leadId}"
            };

            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("leadId", leadId.ToString());

            var result = AsyncHelpers.RunSync(() => self.Client.ExecuteAsync<Lead>(request));

            return result;
        }

        /// <summary>
        /// get lead types as an asynchronous operation.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns>Task&lt;List&lt;LeadTypeCount&gt;&gt;.</returns>
        /// <exception cref="HttpRequestException">
        /// Throws an exception if the <see cref="P:System.Net.Http.HttpResponseMessage.IsSuccessStatusCode" /> property for the HTTP response is false.
        /// </exception>
        public static async Task<List<LeadTypeCount>> GetLeadTypesAsync(this WowClient self, string clientId, DateTime startDate, DateTime endDate)
        {
            var request = new RestRequest
            {
                Resource = "client/{clientId}/leads/types/{startDate}/{endDate}"
            };

            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("startDate", startDate.ToString("yyyy-MM-dd"));
            request.AddUrlSegment("endDate", endDate.ToString("yyyy-MM-dd"));

            var result = await self.Client.ExecuteAsync<List<LeadTypeCount>>(request);

            return result;
        }


        /// <summary>
        /// Gets the lead types.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns>List&lt;LeadTypeCount&gt;.</returns>
        public static List<LeadTypeCount> GetLeadTypes(this WowClient self, string clientId, DateTime startDate, DateTime endDate)
        {
            var request = new RestRequest
            {
                Resource = "client/{clientId}/leads/types/{startDate}/{endDate}"
            };

            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("startDate", startDate.ToString("yyyy-MM-dd"));
            request.AddUrlSegment("endDate", endDate.ToString("yyyy-MM-dd"));

            var result = AsyncHelpers.RunSync(() => self.Client.ExecuteAsync<List<LeadTypeCount>>(request));

            return result;
        }

        /// <summary>
        /// get lead types as an asynchronous operation.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <returns>Task&lt;List&lt;LeadTypeCount&gt;&gt;.</returns>
        /// <exception cref="HttpRequestException">
        /// Throws an exception if the <see cref="P:System.Net.Http.HttpResponseMessage.IsSuccessStatusCode" /> property for the HTTP response is false.
        /// </exception>
        public async static Task<List<LeadTypeCount>> GetLeadTypesAsync(this WowClient self, string clientId)
        {
            var request = new RestRequest
            {
                Resource = "client/{clientId}/leads/types"
            };

            request.AddUrlSegment("clientId", clientId);

            var result = await self.Client.ExecuteAsync<List<LeadTypeCount>>(request);

            return result;
        }

        /// <summary>
        /// Gets the lead types.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <returns>List&lt;LeadTypeCount&gt;.</returns>
        public static List<LeadTypeCount> GetLeadTypes(this WowClient self, string clientId)
        {
            var request = new RestRequest
            {
                Resource = "client/{clientId}/leads/types"
            };

            request.AddUrlSegment("clientId", clientId);

            var result = AsyncHelpers.RunSync(() => self.Client.ExecuteAsync<List<LeadTypeCount>>(request));

            return result;
        }
    }
}