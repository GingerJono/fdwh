
namespace SlopeChartData
{
    public class Slopebasicchart
    {
        public string? XDATA { get; set; }
        public decimal YData { get; set; }
        public decimal YData1 { get; set; }
        public decimal YData2 { get; set; }
        public decimal YData3 { get; set; }
    }
    public class SlopeChartService {
         public static List<Slopebasicchart> GetSlopebasicchart()
        {
            return new List<Slopebasicchart>
            {
                new Slopebasicchart {XDATA =  "Jan", YData=33, YData1=43,YData2=55},
                new Slopebasicchart {XDATA =  "Feb", YData=38,YData1=58,YData2=21},
            };
        }
         public static List<Slopebasicchart> GetMultiSlopebasicchart()
        {
            return new List<Slopebasicchart>
            {
                new Slopebasicchart {XDATA =  "Category 1", YData=503, YData1=733,YData2=255,YData3=428},
                new Slopebasicchart {XDATA =  "Category 2", YData=580,YData1=385,YData2=211,YData3=749},
                new Slopebasicchart {XDATA =  "Category 3", YData=135,YData1=715,YData2=441,YData3=559},
            };
        }

    }
}