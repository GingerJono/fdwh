
namespace LineData
{
    public class Linebasicchart {
        public string? Month { get; set; }
        public decimal GrossValue { get; set; }
    } ;
    public class LinebasicDatalabelchart {
        public string? Month { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        
    } ;
    public class TimeSeries
    {
        public long DateMilliseconds => Date.ToUnixTimeMilliseconds();
        public DateTimeOffset Date { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }
    };
    public class Annotationschart {
        public string? AnnotationsDates { get; set; }
        public decimal AnnotationsPrices { get; set; }
    } ;   
    public class StepLinechart {
        public decimal StepLineSeries { get; set; }
        public decimal StepLineValue { get; set; }
    } ;
    public class GradientLinechart {
        public string? GradientLineDate { get; set; }
        public decimal GradientLineValue { get; set; }
        
    } ;
    public class NullLinechart {
        public decimal NullLineSeries { get; set; }
        public decimal? NullLineValue { get; set; }
        public decimal? NullLineValue2 { get; set; }
        public decimal? NullLineValue3 { get; set; }
    } ;
    public class DashedLinechart {
        public string? DashedLineSeries { get; set; }
        public decimal DashedLineValue { get; set; }
        public decimal DashedLineValue1 { get; set; }
        public decimal DashedLineValue2 { get; set; }
    } ;
    public class LineService {
        public static List<Linebasicchart> GetLinebasiccharts()
        {
           var Linebasiccharts = new List<Linebasicchart>();
               Linebasiccharts.Add( new Linebasicchart { Month = "Jan", GrossValue = 10});
               Linebasiccharts.Add( new Linebasicchart { Month = "Feb", GrossValue = 41});
               Linebasiccharts.Add( new Linebasicchart { Month = "Mar", GrossValue = 35});
               Linebasiccharts.Add( new Linebasicchart { Month = "Apr", GrossValue = 51});
               Linebasiccharts.Add( new Linebasicchart { Month = "May", GrossValue = 49});
               Linebasiccharts.Add( new Linebasicchart { Month = "Jun", GrossValue = 62});
               Linebasiccharts.Add( new Linebasicchart { Month = "Jul", GrossValue = 69});
               Linebasiccharts.Add( new Linebasicchart { Month = "Aug", GrossValue = 91});
               Linebasiccharts.Add( new Linebasicchart { Month = "Sep", GrossValue = 148});
            return Linebasiccharts;
        }
        public static List<LinebasicDatalabelchart> GetLinebasicDatalabelcharts()
        {
            var LinebasicDatalabelcharts = new List<LinebasicDatalabelchart> ();
            LinebasicDatalabelcharts.Add(new LinebasicDatalabelchart { Month = "Jan", High = 28 , Low=12});
            LinebasicDatalabelcharts.Add(new LinebasicDatalabelchart { Month = "Feb", High = 29 , Low=11});
            LinebasicDatalabelcharts.Add(new LinebasicDatalabelchart { Month = "Mar", High = 33 , Low=14});
            LinebasicDatalabelcharts.Add(new LinebasicDatalabelchart { Month = "Apr", High = 36 , Low=18});
            LinebasicDatalabelcharts.Add(new LinebasicDatalabelchart { Month = "May", High = 32 , Low=17});
            LinebasicDatalabelcharts.Add(new LinebasicDatalabelchart { Month = "Jun", High = 32 , Low=13});
            LinebasicDatalabelcharts.Add(new LinebasicDatalabelchart { Month = "Jul", High = 33 , Low=13});
            return LinebasicDatalabelcharts;
        }
        public static List<Annotationschart> GetAnnotationscharts() {
            var Annotationscharts = new List<Annotationschart> ();
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "13 Nov 2017", AnnotationsPrices = 8423.7M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "14 Nov 2017", AnnotationsPrices = 8423.5M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "15 Nov 2017", AnnotationsPrices = 8514.3M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "16 Nov 2017", AnnotationsPrices = 8481.85M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "17 Nov 2017", AnnotationsPrices = 8487.7M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "20 Nov 2017", AnnotationsPrices = 8506.9M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "21 Nov 2017", AnnotationsPrices = 8626.2M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "22 Nov 2017", AnnotationsPrices = 8668.95M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "23 Nov 2017", AnnotationsPrices = 8602.3M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "24 Nov 2017", AnnotationsPrices = 8607.55M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "27 Nov 2017", AnnotationsPrices = 8512.9M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "28 Nov 2017", AnnotationsPrices = 8496.25M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "29 Nov 2017", AnnotationsPrices = 8600.65M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "30 Nov 2017", AnnotationsPrices = 8881.1M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "01 Dec 2017", AnnotationsPrices = 9040.85M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "04 Dec 2017", AnnotationsPrices = 8340.7M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "05 Dec 2017", AnnotationsPrices = 8165.5M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "06 Dec 2017", AnnotationsPrices = 8122.9M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "07 Dec 2017", AnnotationsPrices = 8107.85M});
            Annotationscharts.Add(new Annotationschart { AnnotationsDates = "08 Dec 2017", AnnotationsPrices = 8128.0M});
            return Annotationscharts;
        }
        public static List<StepLinechart> GetStepLinecharts()
        {
            var StepLinecharts = new List<StepLinechart> ();
            StepLinecharts.Add( new StepLinechart {StepLineSeries = 1, StepLineValue = 34});
            StepLinecharts.Add( new StepLinechart {StepLineSeries = 2, StepLineValue = 44});
            StepLinecharts.Add( new StepLinechart {StepLineSeries = 3, StepLineValue = 54});
            StepLinecharts.Add( new StepLinechart {StepLineSeries = 4, StepLineValue = 21});
            StepLinecharts.Add( new StepLinechart {StepLineSeries = 5, StepLineValue = 12});
            StepLinecharts.Add( new StepLinechart {StepLineSeries = 6, StepLineValue = 43});
            StepLinecharts.Add( new StepLinechart {StepLineSeries = 7, StepLineValue = 33});
            StepLinecharts.Add( new StepLinechart {StepLineSeries = 8, StepLineValue = 23});
            StepLinecharts.Add( new StepLinechart {StepLineSeries = 9, StepLineValue = 66});
            StepLinecharts.Add( new StepLinechart {StepLineSeries = 10, StepLineValue = 66});
            StepLinecharts.Add( new StepLinechart {StepLineSeries = 11, StepLineValue = 58});
            return StepLinecharts;
        }
        public static List<GradientLinechart> GetGradientLinecharts() {
            var GradientLinecharts = new List<GradientLinechart>();
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "1/11/2000", GradientLineValue = 4});
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "2/11/2000", GradientLineValue = 3});
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "3/11/2000", GradientLineValue = 10});
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "4/11/2000", GradientLineValue = 9});
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "5/11/2000", GradientLineValue = 29});
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "6/11/2000", GradientLineValue = 19});
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "7/11/2000", GradientLineValue = 22});
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "8/11/2000", GradientLineValue = 9});
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "9/11/2000", GradientLineValue = 12});
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "10/11/2000", GradientLineValue = 7});
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "11/11/2000", GradientLineValue = 19});
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "12/11/2000", GradientLineValue = 5});
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "1/11/2001", GradientLineValue = 13});
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "2/11/2001", GradientLineValue = 9});
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "3/11/2001", GradientLineValue = 17});
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "4/11/2001", GradientLineValue = 2});
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "5/11/2001", GradientLineValue = 7});
            GradientLinecharts.Add(new GradientLinechart {GradientLineDate = "6/11/2001", GradientLineValue = 5});
            return GradientLinecharts;
        }
        public static List<NullLinechart> GetNullLinecharts() {
            var NullLinecharts = new List<NullLinechart>();
            NullLinecharts.Add(new NullLinechart {NullLineSeries = 1,  NullLineValue = 5 ,    NullLineValue2 = 10,   NullLineValue3 = null });
            NullLinecharts.Add(new NullLinechart {NullLineSeries = 2,  NullLineValue = 5 ,    NullLineValue2 = 15,   NullLineValue3 = null });
            NullLinecharts.Add(new NullLinechart {NullLineSeries = 3,  NullLineValue = 10,    NullLineValue2 = null, NullLineValue3 = null });
            NullLinecharts.Add(new NullLinechart {NullLineSeries = 4,  NullLineValue = 8 ,    NullLineValue2 = 12,   NullLineValue3 = null });
            NullLinecharts.Add(new NullLinechart {NullLineSeries = 5,  NullLineValue = 7 ,    NullLineValue2 = null, NullLineValue3 = 3    });
            NullLinecharts.Add(new NullLinechart {NullLineSeries = 6,  NullLineValue = 5 ,    NullLineValue2 = 10,   NullLineValue3 = 4    });
            NullLinecharts.Add(new NullLinechart {NullLineSeries = 7,  NullLineValue = 4 ,    NullLineValue2 = 12,   NullLineValue3 = 1    });
            NullLinecharts.Add(new NullLinechart {NullLineSeries = 8,  NullLineValue = null , NullLineValue2 = 15,   NullLineValue3 = 3    });
            NullLinecharts.Add(new NullLinechart {NullLineSeries = 9,  NullLineValue = null , NullLineValue2 = null, NullLineValue3 = 4    });
            NullLinecharts.Add(new NullLinechart {NullLineSeries = 10, NullLineValue = null , NullLineValue2 = null, NullLineValue3 = 6    });
            NullLinecharts.Add(new NullLinechart {NullLineSeries = 11, NullLineValue = 10 ,   NullLineValue2 = 12,   NullLineValue3 = 7    });
            NullLinecharts.Add(new NullLinechart {NullLineSeries = 12, NullLineValue = 10 ,   NullLineValue2 = null, NullLineValue3 = 9    });
            NullLinecharts.Add(new NullLinechart {NullLineSeries = 13, NullLineValue = 7 ,    NullLineValue2 = 14,   NullLineValue3 = 5    });
            NullLinecharts.Add(new NullLinechart {NullLineSeries = 14, NullLineValue = 8 ,    NullLineValue2 = null, NullLineValue3 = null });
            NullLinecharts.Add(new NullLinechart {NullLineSeries = 15, NullLineValue = 6 ,    NullLineValue2 = null, NullLineValue3 = null });
            NullLinecharts.Add(new NullLinechart {NullLineSeries = 16, NullLineValue = 9 ,    NullLineValue2 = null, NullLineValue3 = null });
            return NullLinecharts;
        }
        public static List<DashedLinechart> GetDashedLinecharts(){
            var DashedLinecharts = new List<DashedLinechart> ();
            DashedLinecharts.Add(new DashedLinechart { DashedLineSeries = "01 Jan", DashedLineValue = 45, DashedLineValue1=35 ,DashedLineValue2=87});
            DashedLinecharts.Add(new DashedLinechart { DashedLineSeries = "02 Jan", DashedLineValue = 52, DashedLineValue1=41 ,DashedLineValue2=57});
            DashedLinecharts.Add(new DashedLinechart { DashedLineSeries = "03 Jan", DashedLineValue = 38, DashedLineValue1=62 ,DashedLineValue2=74});
            DashedLinecharts.Add(new DashedLinechart { DashedLineSeries = "04 Jan", DashedLineValue = 24, DashedLineValue1=42 ,DashedLineValue2=99});
            DashedLinecharts.Add(new DashedLinechart { DashedLineSeries = "05 Jan", DashedLineValue = 33, DashedLineValue1=13 ,DashedLineValue2=75});
            DashedLinecharts.Add(new DashedLinechart { DashedLineSeries = "06 Jan", DashedLineValue = 26, DashedLineValue1=18 ,DashedLineValue2=38});
            DashedLinecharts.Add(new DashedLinechart { DashedLineSeries = "07 Jan", DashedLineValue = 21, DashedLineValue1=29 ,DashedLineValue2=62});
            DashedLinecharts.Add(new DashedLinechart { DashedLineSeries = "08 Jan", DashedLineValue = 20, DashedLineValue1=37 ,DashedLineValue2=47});
            DashedLinecharts.Add(new DashedLinechart { DashedLineSeries = "09 Jan", DashedLineValue = 06, DashedLineValue1=36 ,DashedLineValue2=82});
            DashedLinecharts.Add(new DashedLinechart { DashedLineSeries = "10 Jan", DashedLineValue = 08, DashedLineValue1=51 ,DashedLineValue2=56});
            DashedLinecharts.Add(new DashedLinechart { DashedLineSeries = "11 Jan", DashedLineValue = 15, DashedLineValue1=32 ,DashedLineValue2=45});
            DashedLinecharts.Add(new DashedLinechart { DashedLineSeries = "12 Jan", DashedLineValue = 10, DashedLineValue1=35 ,DashedLineValue2=47});
            return DashedLinecharts;
        }
    }
}