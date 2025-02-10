
namespace TreemapData
{
    public class BasicTreemapchart
    {
        public string? BasicTreemapData { get; set; }
        public decimal BasicTreemapValue { get; set; }
    }
    public class MultiTreemapchart
    {
        public string? MultiTreemapData { get; set; }
        public decimal MultiTreemapValue { get; set; }  
        public decimal MultiTreemapValue2 { get; set; }
    }    
    public class DistributedTreemapchart
    {
        public string? DistributedTreemapData { get; set; }
        public decimal DistributedTreemapValue { get; set; }
    }
    public class ColorRangesTreemapchart
    {
        public string? ColorRangesTreemapData { get; set; }
        public decimal ColorRangesTreemapValue { get; set; }
    }
    public class TreemapService {
        public static List<BasicTreemapchart> BasicTreemapchart()
        {
            return new List<BasicTreemapchart>
            {
                new BasicTreemapchart { BasicTreemapData = "New Delhi", BasicTreemapValue = 218},
                new BasicTreemapchart { BasicTreemapData = "Kolkata",   BasicTreemapValue = 149},
                new BasicTreemapchart { BasicTreemapData = "Mumbai",    BasicTreemapValue = 184},
                new BasicTreemapchart { BasicTreemapData = "Ahmedabad", BasicTreemapValue = 55},
                new BasicTreemapchart { BasicTreemapData = "Bangaluru", BasicTreemapValue = 84},
                new BasicTreemapchart { BasicTreemapData = "Pune",      BasicTreemapValue = 31},
                new BasicTreemapchart { BasicTreemapData = "Chennai",   BasicTreemapValue = 70},
                new BasicTreemapchart { BasicTreemapData = "Jaipur",    BasicTreemapValue = 30},
                new BasicTreemapchart { BasicTreemapData = "Surat",     BasicTreemapValue = 44},
                new BasicTreemapchart { BasicTreemapData = "Hyderabad", BasicTreemapValue = 68},
                new BasicTreemapchart { BasicTreemapData = "Lucknow",   BasicTreemapValue = 28},
                new BasicTreemapchart { BasicTreemapData = "Indore",    BasicTreemapValue = 19},
                new BasicTreemapchart { BasicTreemapData = "Kanpur",    BasicTreemapValue = 29},
            };
        }
        public static List<MultiTreemapchart> MultiTreemapchart()
        {
            return new List<MultiTreemapchart>
            {
                new MultiTreemapchart { MultiTreemapData = "ABC", MultiTreemapValue = 10},
                new MultiTreemapchart { MultiTreemapData = "DEF", MultiTreemapValue = 60},
                new MultiTreemapchart { MultiTreemapData = "XYZ", MultiTreemapValue = 41},
                new MultiTreemapchart { MultiTreemapData = "ABCD", MultiTreemapValue2 = 10},
                new MultiTreemapchart { MultiTreemapData = "DEFG", MultiTreemapValue2 = 20},
                new MultiTreemapchart { MultiTreemapData = "WXYZ", MultiTreemapValue2 = 51},
                new MultiTreemapchart { MultiTreemapData = "PQR", MultiTreemapValue2 = 30},
                new MultiTreemapchart { MultiTreemapData = "MNO", MultiTreemapValue2 = 20},
                new MultiTreemapchart { MultiTreemapData = "CDE", MultiTreemapValue2 = 30},
            };
        }
        public static List<DistributedTreemapchart> DistributedTreemapchart()
        {
            return new List<DistributedTreemapchart>
            {
                new DistributedTreemapchart { DistributedTreemapData = "New Delhi", DistributedTreemapValue = 218},
                new DistributedTreemapchart { DistributedTreemapData = "Kolkata", DistributedTreemapValue = 149},
                new DistributedTreemapchart { DistributedTreemapData = "Mumbai", DistributedTreemapValue = 184},
                new DistributedTreemapchart { DistributedTreemapData = "Ahmedabad", DistributedTreemapValue = 55},
                new DistributedTreemapchart { DistributedTreemapData = "Bangaluru", DistributedTreemapValue = 84},
                new DistributedTreemapchart { DistributedTreemapData = "Pune", DistributedTreemapValue = 31},
                new DistributedTreemapchart { DistributedTreemapData = "Chennai", DistributedTreemapValue = 70},
                new DistributedTreemapchart { DistributedTreemapData = "Jaipur", DistributedTreemapValue = 30},
                new DistributedTreemapchart { DistributedTreemapData = "Surat", DistributedTreemapValue = 44},
                new DistributedTreemapchart { DistributedTreemapData = "Hyderabad", DistributedTreemapValue = 68},
                new DistributedTreemapchart { DistributedTreemapData = "Lucknow", DistributedTreemapValue = 28},
                new DistributedTreemapchart { DistributedTreemapData = "Indore", DistributedTreemapValue = 19},
                new DistributedTreemapchart { DistributedTreemapData = "Kanpur", DistributedTreemapValue = 29},
            };
        }
        public static List<ColorRangesTreemapchart> ColorRangesTreemapchart()
        {
            return new List<ColorRangesTreemapchart>
            {
                new ColorRangesTreemapchart { ColorRangesTreemapData = "INTC", ColorRangesTreemapValue = 1.2M},
                new ColorRangesTreemapchart { ColorRangesTreemapData = "GS", ColorRangesTreemapValue = 0.4M},
                new ColorRangesTreemapchart { ColorRangesTreemapData = "CVX", ColorRangesTreemapValue = -1.4M},
                new ColorRangesTreemapchart { ColorRangesTreemapData = "GE", ColorRangesTreemapValue = 2.7M},
                new ColorRangesTreemapchart { ColorRangesTreemapData = "CAT", ColorRangesTreemapValue = -0.3M},
                new ColorRangesTreemapchart { ColorRangesTreemapData = "RTX", ColorRangesTreemapValue = 5.1M},
                new ColorRangesTreemapchart { ColorRangesTreemapData = "CSCO", ColorRangesTreemapValue = -2.3M},
                new ColorRangesTreemapchart { ColorRangesTreemapData = "JNJ", ColorRangesTreemapValue = 2.1M},
                new ColorRangesTreemapchart { ColorRangesTreemapData = "PG", ColorRangesTreemapValue = 0.3M},
                new ColorRangesTreemapchart { ColorRangesTreemapData = "TRV", ColorRangesTreemapValue = 0.12M},
                new ColorRangesTreemapchart { ColorRangesTreemapData = "MMM", ColorRangesTreemapValue = -2.31M},
                new ColorRangesTreemapchart { ColorRangesTreemapData = "NKE", ColorRangesTreemapValue = 3.98M},
                new ColorRangesTreemapchart { ColorRangesTreemapData = "IYT", ColorRangesTreemapValue = 1.67M},
            };
        }
    }
}