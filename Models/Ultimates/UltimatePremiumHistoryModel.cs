namespace sandboxapp.Models.Ultimates
{
    /// <summary>
    /// Represents a historical update/version of Ultimate Premium data
    /// Aggregated by UpdateID for a specific Class/YOA
    /// </summary>
    public class UltimatePremiumHistoryModel
    {
        // Version/Update tracking
        public int UpdateID { get; set; }

        // Context
        public string Class { get; set; } = string.Empty;
        public int YOA { get; set; }

        // Number of records in this update
        public int RecordCount { get; set; }

        // Aggregated totals for this update
        public decimal? TotalUltimateGrossPremium { get; set; }
        public decimal? TotalUltimateNetPremium { get; set; }
        public decimal? TotalUltimateRIPs { get; set; }
        public decimal? TotalUltimatePC { get; set; }

        // Audit information
        public DateTime? UpdateDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
