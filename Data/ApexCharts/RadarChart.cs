
namespace RadarChartData
{
    public class Radarbasic
    {
        public string? Month { get; set; }
        public int Value { get; set; }
    }    
    public class RadarMulti
    {
        public string? Year { get; set; }
        public int Value { get; set; }
        public int Value1 { get; set; }
        public int Value2 { get; set; }
    }    
    public class RadarPoygon
    {
        public string? Week { get; set; }
        public int PoygonValue { get; set; }
    }
    public class RadarChartService {
        public static List<Radarbasic> Radarbasic()
        {
            return new List<Radarbasic>
            {
                new Radarbasic { Month = "January", Value = 80},
                new Radarbasic { Month = "February", Value = 50},
                new Radarbasic { Month = "March", Value = 30},
                new Radarbasic { Month = "April", Value = 40},
                new Radarbasic { Month = "May", Value = 100},
                new Radarbasic { Month = "June", Value = 20},
            };
        }
        public static List<RadarMulti> RadarMulti()
        {
            return new List<RadarMulti>
            {
                new RadarMulti { Year = "2011", Value = 80, Value1=20, Value2=44},
                new RadarMulti { Year = "2012", Value = 50, Value1=30, Value2=76},
                new RadarMulti { Year = "2013", Value = 30, Value1=40, Value2=78},
                new RadarMulti { Year = "2014", Value = 40, Value1=80, Value2=13},
                new RadarMulti { Year = "2015", Value = 100, Value1=20, Value2=43},
                new RadarMulti { Year = "2016", Value = 20, Value1=80, Value2=10},
            };
        }
        public static List<RadarPoygon> RadarPoygon()
        {
            return new List<RadarPoygon>
            {
                new RadarPoygon { Week = "Sunday", PoygonValue = 20},
                new RadarPoygon { Week = "Monday", PoygonValue = 100},
                new RadarPoygon { Week = "Tuesday", PoygonValue = 40},
                new RadarPoygon { Week = "Wednesday", PoygonValue = 30},
                new RadarPoygon { Week = "Thursday", PoygonValue = 50},
                new RadarPoygon { Week = "Friday", PoygonValue = 80},
                new RadarPoygon { Week = "Saturday", PoygonValue = 33},
            };
        }
    }
}