namespace Sandbox.Models.Prism
{
    public class ORIActualRecoveriesModel
    {
        public string ORIPolicyReference { get; set; } = string.Empty;
        public string USMID { get; set; } = string.Empty;
        public string? USMCaCategoryDesc { get; set; }
        public string? ClosingCcy { get; set; }
        public string? SettCcy { get; set; }
        public double? LineAmountSCC { get; set; }
        public long RunID { get; set; }
    }
}
