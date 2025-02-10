
namespace PieChartData
{
    public class Piebasicchart
    {
        public string? TeamSeries { get; set; }
        public decimal Value { get; set; }
    }
    public class PieSimplechart
    {
        public string? PieSimpleData { get; set; }
        public decimal SimpleValue { get; set; }
    }
    public class PieMonochromechart
    {
        public string? Week { get; set; }
        public decimal MonochromeValue { get; set; }
    }
    public class PieGradientchart
    {
        public string? PieGradientData { get; set; }
        public decimal GradientValue { get; set; }
    }
    public class PiePatternchart
    {
        public string? PiePatternData { get; set; }
        public decimal PatternValue { get; set; }
    }
    public class PieImagechart
    {
        public string? PieImageData { get; set; }
        public decimal ImageValue { get; set; }
    }
    public class PieChartService {
        public static List<Piebasicchart> Piebasicchart()
        {
            return new List<Piebasicchart>
            {
                new Piebasicchart { TeamSeries = "Team A", Value = 44},
                new Piebasicchart { TeamSeries = "Team B", Value = 55},
                new Piebasicchart { TeamSeries = "Team C", Value = 13},
                new Piebasicchart { TeamSeries = "Team D", Value = 43},
                new Piebasicchart { TeamSeries = "Team E", Value = 22},
            };
        }
        public static List<PieSimplechart> PieSimplechart()
        {
            return new List<PieSimplechart>
            {
                new PieSimplechart { PieSimpleData = "Series-1", SimpleValue = 44},
                new PieSimplechart { PieSimpleData = "Series-2", SimpleValue = 55},
                new PieSimplechart { PieSimpleData = "Series-3", SimpleValue = 41},
                new PieSimplechart { PieSimpleData = "Series-4", SimpleValue = 17},
                new PieSimplechart { PieSimpleData = "Series-5", SimpleValue = 15},
            };
        }
        public static List<PieMonochromechart> PieMonochromechart()
        {
            return new List<PieMonochromechart>
            {
                new PieMonochromechart { Week = "Monday", MonochromeValue = 25},
                new PieMonochromechart { Week = "Tuesday", MonochromeValue = 15},
                new PieMonochromechart { Week = "Wednesday", MonochromeValue = 44},
                new PieMonochromechart { Week = "Thursday", MonochromeValue = 55},
                new PieMonochromechart { Week = "Friday", MonochromeValue = 41},
                new PieMonochromechart { Week = "Saturday", MonochromeValue = 17},
            };
        }
        public static List<PieGradientchart> PieGradientchart()
        {
            return new List<PieGradientchart>
            {
                new PieGradientchart { PieGradientData = "Series-1", GradientValue = 44},
                new PieGradientchart { PieGradientData = "Series-2", GradientValue = 55},
                new PieGradientchart { PieGradientData = "Series-3", GradientValue = 41},
                new PieGradientchart { PieGradientData = "Series-4", GradientValue = 17},
                new PieGradientchart { PieGradientData = "Series-5", GradientValue = 15},

            };
        }
        public static List<PiePatternchart> PiePatternchart()
        {
            return new List<PiePatternchart>
            {
                new PiePatternchart { PiePatternData = "Comedy", PatternValue = 44},
                new PiePatternchart { PiePatternData = "Action", PatternValue = 55},
                new PiePatternchart { PiePatternData = "SciFi", PatternValue = 41},
                new PiePatternchart { PiePatternData = "Drama", PatternValue = 17},
                new PiePatternchart { PiePatternData = "Horror", PatternValue = 15},
            };
        }
        public static List<PieImagechart> PieImagechart()
        {
            return new List<PieImagechart>
            {
                new PieImagechart { PieImageData = "series-1", ImageValue = 44},
                new PieImagechart { PieImageData = "series-2", ImageValue = 33},
                new PieImagechart { PieImageData = "series-3", ImageValue = 54},
                new PieImagechart { PieImageData = "series-4", ImageValue = 45},
            };
        }
    }
}