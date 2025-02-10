using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Collections.Generic;

namespace Sandbox.Models.RiskReview
{

    public class Policy
    {
        [Required]
        public string PolicyRef { get; set; }
        [Required]
        public string PolicyName { get; set; }
        [Required]
        public string UWReviewStatus { get; set; }
        public int? UWReviewScore { get; set; }
        [Required]
        public string RiskReviewStatus { get; set; }
        public int? RiskReviewScore { get; set; }
        public string? Narrative { get; set; }
        public DateTime? AccuracyCheckedDate { get; set; }
        public string? AccuracyCheckedBy { get; set; }
    }



    [Table("RiskReviews", Schema = "RiskReview")]
    public class RiskReviewModel
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

        public int? UWReviewsDone { get; set; }
        public decimal? AverageUWReviewScore { get; set; }

        public string? FlaggingLevel { get; set; }
        public int? IsFlagged { get; set; }
        public DateTime? DateFlagged { get; set; }
        public string? Status { get; set; }



        public DateTime? UWReviewed { get; set; }
        public string? UW { get; set; }


        public DateTime? LastUpdated { get; set; }
        public string? LastUpdater { get; set; }


        public string? ReviewerNarrative { get; set; }
        public string? AUWNarrative { get; set; }
        public bool CommissionOK { get; set; }
        public string? CommissionOKNote { get; set; }
        public bool WithinScopeOfSBFProtocolsGuidelines { get; set; }
        public string? WithinScopeOfSBFProtocolsGuidelinesNote { get; set; }
        public bool ClearUnderwritingRationale { get; set; }
        public string? ClearUnderwritingRationaleNote { get; set; }
        public bool PremiumSufficient { get; set; }
        public string? PremiumSufficientNote { get; set; }
        public bool NatureOfRisk { get; set; }
        public string? NatureOfRiskNote { get; set; }
        public bool NumberOfReinstAggCoverOK { get; set; }
        public string? NumberOfReinstAggCoverOKNote { get; set; }
        public bool RateMovementSensible { get; set; }
        public string? RateMovementSensibleNote { get; set; }
        public bool ProgFitWithORI { get; set; }
        public string? ProgFitWithORINote { get; set; }
        public bool CoverIssues { get; set; }
        public string? CoverIssuesNote { get; set; }
        public bool SignedOff { get; set; }
        public string? SignedOffNote { get; set; }

        // Navigation property for policies
        public virtual ICollection<Policy> Policies { get; set; } = new List<Policy>();

        // Calculated property for average ReviewScore
        //public double AverageReviewScore
        //{
        //	get
        //	{
        //		if (Policies == null || !Policies.Any()) return 0.0;
        //		return Policies.Average(p => p.ReviewScore.HasValue ? p.ReviewScore.Value : 0);
        //	}
        //}

        public Dictionary<string, string>? Metadata { get; set; }
        public IEnumerable<Dictionary<string, object>>? Documents { get; set; }
    }
}