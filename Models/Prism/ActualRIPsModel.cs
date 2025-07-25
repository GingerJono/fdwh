namespace Sandbox.Models.Prism
{
    public class ORIActualRIPsModel
    {
        public string ORIPolicyReference { get; set; } = string.Empty;
        public string? USMID { get; set; }
        public string? LPSONo { get; set; }
        public DateTime? LPSODate { get; set; }
        public string? LPSOVersionNo { get; set; }
        public string? UserSequenceNo { get; set; }
        public string? SyndicateNo { get; set; }
        public string? InstalmentNo { get; set; }
        public string? TreatySection { get; set; }
        public string? SyndicateLineNo { get; set; }
        public string? USMCaCategoryDesc { get; set; }
        public string? ClosingCcy { get; set; }
        public string? SettCcy { get; set; }
        public double? LineAmountSCC { get; set; }
        public long RunID { get; set; }
    }
}
