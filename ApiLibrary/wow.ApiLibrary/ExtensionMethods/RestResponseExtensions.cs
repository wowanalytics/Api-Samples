using System;
using System.Net;

namespace wow.ApiLibrary.ExtensionMethods
{
    //public static class RestResponseExtensions
    //{
    //    public static void CheckAndHandleErrors<T>(this IRestResponse<T> response)
    //    {
    //        if (response.StatusCode != HttpStatusCode.OK)
    //        {
    //            var url = response.Request.Resource;
    //            response.Request.Parameters.ForEach(p =>
    //            {
    //                url = url.ToLower().Replace(string.Format("{{{0}}}", p.Name.ToLower()), p.Value.ToString());
    //            });

    //            throw new Exception(string.Format("Error calling api endpoint: {0}\n\nError: {1}", url, response.ErrorMessage ?? response.StatusDescription), response.ErrorException ?? new Exception(response.Content));
    //        }
    //    }
    //}
}