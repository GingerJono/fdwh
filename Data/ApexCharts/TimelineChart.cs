
namespace TimelineChartData
{
    public class BasicTImeline {
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
    } ;
    public class MultiColoredTImeline {
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? PointColor { get; set; }
        
    } ;
    public class Activity
    {
        public string? Person { get; set; }
        public string? Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
    public class Activity2
    {
        public string? Person2 { get; set; }
        public string? Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
    public class Activity3
    {
        public string? Person3 { get; set; }
        public string? Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
    public class DumbbellChart {
        public string? Name { get; set; }
        public decimal StartDate { get; set; }
        public decimal EndDate { get; set; }
        
    } ;
    public class TimelineChartService {
        public static List<BasicTImeline> GetBasicTImelines() {
           var BasicTImelineChart = new List<BasicTImeline> ();
            BasicTImelineChart.Add(new BasicTImeline { Name = "Code", StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(0)});
            BasicTImelineChart.Add(new BasicTImeline { Name = "Test", StartDate = DateTime.Now.AddDays(0), EndDate = DateTime.Now.AddDays(20)});
            BasicTImelineChart.Add(new BasicTImeline { Name = "Validation", StartDate = DateTime.Now.AddDays(20), EndDate = DateTime.Now.AddDays(40)});
            BasicTImelineChart.Add(new BasicTImeline { Name = "Deployment", StartDate = DateTime.Now.AddDays(40), EndDate = DateTime.Now.AddDays(70)});
            return BasicTImelineChart;
        }
        public static List<MultiColoredTImeline> GetMultiColoredTImelines() {
            var MultiColoredTImelineChart = new List<MultiColoredTImeline>();
            MultiColoredTImelineChart.Add(new MultiColoredTImeline { Name = "Analysis", StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(0), PointColor="#5c67f7"});
            MultiColoredTImelineChart.Add(new MultiColoredTImeline { Name = "Design", StartDate = DateTime.Now.AddDays(0), EndDate = DateTime.Now.AddDays(20), PointColor="#e354d4"});
            MultiColoredTImelineChart.Add(new MultiColoredTImeline { Name = "Coding", StartDate = DateTime.Now.AddDays(20), EndDate = DateTime.Now.AddDays(40), PointColor="#ff8e6f"});
            MultiColoredTImelineChart.Add(new MultiColoredTImeline { Name = "Testing", StartDate = DateTime.Now.AddDays(40), EndDate = DateTime.Now.AddDays(70), PointColor="#0ca3e7"});
            MultiColoredTImelineChart.Add(new MultiColoredTImeline { Name = "Deployment", StartDate = DateTime.Now.AddDays(70), EndDate = DateTime.Now.AddDays(90), PointColor="#fe5454"});
            return MultiColoredTImelineChart;
        }
        public static List<DumbbellChart> GetDumbbellChart() {
            var DumbbellCharts = new List<DumbbellChart>();
            DumbbellCharts.Add(new DumbbellChart { Name = "Operations", StartDate = 2800, EndDate = 4500});
            DumbbellCharts.Add(new DumbbellChart { Name = "Customer Success", StartDate = 3200, EndDate = 4100});
            DumbbellCharts.Add(new DumbbellChart { Name = "Engineering", StartDate = 2950, EndDate = 7800});
            DumbbellCharts.Add(new DumbbellChart { Name = "Marketing", StartDate = 3000, EndDate = 4600});
            DumbbellCharts.Add(new DumbbellChart { Name = "Product", StartDate = 3500, EndDate = 4100});
            DumbbellCharts.Add(new DumbbellChart { Name = "Data Science", StartDate = 4500, EndDate = 6500});
            DumbbellCharts.Add(new DumbbellChart { Name = "Sales", StartDate = 4100, EndDate = 5600});
            return DumbbellCharts;
        }
    }
}