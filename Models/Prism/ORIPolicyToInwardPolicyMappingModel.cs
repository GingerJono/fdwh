namespace Sandbox.Models.Prism
{
    public class ORIPolicyToInwardPolicyMappingModel
    {
        public string ORIPolicyReference { get; set; } = string.Empty;
        public DateTime? FXRateApplicationDate { get; set; }
        public string? ContractCcy { get; set; }
        public long? IsCommuted { get; set; }
        public string? InwardPolicyReference { get; set; }
        public string? Class { get; set; }
        public string? ReservingClass { get; set; }
        public string? DomicileCountry { get; set; }
        public DateTime? InceptionDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? RiskCode { get; set; }
        public string? StatCode1 { get; set; }
        public string? StatCode2 { get; set; }
        public string? PlacementUMR { get; set; }
        public string? PolicyType { get; set; }
        public string? LloydsLOBCode { get; set; }
        public string? YOA { get; set; }
        public double? GrossGrossWrittenPremiumGBPAtQtrFX { get; set; }
        public long RunID { get; set; }
        public long? AdjustmentID { get; set; }
    }
}
