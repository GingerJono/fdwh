using CardModel;

namespace Index1
{
    public class Index1Table {
        public decimal id { get; set; }
        public string? categoryclass { get; set; }
        public string? title { get; set; }
        public string? price { get; set; }
        public string? Percentage { get; set; }
        public string? badge { get; set; }
        public string? badgeclass { get; set; }
        public bool Selected { get; set; }
        public string? img { get; set; }
        public string? customer { get; set; }
        public string? email { get; set; }
        public string? Product { get; set; }
        public string? Quantity { get; set; }
        public string? date { get; set; }

    };
    public class SalesOverview {
        public string? Month { get; set; } = string.Empty;
        public decimal growth { get; set; }
        public decimal profit { get; set; }
        public decimal sales { get; set; }
    }; 
    
    public class TotalOrders
    {
        public string? Source { get; set; }
        public int SourceValue { get; set; }
    };
    
    public class SalesStatistics {
        public string? Week { get; set; }
        public decimal Total { get; set; }
        public decimal ThisYear { get; set; }
        public decimal LastYear { get; set; }
    } ;
    public class LineGraphChart : ILineGraph {
        public decimal Series { get; set; }
        public decimal Value { get; set; }
    } ;
    public class OverallStats {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? TotalValue { get; set; }
        public string? Percentage { get; set; }
        public bool? IsIncreased { get; set; }
    }


}

