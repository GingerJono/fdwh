namespace sandboxapp.Models.Ultimates
{
    public class FxRateSetModel
    {
        public int FxRateSetID { get; set; }
        public string RateSetName { get; set; } = string.Empty;
        public string? RateSetDescription { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public bool IsActive { get; set; }
    }
}
