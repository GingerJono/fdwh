using System.ComponentModel.DataAnnotations;

namespace sandboxapp.Models.Ultimates
{
    /// <summary>
    /// Represents a versioned snapshot of Premium data
    /// Insert-only, never updated
    /// </summary>
    public class PremiumModel
    {
        [Required]
        public string Class { get; set; } = string.Empty;

        [Required]
        public string ReservingClass { get; set; } = string.Empty;

        [Required]
        public int YOA { get; set; }

        [Required]
        public int Version { get; set; }

        [Required]
        public string Selection { get; set; } = "Manual"; // Plan | Written | Signed | Manual

        [Required]
        public string GrossNetEntry { get; set; } = "Gross"; // Gross | Net

        // Manual Entry Fields (GBP values)
        public decimal? ManualGrossPremiumGBP { get; set; }
        public decimal? ManualNetPremiumGBP { get; set; }
        public decimal? ManualDeductions { get; set; } // As percentage

        // Currency Split Percentages (must sum to 100)
        public decimal? ManualSplitGBP { get; set; }
        public decimal? ManualSplitUSD { get; set; }
        public decimal? ManualSplitCAD { get; set; }
        public decimal? ManualSplitEUR { get; set; }
        public decimal? ManualSplitJPY { get; set; }

        // EU/LNDN Split Percentage (EU %, LNDN is 100-EU)
        public decimal? ManualEUSplit { get; set; }

        public DateTime DateUpdated { get; set; }

        public string UpdatedBy { get; set; } = string.Empty;

        public string? UpdateComments { get; set; }
    }
}
