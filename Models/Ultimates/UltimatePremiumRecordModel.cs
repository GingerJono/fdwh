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

        // Value Type (how the value is set)
        [Required]
        public string ValueType { get; set; } = "Value"; // 'Written', 'Signed', 'Plan', 'Value'

        // Gross or Net indicator
        [Required]
        public string GrossNet { get; set; } = "Gross"; // 'Gross' or 'Net'

        // Ultimate Premium Fields
        public decimal? UltimatePremium { get; set; } // Renamed from UltimateGrossPremium - represents either Gross or Net based on GrossNet
        public decimal? UltimateNetPremium { get; set; } // Calculated based on UltimatePremium and Deductions
        public decimal? Deductions { get; set; } // Percentage stored as decimal (e.g., 0.15 for 15%)
        public decimal? UltimateRIPs { get; set; } // Reinstatement Premiums
        public decimal? UltimatePC { get; set; } // Profit Commission

        // Audit Fields (from Updates table)
        public DateTime? UpdateDate { get; set; }
        public string? UpdatedBy { get; set; }

        // UI Helper - Track if this is a new row being added
        public bool IsNew { get; set; } = false;

        // UI Helper - Track if this row has been modified
        public bool IsModified { get; set; } = false;
    }
}
