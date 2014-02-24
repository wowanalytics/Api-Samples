using System;

namespace wow.ApiLibrary.Models
{
    public class Lead
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
        /// Gets or sets the who has been assigned the lead.
        /// </summary>
        /// <value>The assigned to.</value>
        public User AssignedTo { get; set; }

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
        /// Gets or sets the date that the lead was assigned.
        /// </summary>
        /// <value>The assigned date.</value>
        public DateTime? AssignedDate { get; set; }

        /// <summary>
        /// Gets or sets the date of the leads first visit
        /// </summary>
        /// <value>The first visit.</value>
        public DateTime? FirstVisit { get; set; }

    }
}