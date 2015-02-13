using System;
using System.Collections.Generic;

namespace wow.ApiLibrary.Models
{
	public class Lead : IEquatable<Lead>
    {
        /// <summary>
        /// Gets or sets the id of the lead.
        /// </summary>
        /// <value>The id.</value>
        /// <remarks></remarks>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the total score.
        /// </summary>
        /// <value>The total score.</value>
        /// <remarks></remarks>
        public int TotalScore { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        /// <remarks></remarks>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        /// <remarks></remarks>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        /// <value>The name of the company.</value>
        /// <remarks></remarks>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the perma link.
        /// </summary>
        /// <value>The perma link.</value>
        /// <remarks></remarks>
        public string PermaLink { get; set; }

        /// <summary>
        /// Gets or sets the last email address visited from for the lead.
        /// </summary>
        /// <value>The email address.</value>
        /// <remarks></remarks>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The client id that the lead belongs to
        /// </summary>
        /// <value>The client id.</value>
        /// <remarks></remarks>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the date that the lead last visited.
        /// </summary>
        /// <value>The last visit.</value>
        public DateTime? LastVisit { get; set; }

        /// <summary>
        /// Gets or sets the lead band.
        /// </summary>
        /// <value>The lead band.</value>
        public string LeadBand { get; set; }

        /// <summary>
        /// Gets or sets the date of the leads first visit
        /// </summary>
        /// <value>The first visit.</value>
        public DateTime? FirstVisit { get; set; }

		public List<User> AssignedTo { get; set; }

		public CompanyDetails Company { get; set; }

		#region IEquatable implementation

		public bool Equals(Lead other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;

			return this.Id.Equals (other.Id);
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Lead);
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode ();
		}

		/// <summary>
		/// Implements the ==.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator ==(Lead left, Lead right)
		{
			return Equals(left, right);
		}

		/// <summary>
		/// Implements the !=.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>The result of the operator.</returns>
		public static bool operator !=(Lead left, Lead right)
		{
			return !Equals(left, right);
		}

		#endregion
    }
}