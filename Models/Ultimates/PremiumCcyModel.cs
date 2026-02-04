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

        // Calculated EU Amounts (GNWP × EU Split %)
        public decimal PlanEUAmount => (PlanGNWP ?? 0) * (PlanEUSplit ?? 0);
        public decimal WrittenEUAmount => (WrittenGNWP ?? 0) * (WrittenEUSplit ?? 0);
        public decimal SignedEUAmount => (SignedGNWP ?? 0) * (SignedEUSplit ?? 0);
        public decimal ManualEUAmount => (ManualGNWP ?? 0) * (ManualEUSplit ?? 0);

        // Calculated LNDN Amounts (GNWP × (1 - EU Split %))
        public decimal PlanLNDNAmount => (PlanGNWP ?? 0) * (1 - (PlanEUSplit ?? 0));
        public decimal WrittenLNDNAmount => (WrittenGNWP ?? 0) * (1 - (WrittenEUSplit ?? 0));
        public decimal SignedLNDNAmount => (SignedGNWP ?? 0) * (1 - (SignedEUSplit ?? 0));
        public decimal ManualLNDNAmount => (ManualGNWP ?? 0) * (1 - (ManualEUSplit ?? 0));

        /// <summary>
        /// Get EU amount based on selection type for GNWP and EU split selection
        /// </summary>
        public decimal GetEUAmount(string gnwpSelection, string euSplitSelection)
        {
            var gnwp = gnwpSelection switch
            {
                "Plan" => PlanGNWP ?? 0,
                "Written" => WrittenGNWP ?? 0,
                "Signed" => SignedGNWP ?? 0,
                _ => ManualGNWP ?? 0
            };

            var euSplit = euSplitSelection switch
            {
                "Plan" => PlanEUSplit ?? 0,
                "Written" => WrittenEUSplit ?? 0,
                "Signed" => SignedEUSplit ?? 0,
                _ => ManualEUSplit ?? 0
            };

            return gnwp * euSplit;
        }

        /// <summary>
        /// Get LNDN amount based on selection type for GNWP and EU split selection
        /// </summary>
        public decimal GetLNDNAmount(string gnwpSelection, string euSplitSelection)
        {
            var gnwp = gnwpSelection switch
            {
                "Plan" => PlanGNWP ?? 0,
                "Written" => WrittenGNWP ?? 0,
                "Signed" => SignedGNWP ?? 0,
                _ => ManualGNWP ?? 0
            };

            var euSplit = euSplitSelection switch
            {
                "Plan" => PlanEUSplit ?? 0,
                "Written" => WrittenEUSplit ?? 0,
                "Signed" => SignedEUSplit ?? 0,
                _ => ManualEUSplit ?? 0
            };

            return gnwp * (1 - euSplit);
        }

        /// <summary>
        /// Get value by selection type and field
        /// </summary>
        public decimal? GetValue(string selection, string field)
        {
            return (selection, field) switch
            {
                ("Plan", "GGWP") => PlanGGWP,
                ("Plan", "Deductions") => PlanDeductions,
                ("Plan", "GNWP") => PlanGNWP,
                ("Plan", "EU") => PlanEU,
                ("Plan", "CcySplit") => PlanCcySplit,
                ("Plan", "EUSplit") => PlanEUSplit,

                ("Written", "GGWP") => WrittenGGWP,
                ("Written", "Deductions") => WrittenDeductions,
                ("Written", "GNWP") => WrittenGNWP,
                ("Written", "EU") => WrittenEU,
                ("Written", "CcySplit") => WrittenCcySplit,
                ("Written", "EUSplit") => WrittenEUSplit,

                ("Signed", "GGWP") => SignedGGWP,
                ("Signed", "Deductions") => SignedDeductions,
                ("Signed", "GNWP") => SignedGNWP,
                ("Signed", "EU") => SignedEU,
                ("Signed", "CcySplit") => SignedCcySplit,
                ("Signed", "EUSplit") => SignedEUSplit,

                ("Manual", "GGWP") => ManualGGWP,
                ("Manual", "Deductions") => ManualDeductions,
                ("Manual", "GNWP") => ManualGNWP,
                ("Manual", "EU") => ManualEU,
                ("Manual", "CcySplit") => ManualCcySplit,
                ("Manual", "EUSplit") => ManualEUSplit,

                _ => null
            };
        }
    }
}
