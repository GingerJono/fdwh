namespace Sandbox.Models.Prism
{
    public class ORIPolIncurredClaimsMappingModel
    {
        public int RunID { get; set; }
        public string ContractCcy { get; set; }
        public string ORIPolicyReference { get; set; }
        public DateTime? ClaimMadeDate { get; set; }
        public DateTime? LossDate { get; set; }
        public DateTime? RiskAttachmentDate { get; set; }
        public string Clm_Bpr_Cref { get; set; }
        public string InwardPolicyReference { get; set; }
        public string UCR { get; set; }
        public string PlacementUMR { get; set; }
        public string ProgrammeRef { get; set; }
        public int? YoA { get; set; }
        public string AssuredName { get; set; }
        public string Class { get; set; }
        public string ClassDesc { get; set; }
        public string ReservingClass { get; set; }
        public string ReservingClassDesc { get; set; }
        public string Subclass { get; set; }
        public string SubclassDesc { get; set; }
        public string StatCode1 { get; set; }
        public string StatCode2 { get; set; }
        public string ReassuredName { get; set; }
        public string DomicileCountry { get; set; }
        public string DomicileState { get; set; }
        public int? SCMYOA { get; set; }
        public string SCMvsPolicyYOAMismatch { get; set; }
        public string SCMRiskCode { get; set; }
        public string PolicyMainRiskCode { get; set; }
        public DateTime? DOL { get; set; }
        public string LossNarrative { get; set; }
        public string LloydsCatCode { get; set; }
        public string EventCode { get; set; }
        public string EventCodeDesc { get; set; }
        public string CatClaim { get; set; }
        public string BlockIndicator { get; set; }
        public string LloydsLeader { get; set; }
        public string UniqueClaimKey { get; set; }
        public string Mvt_Orig_CCY { get; set; }
        public string Mvt_Sett_CCY { get; set; }

        public decimal OS_Fee_Mvt_SCC { get; set; }
        public decimal OS_Indemnity_SCC { get; set; }
        public decimal Settled_Fee_Mvt_SCC { get; set; }
        public decimal Settled_Indemnity_Mvt_SCC { get; set; }
        public decimal Paid_SCC { get; set; }
        public decimal OS_SCC { get; set; }
        public decimal Incurred_SCC { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public decimal FXRateFromMvt_Sett_CCYToContractCcy { get; set; }
        public decimal Paid_SCCInContractCcy { get; set; }
        public decimal Incurred_SCCInContractCcy { get; set; }
    }
}
