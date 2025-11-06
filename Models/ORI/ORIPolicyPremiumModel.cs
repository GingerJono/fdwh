namespace Sandbox.Models.ORI
{
    public class ORIPolicyPremiumModel
    {
        public string ORIPolicyReference { get; set; } = default!;
        public string Period { get; set; } = default!; // YYYYMM
        public bool IsFinalAdjusted { get; set; }
        public decimal? GrossSubjectPremium { get; set; }
        public decimal? AdjustableRate { get; set; }
        public decimal? MinimumPremium { get; set; }
        public string LastUpdatedBy { get; set; } = default!;
        public DateTime LastUpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsModified { get; set; }
    }
}