using System.ComponentModel.DataAnnotations;

namespace sandboxapp.Models.Ultimates
{
    /// <summary>
    /// Represents a single Ultimate Premium record
    /// This is one row in the database for a specific combination of:
    /// Class, ReservingClass, YOA, DistributionChannel, Currency
    /// </summary>
    public class UltimatePremiumRecordModel
    {
        // Primary Key
        public int UltimatePremiumID { get; set; }

        // Audit/Version Tracking
        public int UpdateID { get; set; }

        // Business Keys (Resolution Level)
        [Required]
        public string Class { get; set; } = string.Empty;

        [Required]
        public string ReservingClass { get; set; } = string.Empty;

        [Required]
        public int YOA { get; set; }

        [Required]
        public string DistributionChannel { get; set; } = string.Empty; // 'EU' or 'LNDN'

        [Required]
        public string Currency { get; set; } = string.Empty;

        // Ultimate Premium Fields
        public decimal? UltimateGrossPremium { get; set; }
        public decimal? UltimateNetPremium { get; set; }
        public decimal? UltimateRIPs { get; set; } // Reinstatement Premiums
        public decimal? UltimatePC { get; set; } // Profit Commission

        // Audit Fields
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string? LastUpdatedBy { get; set; }

        // UI Helper - Track if this is a new row being added
        public bool IsNew { get; set; } = false;

        // UI Helper - Track if this row has been modified
        public bool IsModified { get; set; } = false;
    }
}
