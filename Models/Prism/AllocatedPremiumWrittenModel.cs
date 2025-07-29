namespace Sandbox.Models.Prism
{
    public class AllocatedPremiumWrittenModel
    {
        public string ORIPolicyReference { get; set; } = string.Empty;
        public string SettCcy { get; set; } = string.Empty;
        public DateTime? PremiumWrittenDate { get; set; } 

        public string? Class { get; set; }
        public string? YOA { get; set; }
        public string? RiskCode { get; set; }

        public double? WrittenPremium { get; set; }
        

        public long RunID { get; set; }
    }
}

