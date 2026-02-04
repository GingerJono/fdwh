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

        // ========== Selection-based getters ==========

        /// <summary>
        /// Get GGWP based on selection type
        /// </summary>
        public decimal GetGGWP(string selection) => selection switch
        {
            "Plan" => PlanGGWP ?? 0,
            "Written" => WrittenGGWP ?? 0,
            "Signed" => SignedGGWP ?? 0,
            _ => ManualGGWP ?? 0
        };

        /// <summary>
        /// Get Deductions based on selection type
        /// </summary>
        public decimal GetDeductions(string selection) => selection switch
        {
            "Plan" => PlanDeductions ?? 0,
            "Written" => WrittenDeductions ?? 0,
            "Signed" => SignedDeductions ?? 0,
            _ => ManualDeductions ?? 0
        };

        /// <summary>
        /// Get GNWP based on selection type
        /// </summary>
        public decimal GetGNWP(string selection) => selection switch
        {
            "Plan" => PlanGNWP ?? 0,
            "Written" => WrittenGNWP ?? 0,
            "Signed" => SignedGNWP ?? 0,
            _ => ManualGNWP ?? 0
        };

        /// <summary>
        /// Get Currency Split based on selection type (as decimal, e.g., 0.5 = 50%)
        /// </summary>
        public decimal GetCcySplit(string selection) => selection switch
        {
            "Plan" => PlanCcySplit ?? 0,
            "Written" => WrittenCcySplit ?? 0,
            "Signed" => SignedCcySplit ?? 0,
            _ => ManualCcySplit ?? 0
        };

        /// <summary>
        /// Get Currency Split as percentage for display (e.g., 50 for 50%)
        /// </summary>
        public decimal GetCcySplitPercent(string selection) => GetCcySplit(selection) * 100;

        /// <summary>
        /// Get EU Split based on selection type (as decimal, e.g., 0.5 = 50%)
        /// </summary>
        public decimal GetEUSplit(string selection) => selection switch
        {
            "Plan" => PlanEUSplit ?? 0,
            "Written" => WrittenEUSplit ?? 0,
            "Signed" => SignedEUSplit ?? 0,
            _ => ManualEUSplit ?? 0
        };

        /// <summary>
        /// Get EU Split as percentage for display (e.g., 50 for 50%)
        /// </summary>
        public decimal GetEUSplitPercent(string selection) => GetEUSplit(selection) * 100;

        /// <summary>
        /// Get LNDN Split as percentage (100 - EU Split %)
        /// </summary>
        public decimal GetLNDNSplitPercent(string selection) => 100 - GetEUSplitPercent(selection);

        // ========== Setters for Manual values ==========

        /// <summary>
        /// Set Manual Currency Split from percentage value
        /// </summary>
        public void SetManualCcySplitPercent(decimal percent) => ManualCcySplit = percent / 100;

        /// <summary>
        /// Set Manual EU Split from percentage value
        /// </summary>
        public void SetManualEUSplitPercent(decimal percent) => ManualEUSplit = percent / 100;

        // ========== Copy selection values to Selected/Manual fields ==========

        /// <summary>
        /// Copy values from specified selection to Selected fields
        /// </summary>
        public void CopyToSelected(string selection)
        {
            SelectedGGWP = GetGGWP(selection);
            SelectedDeductions = GetDeductions(selection);
            SelectedGNWP = GetGNWP(selection);
            SelectedEU = GetValue(selection, "EU");
        }

        /// <summary>
        /// Copy CcySplit from specified selection to SelectedCcySplit and ManualCcySplit
        /// </summary>
        public void CopyCcySplitToSelected(string selection)
        {
            var value = GetCcySplit(selection);
            SelectedCcySplit = value;
            if (selection != "Manual")
            {
                ManualCcySplit = value;
            }
        }

        /// <summary>
        /// Copy EUSplit from specified selection to SelectedEUSplit and ManualEUSplit
        /// </summary>
        public void CopyEUSplitToSelected(string selection)
        {
            var value = GetEUSplit(selection);
            SelectedEUSplit = value;
            if (selection != "Manual")
            {
                ManualEUSplit = value;
            }
        }

        /// <summary>
        /// Get value by selection type and field (generic accessor)
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
