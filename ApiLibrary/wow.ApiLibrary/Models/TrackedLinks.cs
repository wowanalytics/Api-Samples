using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wow.ApiLibrary.Models
{
    public class RecieveTrackedLinks
    {
        public Guid ProcessId { get; set; }

        public IList<TrackedLink> TrackedLinks { get; set; }
    }

    public class TrackedLink
    {
        public string Title { get; set; }

        public string Url { get; set; }

        public List<string> Categories { get; set; }

        public DateTime Visited { get; set; }

        public string PageType { get; set; }

        public Guid? LeadId { get; set; }

        public string RefererUrl { get; set; }

        public string WebBrowser { get; set; }

        public string Campaign { get; set; }

        public int PageScore { get; set; }

        public string Source { get; set; }

        public string Medium { get; set; }

        public string Term { get; set; }

        public Guid? ContactId { get; set; }

        public string CrmPersonId { get; set; }

        public string CrmType { get; set; }

        public string CrmAccountId { get; set; }

        public string EmailAddress { get; set; }

    }
}
