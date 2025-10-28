namespace Sandbox.Models.Prism
{
    public class SubjectClaimsModel
    {
        public string ORIPolicyReference { get; set; } = string.Empty;
        public string? ContractCcy { get; set; }
        public DateTime? FXRateApplicationDate { get; set; }
        public double? FXRate { get; set; }
        public string? PolicyType { get; set; }
        public string? WholeOrOrder { get; set; }
        public string? ClaimReference { get; set; }
        public string? UCR { get; set; }
        public string? InwardPolicyReference { get; set; }
        public DateTime? InceptionDate { get; set; }
        public string? PlacementUMR { get; set; }
        public string? ProgrammeRef { get; set; }
        public DateTime? ClaimMadeDate { get; set; }
        public DateTime? LossDate { get; set; }
        public DateTime? RiskAttachmentDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? YOA { get; set; }
        public string? Class { get; set; }
        public string? ReservingClass { get; set; }
        public string? DistributionChannel { get; set; }
        public double? WrittenLine { get; set; }
        public string? Subclass { get; set; }
        public string? StatCode1 { get; set; }
        public string? StatCode2 { get; set; }
        public string? SCMRiskCode { get; set; }
        public string? EventCode { get; set; }
        public string? Peril { get; set; }
        public string? PerilRegion { get; set; }
        public bool? NonSpecificLoss { get; set; }
        public string? OriginalCcy { get; set; }
        public string? SettlementCcy { get; set; }
        public double? OutstandingFee { get; set; }
        public double? OutstandingIndemnity { get; set; }
        public double? SettledFee { get; set; }
        public double? SettledIndemnity { get; set; }
        public double? Paid { get; set; }
        public double? Outstanding { get; set; }
        public double? Incurred { get; set; }
        public double? PaidInContractCcy { get; set; }
        public double? IncurredInContractCcy { get; set; }
        public double? WholePaidInContractCcy { get; set; }
        public double? WholeIncurredInContractCcy { get; set; }
        public double? UltimateClaims { get; set; }
        public double? UltimateClaimsInContractCcy { get; set; }
        public long RunID { get; set; }
    }
}
