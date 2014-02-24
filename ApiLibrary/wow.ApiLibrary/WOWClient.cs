using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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
        /// Initializes a new instance of the <see cref="WowClient" /> class.
        /// </summary>
        /// <param name="authenticator">The authenticator to use.</param>
        public WowClient(IAuthenticator authenticator)
            : this("http://api.app.wowanalytics.co.uk", authenticator)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WowClient" /> class.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="authenticator">The authenticator.</param>
        public WowClient(string baseUrl, IAuthenticator authenticator)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var assemblyName = new AssemblyName(assembly.FullName);
            var version = assemblyName.Version;

            Client = new RestClient(baseUrl)
                {
                    UserAgent = "wow.ApiLibrary/" + version,
                    Authenticator = authenticator
                };
        }

        
        /// <summary>
        /// The RestClient that will make the calls
        /// </summary>
        public RestClient Client { get; private set; }
    }
}
