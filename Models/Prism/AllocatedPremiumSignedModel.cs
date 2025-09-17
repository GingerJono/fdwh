namespace Sandbox.Models.Prism
{
    public class AllocatedPremiumSignedModel
    {
        public string ORIPolicyReference { get; set; } = string.Empty;
        public string SettCcy { get; set; } = string.Empty;
        public string RiskCode { get; set; } = string.Empty;

        public string? Class { get; set; }
        public string? YOA { get; set; }
        public string? LORSId { get; set; }

        public double? AllocatedPremiumBySecurity { get; set; }
        

        public long RunID { get; set; }
    }
}

