namespace Sandbox.Models.Prism
{
    public class AllocatedPremiumWrittenModel
    {
        public string ORIPolicyReference { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public string? YOA { get; set; }
        public string? Class { get; set; }
        public string? ReservingClass { get; set; }
        public string? RiskCode { get; set; }
        public string? DistributionChannel { get; set; }
        public string? LORSId { get; set; }
        public double? WrittenPremium { get; set; }
        public long RunID { get; set; }
    }
}

