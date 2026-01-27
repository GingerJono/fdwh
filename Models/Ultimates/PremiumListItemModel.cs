namespace sandboxapp.Models.Ultimates
{
    /// <summary>
    /// View model for displaying Premium records in the list
    /// Represents the latest version for each Class/ReservingClass/YOA combination
    /// </summary>
    public class PremiumListItemModel
    {
        public string Class { get; set; } = string.Empty;
        public string ReservingClass { get; set; } = string.Empty;
        public int YOA { get; set; }
        public int Version { get; set; }
        public string Selection { get; set; } = string.Empty;
        public string GrossNetEntry { get; set; } = string.Empty;
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
        public string? UpdateComments { get; set; }
    }
}
