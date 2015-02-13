using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wow.ApiLibrary.Models
{
    /// <summary>
    /// Class LeadTypeCOunt.
    /// </summary>
    public class LeadTypeCount
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the leads.
        /// </summary>
        /// <value>The leads.</value>
        public int Leads { get; set; }
    }
}
