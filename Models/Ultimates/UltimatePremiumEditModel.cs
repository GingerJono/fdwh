namespace sandboxapp.Models.Ultimates
{
    /// <summary>
    /// Model for editing Ultimate Premium data at Class/YOA level
    /// Contains all records (combinations) for a specific Class and YOA
    /// </summary>
    public class UltimatePremiumEditModel
    {
        // Filter criteria
        public string Class { get; set; } = string.Empty;
        public int YOA { get; set; }

        // Collection of records for this Class/YOA
        public List<UltimatePremiumRecordModel> Records { get; set; } = new();

        // Track removed records for deletion
        public List<UltimatePremiumRecordModel> RemovedRecords { get; set; } = new();

        // Summary totals (calculated from Records)
        public decimal TotalUltimatePremium => Records.Sum(r => r.UltimatePremium ?? 0);
        public decimal TotalUltimateNetPremium => Records.Sum(r => r.UltimateNetPremium ?? 0);
        public decimal TotalUltimateRIPs => Records.Sum(r => r.UltimateRIPs ?? 0);
        public decimal TotalUltimatePC => Records.Sum(r => r.UltimatePC ?? 0);

        // Audit info
        public DateTime? UpdateDate { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
