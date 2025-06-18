namespace Sandbox.Models.Prism
{
    public class UltimateClaimsByORIPolicyByEventModel
    {
        public long? RunID { get; set; }
        public string? ORIPolicyReference { get; set; }
        public string? EventCode { get; set; }
        public string? ContractCcy { get; set; }
        public decimal? UltimateClaimsInContractCcy { get; set; }
        public decimal? UltimateBasisRecoveriesInContractCcy { get; set; }
        public decimal? UltimateBasisRIPsInContractCcy { get; set; }
        public decimal? ResidualUltimateClaimsInContractCcy { get; set; }
        public decimal? Deductible_Retention { get; set; }
    }
}
