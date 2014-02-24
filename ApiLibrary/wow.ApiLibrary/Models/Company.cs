namespace wow.ApiLibrary.Models
{
    /// <summary>
    /// Class CompanyDetails.
    /// </summary>
    public class CompanyDetails
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        /// <value>The domain.</value>
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        /// <value>The county.</value>
        public string County { get; set; }

        /// <summary>
        /// Gets or sets the post code.
        /// </summary>
        /// <value>The post code.</value>
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>The country.</value>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the employees.
        /// </summary>
        /// <value>The employees.</value>
        public string Employees { get; set; }

        /// <summary>
        /// Gets or sets the industry sector.
        /// </summary>
        /// <value>The industry sector.</value>
        public IndustrySector IndustrySector { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        /// <value>The region.</value>
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>The phone number.</value>
        public string PhoneNumber { get; set; }
    }

    /// <summary>
    /// Class IndustrySector.
    /// </summary>
    public class IndustrySector
    {
        /// <summary>
        /// Gets or sets the sic code.
        /// </summary>
        /// <value>The sic code.</value>
        public string SicCode { get; set; }

        /// <summary>
        /// Gets or sets the level1.
        /// </summary>
        /// <value>The level1.</value>
        public string Level1 { get; set; }

        /// <summary>
        /// Gets or sets the level2.
        /// </summary>
        /// <value>The level2.</value>
        public string Level2 { get; set; }

        /// <summary>
        /// Gets or sets the level3.
        /// </summary>
        /// <value>The level3.</value>
        public string Level3 { get; set; }
    }
}
