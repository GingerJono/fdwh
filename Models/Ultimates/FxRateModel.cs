namespace sandboxapp.Models.Ultimates
{
    public class FxRateModel
    {
        public int FxRateID { get; set; }
        public int FxRateSetID { get; set; }
        public string RateSetName { get; set; } = string.Empty;
        public string? RateSetDescription { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string FromCurrency { get; set; } = string.Empty;
        public string ToCurrency { get; set; } = string.Empty;
        public decimal Rate { get; set; }
    }
}
