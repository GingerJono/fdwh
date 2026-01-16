namespace sandboxapp.Models.Windowpane
{
    public class BindersMetadataItem
    {
        public string PolicyRef { get; set; }
        public int? RequiresClaimsBdx { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public string Class { get; set; }
        public int? Yoa { get; set; }
        public string AssuredName { get; set; }
    }

    public class UpdateBindersMetadataRequest
    {
        public string PolicyRef { get; set; }
        public int? RequiresClaimsBdx { get; set; }
        public string UpdatedBy { get; set; }
    }
}
