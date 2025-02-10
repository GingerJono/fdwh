
namespace BoxplotData
{
    public class Boxplotbasicchart
    {
        public string? Name { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
        public decimal Q1 { get; set; }
        public decimal Q3 { get; set; }
        public decimal Median { get; set; }
    }
    public class BoxplotTimechart
    {
        public DateTime Date { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
        public decimal Q1 { get; set; }
        public decimal Q3 { get; set; }
        public decimal Median { get; set; }
        public decimal YSeries { get; set; }
    }
    public class Boxplotcolorschart
    {
        public string? Name { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
        public decimal Q1 { get; set; }
        public decimal Q3 { get; set; }
        public decimal Median { get; set; }
    }
    public class Boxplothorizontalchart
    {
        public string? Name { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
        public decimal Q1 { get; set; }
        public decimal Q3 { get; set; }
        public decimal Median { get; set; }
    }
    public class BoxplotService {
        public static List<Boxplotbasicchart> GetBoxplotbasiccharts()
        {
            var boxPlotData = new List<Boxplotbasicchart>();
            boxPlotData.Add(new Boxplotbasicchart { Name = "Jan 2015", Min = 54, Max = 88, Q1 = 66, Q3 = 75, Median = 69 });
            boxPlotData.Add(new Boxplotbasicchart { Name = "Jan 2016", Min = 43, Max = 81, Q1 = 65, Q3 = 76, Median = 69 });
            boxPlotData.Add(new Boxplotbasicchart { Name = "Jan 2017", Min = 31, Max = 59, Q1 = 39, Q3 = 51, Median = 45 });
            boxPlotData.Add(new Boxplotbasicchart { Name = "Jan 2018", Min = 39, Max = 71, Q1 = 46, Q3 = 65, Median = 55 });
            boxPlotData.Add(new Boxplotbasicchart { Name = "Jan 2019", Min = 29, Max = 44, Q1 = 31, Q3 = 39, Median = 35 });
            boxPlotData.Add(new Boxplotbasicchart { Name = "Jan 2020", Min = 41, Max = 67, Q1 = 49, Q3 = 61, Median = 58 });
            boxPlotData.Add(new Boxplotbasicchart { Name = "Jan 2021", Min = 54, Max = 88, Q1 = 59, Q3 = 71, Median = 66 });
            return boxPlotData;
        }
        public static List<BoxplotTimechart> GetBoxplotTimecharts()
        {
            var boxPlotData = new List<BoxplotTimechart>();
            boxPlotData.Add(new BoxplotTimechart { Date = new DateTime(1483228800000), Min = 54, Max = 88, Q1 = 66, Q3 = 75, Median = 69, YSeries = 32 });
            boxPlotData.Add(new BoxplotTimechart { Date = new DateTime(1514764800000), Min = 43, Max = 81, Q1 = 65, Q3 = 76, Median = 69, YSeries = 25 });
            boxPlotData.Add(new BoxplotTimechart { Date = new DateTime(1546300800000), Min = 31, Max = 59, Q1 = 39, Q3 = 51, Median = 45, YSeries = 64 });
            boxPlotData.Add(new BoxplotTimechart { Date = new DateTime(1577836800000), Min = 39, Max = 71, Q1 = 46, Q3 = 65, Median = 55, YSeries = 27 });
            boxPlotData.Add(new BoxplotTimechart { Date = new DateTime(1609459200000), Min = 29, Max = 44, Q1 = 31, Q3 = 39, Median = 35, YSeries = 78 });
            return boxPlotData;
        }
        public static List<Boxplotcolorschart> GetBoxplotcolorscharts()
        {
            var boxPlotData = new List<Boxplotcolorschart>();
            boxPlotData.Add(new Boxplotcolorschart { Name = "Category A", Min = 54, Max = 88, Q1 = 66, Q3 = 75, Median = 69 });
            boxPlotData.Add(new Boxplotcolorschart { Name = "Category B", Min = 43, Max = 81, Q1 = 65, Q3 = 76, Median = 69 });
            boxPlotData.Add(new Boxplotcolorschart { Name = "Category C", Min = 31, Max = 59, Q1 = 39, Q3 = 51, Median = 45 });
            boxPlotData.Add(new Boxplotcolorschart { Name = "Category D", Min = 39, Max = 71, Q1 = 46, Q3 = 65, Median = 55 });
            boxPlotData.Add(new Boxplotcolorschart { Name = "Category E", Min = 29, Max = 44, Q1 = 31, Q3 = 39, Median = 35 });
            boxPlotData.Add(new Boxplotcolorschart { Name = "Category F", Min = 41, Max = 67, Q1 = 49, Q3 = 61, Median = 58 });
            boxPlotData.Add(new Boxplotcolorschart { Name = "Category G", Min = 54, Max = 88, Q1 = 59, Q3 = 71, Median = 66 });
            return boxPlotData;
        }
        public static List<Boxplothorizontalchart> GetBoxplothorizontalcharts()
        {
            var boxPlotData = new List<Boxplothorizontalchart>();
            boxPlotData.Add(new Boxplothorizontalchart { Name = "Category A", Min = 54, Max = 88, Q1 = 66, Q3 = 75, Median = 69 });
            boxPlotData.Add(new Boxplothorizontalchart { Name = "Category B", Min = 43, Max = 81, Q1 = 65, Q3 = 76, Median = 69 });
            boxPlotData.Add(new Boxplothorizontalchart { Name = "Category C", Min = 31, Max = 59, Q1 = 39, Q3 = 51, Median = 45 });
            boxPlotData.Add(new Boxplothorizontalchart { Name = "Category D", Min = 39, Max = 71, Q1 = 46, Q3 = 65, Median = 55 });
            boxPlotData.Add(new Boxplothorizontalchart { Name = "Category E", Min = 29, Max = 44, Q1 = 31, Q3 = 39, Median = 35 });
            boxPlotData.Add(new Boxplothorizontalchart { Name = "Category F", Min = 41, Max = 67, Q1 = 49, Q3 = 61, Median = 58 });
            boxPlotData.Add(new Boxplothorizontalchart { Name = "Category G", Min = 54, Max = 88, Q1 = 59, Q3 = 71, Median = 66 });
            return boxPlotData;
        }
    }
}