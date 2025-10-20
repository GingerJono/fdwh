namespace Sandbox.Models.Prism
{
    public class AllocatedActualRecoveriesModel
    {
        public string ORIPolicyReference { get; set; } = string.Empty;
        public string EventCode { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public string? Class { get; set; }
        public string? YOA { get; set; }
        public string? ReservingClass { get; set; }
        public string? DistributionChannel { get; set; }
        public string? LORSId { get; set; }
        public string? Security { get; set; }       
        public decimal ActualRecoveries { get; set; } 
        public long RunID { get; set; }
    }
}
