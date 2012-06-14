using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using RestSharp;
using wow.ApiLibrary.Authentication;
using wow.ApiLibrary.Models;

namespace wow.ApiLibrary
{
    /// <summary>
    /// WOW Rest Api Client
    /// </summary>
    /// <remarks></remarks>
    public class WowClient
    {
        /// <summary>
        /// The RestClient that will make the calls
        /// </summary>
        private RestClient _client;

        /// <summary>
        /// Initializes a new instance of the <see cref="WowClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <remarks></remarks>
        public WowClient(string apiKey)
            : this("http://api.app.wowanalytics.co.uk", apiKey)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WowClient"/> class.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="apiKey">The API key.</param>
        /// <remarks></remarks>
        public WowClient(string baseUrl, string apiKey)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var assemblyName = new AssemblyName(assembly.FullName);
            var version = assemblyName.Version;

            _client = new RestClient(baseUrl);
            _client.UserAgent = "wow.ApiLibrary/" + version;
            _client = new RestClient(baseUrl);
            _client.Authenticator = new ApiKeyAuthentication(apiKey);
        }

        
        public Result<List<Client>> GetClients()
        {
            var request = new RestRequest
            {
                Resource = "clients/available",
                DateFormat = "yyyy-MM-dd HH:mm:ss",
                RequestFormat = DataFormat.Json
            };

            var result = _client.Execute<Result<List<Client>>>(request);

            if (result.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception(result.ErrorMessage);
            }

            return result.Data;
        }

        public Result<ClientDetails> GetClientDetails(string clientId)
        {
            var request = new RestRequest
            {
                Resource = "clients/detail/{clientId}",
                RequestFormat = DataFormat.Json
            };

            request.AddUrlSegment("clientId", clientId);

            var result = _client.Execute<Result<ClientDetails>>(request);

            if (result.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception(result.ErrorMessage);
            }

            if (result.Data.Error != null)
            {
                throw new Exception(result.Data.Error.Description);
            }

            return result.Data;

        }

        public Result<List<Lead>> GetLatestLeads(string clientId, int lastMinutes, int numberToGet = 10)
        {
            if (lastMinutes > 60)
            {
                throw new ArgumentException("You can only get the leads for the last 60 minutes", "lastMinutes");
            }

            var request = new RestRequest
            {
                Resource = "leads/latest/{clientId}/{minutes}/{numberToGet}",
                RequestFormat = DataFormat.Json
            };

            request.AddUrlSegment("clientId", clientId);
            request.AddUrlSegment("minutes", lastMinutes.ToString());
            request.AddUrlSegment("numberToGet", numberToGet.ToString());

            var result = _client.Execute<Result<List<Lead>>>(request);

            if (result.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception(result.ErrorMessage);
            }

            if (result.Data.Error != null)
            {
                throw new Exception(result.Data.Error.Description);
            }

            return result.Data;

        }

    }
}
