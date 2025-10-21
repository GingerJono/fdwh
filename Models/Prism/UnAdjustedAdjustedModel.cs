namespace Sandbox.Models.Prism
{
    public class UnAdjustedAdjustedModel
    {
        public string ORIPolicyReference { get; set; } = string.Empty;
        public string Metric { get; set; } = string.Empty;
        public decimal Unadjusted { get; set; }
        public decimal Adjusted { get; set; }
    }
}
