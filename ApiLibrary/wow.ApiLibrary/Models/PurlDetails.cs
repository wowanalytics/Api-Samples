using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wow.ApiLibrary.Models
{
    public class PurlDetails
    {
        /// <summary>
        /// Email Address for the PURL
        /// </summary>
        /// <value>The email address.</value>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The URL that the PURL should point too
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get; set; }

        /// <summary>
        /// Campaign Name (product, promo code, or slogan)
        /// </summary>
        /// <value>The campaign.</value>
        public string Campaign { get; set; }

        /// <summary>
        /// Alter user adding the PURL when it is used
        /// </summary>
        /// <value><c>true</c> if alert; otherwise, <c>false</c>.</value>
        public bool Alert { get; set; }

    }

    public class ShortCodeDetails
    {
        /// <summary>
        /// The URL for the PURL, if the PURL failed to be created with will be blank, check <see cref="Message"/> for reason
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get; set; }

        /// <summary>
        /// This is the short code of the PURL, if the PURL failed to be created with will be blank, check <see cref="Message"/> for reason
        /// </summary>
        /// <value>The short code.</value>
        public string ShortCode { get; set; }

        /// <summary>
        /// Is the supplied URL for the PURL allowed to be hosted in an iFrame
        /// </summary>
        /// <value><c>true</c> if [frame option deny]; otherwise, <c>false</c>.</value>
        public bool FrameOptionsDeny { get; set; }

        /// <summary>
        /// Message about any possible issues. 
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; set; }
    }
}
