namespace Sandbox.Models.ORI
{
    public class ORIAdjustmentUploadModel
    {
        public int AdjustmentID { get; set; }
        public string? UploadedBy { get; set; }
        public DateTime UploadedAt { get; set; }
        public string? AdjustmentFileName { get; set; }

        // Add any additional columns returned by your SP
    }
}
