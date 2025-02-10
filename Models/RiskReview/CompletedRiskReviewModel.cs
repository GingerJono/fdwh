using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Collections.Generic;

namespace Sandbox.Models.RiskReview
{
    [Table("RiskReviews", Schema = "RiskReview")]
    public class CompletedRiskReviewModel
    {
        [Required]
        public int RiskReviewID { get; set; }
        [Required]
        public string ProgramRef { get; set; }
        public string? Assured { get; set; }
        public string? Reassured { get; set; }
        public string? Class { get; set; }
        public string? ReservingClass { get; set; }
        public bool IsLBS { get; set; }
        public string? RiskDescription { get; set; }

        public int? RiskReviewsDone { get; set; }
        public decimal? AverageRiskReviewScore { get; set; }
		public decimal? AverageUWReviewScore { get; set; }
		public DateTime? UWReviewed { get; set; }

		public DateTime? LastUpdated { get; set; }
        public string? LastUpdater { get; set; }
		public string? UW { get; set; }
        public int? YOA { get; set; }

	}
}