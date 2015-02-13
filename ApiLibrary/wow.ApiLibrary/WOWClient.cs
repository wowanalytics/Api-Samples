using System.Diagnostics;
using PortableRest;

namespace wow.ApiLibrary
{
    /// <summary>
    /// WOW Rest Api Client
    /// </summary>
    /// <remarks></remarks>
    public class WowClient
    {
        protected IAuthenticator Authenticator { get; set; }

        public int ApiVersion { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WowClient" /> class.
        /// </summary>
        /// <param name="authenticator">The authenticator to use.</param>
        public WowClient(IAuthenticator authenticator)
            : this("https://api.app.wowanalytics.co.uk", authenticator, 2, "UnKnown")
        {
        }

        public WowClient(IAuthenticator authenticator, string application)
            : this("https://api.app.wowanalytics.co.uk", authenticator, 2, application)
        {
        }

        public WowClient(string baseUrl, IAuthenticator authenticator, int apiVersion, string application)
        {
            Client = new RestClient()
            {
                BaseUrl = baseUrl,
                UserAgent = "wow.ApiLibrary/" + application
            };

            Client.JsonSerializerSettings = new Newtonsoft.Json.JsonSerializerSettings
            {
                Error = (sender, e) =>
                {
                    Debug.WriteLine(e.ToString());
                },
                ConstructorHandling = Newtonsoft.Json.ConstructorHandling.AllowNonPublicDefaultConstructor
            };

            Client.AddHeader("api-version", apiVersion.ToString());
            authenticator.SetAuthentication(Client);
        }

        public RestClient Client { get; private set; }
    }
}
