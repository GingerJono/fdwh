namespace Sandbox.Models.Prism
{
    public class WrittenPremiumDimensionAllocationsModel
    {
        public string ORIPolicyReference { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public string YOA { get; set; } = string.Empty;
        public string ReservingClass { get; set; } = string.Empty;
        public string DistributionChannel { get; set; } = string.Empty;
        public decimal WrittenPremium { get; set; }
        public decimal Allocation { get; set; }

    }
}
