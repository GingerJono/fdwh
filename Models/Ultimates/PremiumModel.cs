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

        public DateTime DateUpdated { get; set; }

        public string UpdatedBy { get; set; } = string.Empty;

        public string? UpdateComments { get; set; }
    }
}
