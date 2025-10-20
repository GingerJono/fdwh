namespace Sandbox.Models.Prism
{
    public class AllocatedOverridersAndProfitCommissionModel
    {
        public string ORIPolicyReference { get; set; } = string.Empty;
        public string EventCode { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public string? Class { get; set; }
        public string? YOA { get; set; }
        public string? ReservingClass { get; set; }
        public string? DistributionChannel { get; set; }
        public string? LORSId { get; set; }
        public string? Security { get; set; }       

        public double? SignedUWExpenses { get; set; }
        public double? SignedOverrider { get; set; }
        public double? SignedProfitCommission { get; set; }

        public double? WrittenUWExpenses { get; set; }
        public double? WrittenOverrider { get; set; }
        public double? WrittenProfitCommission { get; set; }

        public long RunID { get; set; }
    }
}
