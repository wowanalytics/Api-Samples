namespace wow.ApiLibrary.Models
{
    public class LeadSearchModel
    {
        public LeadSearchModel()
        {
            Utm = new UtmValues();
        }

        public string SearchType { get; set; }

        public string Search { get; set; }

        public UtmValues Utm { get; set; }
    }
}