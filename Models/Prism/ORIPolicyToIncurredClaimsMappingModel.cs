namespace Sandbox.Models.Prism
{
    public class ORIPolicyToIncurredClaimsMappingModel
    {
        public string ORIPolicyReference { get; set; } = string.Empty;
        public string? InceptionDate { get; set; }
        public string? EffectiveDate { get; set; }
        public DateTime? FXRateApplicationDate { get; set; }
        public string? ContractCcy { get; set; }
        public int? IsCommuted { get; set; }
        public DateTime? ClaimMadeDate { get; set; }
        public DateTime? LossDate { get; set; }
        public DateTime? RiskAttachmentDate { get; set; }
        public string? Clm_Bpr_Cref { get; set; }
        public string? InwardPolicyReference { get; set; }
        public string? UCR { get; set; }
        public string? PlacementUMR { get; set; }
        public string? ProgrammeRef { get; set; }
        public string? YOA { get; set; }
        public string? AssuredName { get; set; }
        public string? Class { get; set; }
        public string? ClassDesc { get; set; }
        public string? ReservingClass { get; set; }
        public string? ReservingClassDesc { get; set; }
        public string? Subclass { get; set; }
        public string? SubclassDesc { get; set; }
        public string? StatCode1 { get; set; }
        public string? StatCode2 { get; set; }
        public string? ReassuredName { get; set; }
        public string? DomicileCountry { get; set; }
        public string? DomicileState { get; set; }
        public string? SCMYOA { get; set; }
        public string? SCMvsPolicyYOAMismatch { get; set; }
        public string? SCMRiskCode { get; set; }
        public string? PolicyMainRiskCode { get; set; }
        public string? DOL { get; set; }
        public string? LossNarrative { get; set; }
        public string? LloydsCatCode { get; set; }
        public string? EventCode { get; set; }
        public string? EventCodeDesc { get; set; }
        public string? CatClaim { get; set; }
        public string? BlockIndicator { get; set; }
        public string? LloydsLeader { get; set; }
        public int? UniqueClaimKey { get; set; }
        public string? Mvt_Orig_CCY { get; set; }
        public string? Mvt_Sett_CCY { get; set; }
        public double? FXRateFromMvt_Sett_CCYToContractCcy { get; set; }
        public double? OS_Fee_Mvt_SCC { get; set; }
        public double? OS_Indemnity_SCC { get; set; }
        public double? Settled_Fee_Mvt_SCC { get; set; }
        public double? Settled_Indemnity_Mvt_SCC { get; set; }
        public double? Paid_SCC { get; set; }
        public double? OS_SCC { get; set; }
        public double? Incurred_SCC { get; set; }
        public double? Paid_SCCInContractCcy { get; set; }
        public double? Incurred_SCCInContractCcy { get; set; }
        public long? RunID { get; set; }
        public long? AdjustmentID { get; set; }
    }
}
