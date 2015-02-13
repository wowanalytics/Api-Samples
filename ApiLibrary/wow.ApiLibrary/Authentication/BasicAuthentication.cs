using PortableRest;

namespace wow.ApiLibrary.Authentication
{
    /// <summary>
    /// Class BasicAuthentication.
    /// </summary>
    public class BasicAuthentication : IAuthenticator
    {
        /// <summary>
        /// The _username
        /// </summary>
        private readonly string _username;
        /// <summary>
        /// The _password
        /// </summary>
        private readonly string _password;

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicAuthentication"/> class.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        public BasicAuthentication(string username, string password)
        {
            _username = username;
            _password = password;
        }

        /// <summary>
        /// Sets the authentication.
        /// </summary>
        /// <param name="client">The client.</param>
        public void SetAuthentication(RestClient client)
        {

            client.AddHeader("_username", _username);
            client.AddHeader("_password", _password);

        }
    }
}
