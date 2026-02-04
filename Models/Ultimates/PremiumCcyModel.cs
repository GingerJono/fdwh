namespace sandboxapp.Models.Ultimates
{
    public class PremiumCcyModel
    {
        public string Class { get; set; } = string.Empty;
        public string ReservingClass { get; set; } = string.Empty;
        public int YOA { get; set; }
        public int Version { get; set; }
        public string Currency { get; set; } = string.Empty;

        // Selected values
        public decimal? SelectedGGWP { get; set; }
        public decimal? SelectedDeductions { get; set; }
        public decimal? SelectedGNWP { get; set; }
        public decimal? SelectedEU { get; set; }
        public decimal? SelectedCcySplit { get; set; }
        public decimal? SelectedEUSplit { get; set; }

        // Manual values
        public decimal? ManualGGWP { get; set; }
        public decimal? ManualDeductions { get; set; }
        public decimal? ManualGNWP { get; set; }
        public decimal? ManualEU { get; set; }
        public decimal? ManualCcySplit { get; set; }
        public decimal? ManualEUSplit { get; set; }

        // Plan values
        public decimal? PlanGGWP { get; set; }
        public decimal? PlanDeductions { get; set; }
        public decimal? PlanGNWP { get; set; }
        public decimal? PlanEU { get; set; }
        public decimal? PlanCcySplit { get; set; }
        public decimal? PlanEUSplit { get; set; }

        // Written values
        public decimal? WrittenGGWP { get; set; }
        public decimal? WrittenDeductions { get; set; }
        public decimal? WrittenGNWP { get; set; }
        public decimal? WrittenEU { get; set; }
        public decimal? WrittenCcySplit { get; set; }
        public decimal? WrittenEUSplit { get; set; }

        // Signed values
        public decimal? SignedGGWP { get; set; }
        public decimal? SignedDeductions { get; set; }
        public decimal? SignedGNWP { get; set; }
        public decimal? SignedEU { get; set; }
        public decimal? SignedCcySplit { get; set; }
        public decimal? SignedEUSplit { get; set; }
    }
}
