using CardModel;
namespace Analytics
{
    public class AnalyticChart : ILineGraph {
        public decimal Series { get; set; }
        public decimal Value { get; set; }
    } ;
    public class AudienceMetric {
        public string? Month { get; set; }
        public decimal Viewers { get; set; }
        public decimal Followers { get; set; }
        public decimal Sessions { get; set; }
    } ;
     public class Referrals
    {
        public string? ReferralsName { get; set; }
        public int ReferralsValue { get; set; }
    } ;
    public class SalesGrowthRate {
        public string? Month { get; set; }
        public decimal LastYear { get; set; }
        public decimal ThisYear { get; set; }
    } ;
    public class AnalyticActivity {
        public int? Id { get; set; }
        public string? Icon { get; set; }
        public string? IconClass { get; set; }
        public string? Title { get; set; }
        public string? TotalValue { get; set; }
        public string? Percentage { get; set; }
        public bool? IsIncreased { get; set; }
    };
    public class SiteTable {
        public int Id { get; set; }
        public string? Title {get; set;}
        public string? Total {get; set;}
        public string? Growth {get; set;}
        public bool IsGrowth {get; set;}
        public string[] SiteTableHeaders { get; set; }
        
        public SiteTable()
        {
            SiteTableHeaders = new string[] { "Source", "Total", "Growth" };  
        }
    }
    public class VisitorsTable {
        public int Id { get; set; }
        public string? Visitors {get; set;}
        public string? VisitorsClass {get; set;}
        public string? Duration {get; set;}
        public string? DurationClass {get; set;}
        public string? New {get; set;}        
        public string? NewClass {get; set;}
        public string? Returning {get; set;}
        public string? ReturningClass {get; set;}
        public string? BounceRate {get; set;}
        public string? BounceRateClass {get; set;}
        public string? ConversionRate {get; set;}
        public string? ConversionRateClass {get; set;}
        public string? Average  {get; set;}
        public string? AverageClass {get; set;}
        public string? Referral  {get; set;}
        public string? ReferralClass {get; set;}
    }
}

