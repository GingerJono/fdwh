namespace Sandbox.Models.Prism
{
    public class AllocatedPremiumModel
    {
        public string ORIPolicyReference { get; set; } = string.Empty;
        public string EventCode { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;

        public string? Class { get; set; }
        public string? YOA { get; set; }
        public string? Security { get; set; }

        public double? WrittenPremium { get; set; }
        public double? SignedPremium { get; set; }

        public long RunID { get; set; }
        public long? AdjustmentID { get; set; }
    }
}

