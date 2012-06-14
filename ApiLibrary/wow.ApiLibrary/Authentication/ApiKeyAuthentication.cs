using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;

namespace wow.ApiLibrary.Authentication
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    public class ApiKeyAuthentication : IAuthenticator
    {
        /// <summary>
        /// The api key for accessing WOW Analytics Api
        /// </summary>
        private readonly string _apiKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyAuthentication"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <remarks></remarks>
        public ApiKeyAuthentication(string apiKey)
        {
            _apiKey = apiKey;
        }

        #region Implementation of IAuthenticator

        /// <summary>
        /// Authenticates the specified client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="request">The request.</param>
        /// <remarks></remarks>
        public void Authenticate(IRestClient client, IRestRequest request)
        {
            request.AddHeader("_apiKey", _apiKey);
        }

        #endregion
    }
}
