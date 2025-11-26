namespace Sandbox.Models.Prism
{
    public class SubjectInwardPoliciesModel
    {
        public string? ORIPolicyReference { get; set; }
        public string? ContractCcy { get; set; }
        public string? PolicyType { get; set; }
        public string? Limit { get; set; }
        public double? DeductibleRetention { get; set; }
        public double? Cession { get; set; }
        public double? OrderPercent { get; set; }
        public string? QSBasis { get; set; }
        public string? WholeOrOrder { get; set; }
        public string? InwardPolicyReference { get; set; }
        public string? PlacementUMR { get; set; }
        public string? SettCcy { get; set; }
        public DateTime? InceptionDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? YOA { get; set; }
        public string? Class { get; set; }
        public string? ReservingClass { get; set; }
        public string? RiskCode { get; set; }
        public string? StatCode1 { get; set; }
        public string? StatCode2 { get; set; }
        public string? LloydsLOBCode { get; set; }
        public string? DistributionChannel { get; set; }
        public double? GGWP { get; set; }
        public double? GNWP { get; set; }
        public double? GGEP { get; set; }
        public double? GNEP { get; set; }
        public double? GGAP { get; set; }
        public double? GNAP { get; set; }
        public double? EarnedPercent { get; set; }
        public DateTime? UseSigningsThresholdDate { get; set; }
        public bool? UseSignings { get; set; }
        public bool? IsFinalAdjusted { get; set; }
        public double? FXRateFromSettCcyToContractCcy { get; set; }
        public double? GGWPInContractCcy { get; set; }
        public double? GNWPInContractCcy { get; set; }
        public double? GGEPInContractCcy { get; set; }
        public double? GNEPInContractCcy { get; set; }
        public double? GGAPInContractCcy { get; set; }
        public double? GNAPInContractCcy { get; set; }
        public double? WrittenPremiumBasis { get; set; }
        public double? AllocationBasis { get; set; }
        public long RunID { get; set; }
    }
}
