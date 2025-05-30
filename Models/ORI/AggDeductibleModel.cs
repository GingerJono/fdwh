namespace Sandbox.Models.ORI
{
    public class AggDeductibleModel
    {
        public required string ORIPolicyReference { get; set; }
        public required decimal Deductible { get; set; }
        public required int ApplicationPriority { get; set; } // 1 for first, 2 for second, etc.
        public required string LastUpdated { get; set; }
        public required string LastUpdatedBy { get; set; }
        public string? Peril { get; set; } // Optional, can be null if not applicable
        public string? PerilRegion { get; set; }
        public string? Note { get; set; } // Optional, can be null if not applicable
        public int IsDeleted { get; set; }
    }
}
