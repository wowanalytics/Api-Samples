using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wow.ApiLibrary.Models
{
    /// <summary>
    /// Class RecieveTrackedLinks.
    /// </summary>
    public class RecieveTrackedLinks
    {
        /// <summary>
        /// Gets or sets the process identifier.
        /// </summary>
        /// <value>The process identifier.</value>
        public Guid ProcessId { get; set; }

        /// <summary>
        /// Gets or sets the tracked links.
        /// </summary>
        /// <value>The tracked links.</value>
        public List<TrackedLink> TrackedLinks { get; set; }
    }

    /// <summary>
    /// Class TrackedLink.
    /// </summary>
    public class TrackedLink
    {
        /// <summary>
        /// Gets or sets the link identifier.
        /// </summary>
        /// <value>The link identifier.</value>
        public Guid LinkId { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        /// <value>The categories.</value>
        public List<string> Categories { get; set; }

        /// <summary>
        /// Gets or sets the visited.
        /// </summary>
        /// <value>The visited.</value>
        public DateTime Visited { get; set; }

        /// <summary>
        /// Gets or sets the type of the page.
        /// </summary>
        /// <value>The type of the page.</value>
        public string PageType { get; set; }

        /// <summary>
        /// Gets or sets the lead identifier.
        /// </summary>
        /// <value>The lead identifier.</value>
        public Guid? LeadId { get; set; }

        /// <summary>
        /// Gets or sets the referer URL.
        /// </summary>
        /// <value>The referer URL.</value>
        public string RefererUrl { get; set; }

        /// <summary>
        /// Gets or sets the WebBrowser.
        /// </summary>
        /// <value>The WebBrowser.</value>
        public string WebBrowser { get; set; }

        /// <summary>
        /// Gets or sets the campaign.
        /// </summary>
        /// <value>The campaign.</value>
        public string Campaign { get; set; }

        /// <summary>
        /// Gets or sets the page score.
        /// </summary>
        /// <value>The page score.</value>
        public int PageScore { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>The source.</value>
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the medium.
        /// </summary>
        /// <value>The medium.</value>
        public string Medium { get; set; }

        /// <summary>
        /// Gets or sets the term.
        /// </summary>
        /// <value>The term.</value>
        public string Term { get; set; }

        /// <summary>
        /// Gets or sets the contact identifier.
        /// </summary>
        /// <value>The contact identifier.</value>
        public Guid? ContactId { get; set; }

        /// <summary>
        /// Gets or sets the CRM person identifier.
        /// </summary>
        /// <value>The CRM person identifier.</value>
        public string CrmPersonId { get; set; }

        /// <summary>
        /// Gets or sets the type of the CRM.
        /// </summary>
        /// <value>The type of the CRM.</value>
        public string CrmType { get; set; }

        /// <summary>
        /// Gets or sets the CRM account identifier.
        /// </summary>
        /// <value>The CRM account identifier.</value>
        public string CrmAccountId { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>The email address.</value>
        public string EmailAddress { get; set; }

    }
}
