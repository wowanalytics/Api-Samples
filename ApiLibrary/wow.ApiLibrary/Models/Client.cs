﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wow.ApiLibrary.Models
{
    /// <summary>
    /// Class Client.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        public Guid Id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the account expiry.
        /// </summary>
        /// <value>The account expiry.</value>
        public DateTime? AccountExpiry { get; set; }

        /// <summary>
        /// Gets or sets the tracking code.
        /// </summary>
        /// <value>The tracking code.</value>
        public string TrackingCode { get; set; }

        /// <summary>
        /// Gets or sets the domains.
        /// </summary>
        /// <value>The domains.</value>
        public List<string> Domains { get; set; }
    }
}
