using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;

namespace wow.ApiLibrary.Authentication
{
    public class BasicAuthentication : IAuthenticator
    {
        private readonly string _username;
        private readonly string _password;

        public BasicAuthentication(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            request.AddHeader("_username", _username);
            request.AddHeader("_password", _password);
        }
    }
}
