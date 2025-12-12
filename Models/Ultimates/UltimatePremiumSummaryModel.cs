namespace sandboxapp.Models.Ultimates
{
    /// <summary>
    /// Summary model for Ultimate Premium by Class/YOA
    /// Used for list/navigation views
    /// </summary>
    public class UltimatePremiumSummaryModel
    {
        // Grouping keys
        public string Class { get; set; } = string.Empty;
        public int YOA { get; set; }

        // Counts
        public int RecordCount { get; set; }
        public int UpdateCount { get; set; } // Number of times this Class/YOA has been updated

        // Aggregated totals (from current snapshot)
        public decimal? TotalUltimateGrossPremium { get; set; }
        public decimal? TotalUltimateNetPremium { get; set; }
        public decimal? TotalUltimateRIPs { get; set; }
        public decimal? TotalUltimatePC { get; set; }

        // Audit information
        public DateTime? LastUpdatedDate { get; set; }
        public string? LastUpdatedBy { get; set; }
    }
}
