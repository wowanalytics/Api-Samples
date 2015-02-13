using PortableRest;

namespace wow.ApiLibrary
{
    /// <summary>
    /// Interface IAuthenticator
    /// </summary>
	public interface IAuthenticator
	{
        /// <summary>
        /// Sets the authentication.
        /// </summary>
        /// <param name="client">The client.</param>
		void SetAuthentication (RestClient client);
	}

}
