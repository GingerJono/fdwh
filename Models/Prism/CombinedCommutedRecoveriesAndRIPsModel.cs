namespace Sandbox.Models.Prism
{
    public class CombinedCommutedRecoveriesAndRIPsModel
    {
        public long? RunID { get; set; }
        public string? ORIPolicyReference { get; set; }
        public string? Ccy { get; set; }
        public decimal? ActualRecoveriesInSettCcy { get; set; }
        public decimal? ActualRIPsInSettCcy { get; set; }
        public decimal? PaidBasisRecoveriesInContractCcy { get; set; }
        public decimal? IncurredBasisRecoveriesInContractCcy { get; set; }
        public decimal? PaidBasisRIPsInContractCcy { get; set; }
        public decimal? IncurredBasisRIPsInContractCcy { get; set; }
        public decimal? UltimateBasisRecoveriesInContractCcy { get; set; }
        public decimal? UltimateBasisRIPsInContractCcy { get; set; }
    }
}
