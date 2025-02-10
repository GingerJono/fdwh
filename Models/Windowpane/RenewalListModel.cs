namespace Sandbox.Models.Windowpane
{
    public class RenewalListModel
    {
        public DateTime Month { get; set; }
        public List<Renewal> Renewals { get; set; } = new List<Renewal>();
        public List<NewBusiness> NewBusinesses { get; set; } = new List<NewBusiness>();
    }

    public class Renewal
    {
        public string ExpiringRef { get; set; }
        public string Assured { get; set; }
        public DateTime RenewalDate { get; set; }
        public string Status { get; set; }
        public string Underwriter { get; set; }
    }
    public class NewBusiness
    {
        public string PolicyRef { get; set; }
        public string Assured { get; set; }
        public DateTime InceptionDate { get; set; }
        public string Status { get; set; }
        public string Underwriter { get; set; }
    }
}
