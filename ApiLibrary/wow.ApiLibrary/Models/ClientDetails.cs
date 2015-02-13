using System;
using System.Collections.Generic;

namespace wow.ApiLibrary.Models
{
    /// <summary>
    /// Contains details about a client
    /// </summary>
    /// <remarks></remarks>
    public class ClientDetails
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        /// <remarks></remarks>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the account expiry.
        /// </summary>
        /// <value>The account expiry.</value>
        /// <remarks></remarks>
        public DateTime? AccountExpiry { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        /// <remarks></remarks>
        public string Name { get; set; }


        /// <summary>
        /// Gets or sets the company visits today.
        /// </summary>
        /// <value>The company visits today.</value>
        /// <remarks></remarks>
        public int CompanyVisitsToday { get; set; }

        /// <summary>
        /// Gets or sets the company visits this month.
        /// </summary>
        /// <value>The company visits this month.</value>
        /// <remarks></remarks>
        public int CompanyVisitsThisMonth { get; set; }

        /// <summary>
        /// Gets or sets the domains.
        /// </summary>
        /// <value>The domains.</value>
        public List<string> Domains { get; set; }
    }
}