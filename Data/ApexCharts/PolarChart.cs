
namespace PolarChartData
{
    public class PolarAreachart
    {
        public string? Source { get; set; }
        public int SeriesValue { get; set; }
    }
    public class MonochromePolarAreachart
    {
        public string? MonochromeSeriesData { get; set; }
        public int MonochromeSeriesValue { get; set; }
    }
    public class PolarChartService {
        public static List<PolarAreachart> PolarAreaItems()
        {
            var PolarAreaItems = new List<PolarAreachart>();
            PolarAreaItems.Add(new PolarAreachart { SeriesValue = 14, Source = "Series1" });
            PolarAreaItems.Add(new PolarAreachart { SeriesValue = 23, Source = "Series2" });
            PolarAreaItems.Add(new PolarAreachart { SeriesValue = 21, Source = "Series3" });
            PolarAreaItems.Add(new PolarAreachart { SeriesValue = 17, Source = "Series4" });
            PolarAreaItems.Add(new PolarAreachart { SeriesValue = 15, Source = "Series5" });
            PolarAreaItems.Add(new PolarAreachart { SeriesValue = 10, Source = "Series6" });
            PolarAreaItems.Add(new PolarAreachart { SeriesValue = 12, Source = "Series7" });
            PolarAreaItems.Add(new PolarAreachart { SeriesValue = 17, Source = "Series8" });
            PolarAreaItems.Add(new PolarAreachart { SeriesValue = 21, Source = "Series9" });
            return PolarAreaItems;
        }
        public static List<MonochromePolarAreachart> MonochromePolarAreaItems()
        {
            var MonochromePolarAreaItems = new List<MonochromePolarAreachart>();
            MonochromePolarAreaItems.Add(new MonochromePolarAreachart { MonochromeSeriesValue = 42, MonochromeSeriesData = "Rose A" });
            MonochromePolarAreaItems.Add(new MonochromePolarAreachart { MonochromeSeriesValue = 47, MonochromeSeriesData = "Rose B" });
            MonochromePolarAreaItems.Add(new MonochromePolarAreachart { MonochromeSeriesValue = 52, MonochromeSeriesData = "Rose C" });
            MonochromePolarAreaItems.Add(new MonochromePolarAreachart { MonochromeSeriesValue = 58, MonochromeSeriesData = "Rose D" });
            MonochromePolarAreaItems.Add(new MonochromePolarAreachart { MonochromeSeriesValue = 65, MonochromeSeriesData = "Rose E" });
            return MonochromePolarAreaItems;
        }
    }
}