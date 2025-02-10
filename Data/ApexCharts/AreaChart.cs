
namespace AreaData
{
    public class Areabasicchart {
        public string? StockValue { get; set; }
        public decimal prices { get; set; }
    } ;
    
    public class AreaSplinechart {
        public string? SeriesValue { get; set; }
        public decimal Series1Value { get; set; }
        public decimal Series2Value { get; set; }
    } ;
    public class AreaNegativechart {
        public string? Year { get; set; }
        public decimal North { get; set; }
        public decimal South { get; set; }
    } ;
    public class TimeSeries
    {
        public long DateMilliseconds => Date.ToUnixTimeMilliseconds();
        public DateTimeOffset Date { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }
    }
    public class AreaStackedchart {
        public string? StackedDate { get; set; }
        public decimal South { get; set; }
        public decimal North { get; set; }
        public decimal Central { get; set; }
        
    } ;
    public class AreaIrregularchart {
        public string? IrregularDate { get; set; }
        public decimal? ProductA { get; set; }
        public decimal? ProductB { get; set; }
        public decimal? ProductC { get; set; }
        
    } ;
    public class AreaNullValueschart {
        public string? NetworkDate { get; set; }
        public decimal? Network { get; set; }
        
    } ;
    public class AreaDatetimechart {
        public DateTime DatetimeSeries { get; set; }
        public decimal DatetimeValue { get; set; }
        
    } ;

    public class AreaService {
        public static List<Areabasicchart> GetAreabasiccharts() {
            var Areabasiccharts = new List<Areabasicchart>();
            Areabasiccharts.Add(new Areabasicchart { StockValue = "13 Nov 2017", prices = 8107.85M });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "14 Nov 2017", prices = 8128.0M  });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "15 Nov 2017", prices = 8122.9M  });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "16 Nov 2017", prices = 8165.5M  });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "17 Nov 2017", prices = 8340.7M  });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "20 Nov 2017", prices = 8423.7M  });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "21 Nov 2017", prices = 8423.5M  });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "22 Nov 2017", prices = 8514.3M  });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "23 Nov 2017", prices = 8481.85M });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "24 Nov 2017", prices = 8487.7M  });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "27 Nov 2017", prices = 8506.9M  });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "28 Nov 2017", prices = 8626.2M  });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "29 Nov 2017", prices = 8668.95M });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "30 Nov 2017", prices = 8602.3M  });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "01 Dec 2017", prices = 8607.55M });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "04 Dec 2017", prices = 8512.9M  });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "05 Dec 2017", prices = 8496.25M });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "06 Dec 2017", prices = 8600.65M });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "07 Dec 2017", prices = 8881.1M  });
            Areabasiccharts.Add(new Areabasicchart { StockValue = "08 Dec 2017", prices = 9340.85M });
            return Areabasiccharts;
        }
        public static List<AreaSplinechart> GetAreaSplinecharts()
        {
            var AreaSplinecharts = new List<AreaSplinechart>();
            AreaSplinecharts.Add(new AreaSplinechart { SeriesValue = "2018-09-19T00:00:00.000Z", Series1Value = 31  , Series2Value = 11 });
            AreaSplinecharts.Add(new AreaSplinechart { SeriesValue = "2018-09-19T01:30:00.000Z", Series1Value = 40  , Series2Value = 32 });
            AreaSplinecharts.Add(new AreaSplinechart { SeriesValue = "2018-09-19T02:30:00.000Z", Series1Value = 28  , Series2Value = 45 });
            AreaSplinecharts.Add(new AreaSplinechart { SeriesValue = "2018-09-19T03:30:00.000Z", Series1Value = 51  , Series2Value = 32 });
            AreaSplinecharts.Add(new AreaSplinechart { SeriesValue = "2018-09-19T04:30:00.000Z", Series1Value = 42  , Series2Value = 34 });
            AreaSplinecharts.Add(new AreaSplinechart { SeriesValue = "2018-09-19T05:30:00.000Z", Series1Value = 109 , Series2Value = 52 });
            AreaSplinecharts.Add(new AreaSplinechart { SeriesValue = "2018-09-19T06:30:00.000Z", Series1Value = 100 , Series2Value = 41 });
            return AreaSplinecharts;
        }
        public static List<AreaNegativechart> GetAreaNegativecharts()
        {
           var AreaNegativecharts = new List<AreaNegativechart>();
            AreaNegativecharts.Add(new AreaNegativechart { Year = "1996", North = 322, South = 162  });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "1997", North = 324, South = 90   });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "1998", North = 329, South = 50   });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "1999", North = 342, South = 77   });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "2000", North = 348, South = 35   });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "2001", North = 334, South = -45  });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "2002", North = 325, South = -88  });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "2003", North = 316, South = -120 });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "2004", North = 318, South = -156 });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "2005", North = 330, South = -123 });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "2006", North = 355, South = -88  });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "2007", North = 366, South = -66  });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "2008", North = 337, South = -45  });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "2009", North = 352, South = -29  });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "2010", North = 377, South = -45  });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "2011", North = 383, South = -88  });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "2012", North = 344, South = -132 });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "2013", North = 366, South = -146 });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "2014", North = 389, South = -169 });
            AreaNegativecharts.Add(new AreaNegativechart { Year = "2015", North = 334, South = -184 });
            return AreaNegativecharts;
        }
        public static List<AreaStackedchart> GetAreaStackedcharts()
        {
            var AreaStackedcharts = new List<AreaStackedchart>();
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "11 Feb 2017", South= 38, North = 19, Central = 11 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "12 Feb 2017", South= 33, North = 17, Central = 15 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "13 Feb 2017", South= 29, North = 15, Central = 13 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "14 Feb 2017", South= 60, North = 15, Central = 10 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "15 Feb 2017", South= 31, North = 20, Central = 15 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "16 Feb 2017", South= 30, North = 12, Central = 14 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "17 Feb 2017", South= 50, North = 19, Central = 11 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "18 Feb 2017", South= 58, North = 20, Central = 14 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "19 Feb 2017", South= 14, North = 20, Central = 11 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "20 Feb 2017", South= 20, North = 12, Central = 10 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "21 Feb 2017", South= 38, North = 11, Central = 15 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "22 Feb 2017", South= 21, North = 10, Central = 10 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "23 Feb 2017", South= 36, North = 10, Central = 11 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "24 Feb 2017", South= 12, North = 18, Central = 15 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "25 Feb 2017", South= 17, North = 15, Central = 15 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "26 Feb 2017", South= 11, North = 17, Central = 11 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "27 Feb 2017", South= 32, North = 18, Central = 10 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "28 Feb 2017", South= 31, North = 15, Central = 14 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "01 Mar 2017", South= 16, North = 12, Central = 10 });
            AreaStackedcharts.Add(new AreaStackedchart { StackedDate = "02 Mar 2017", South= 45, North = 16, Central = 11 });
            return AreaStackedcharts;
        }
        public static List<AreaIrregularchart> GetAreaIrregularcharts()
        {
            var AreaIrregularcharts = new List<AreaIrregularchart>();
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "01 Jan 2014", ProductA = null, ProductB = null, ProductC = null });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "02 Jan 2014", ProductA= 50.00M, ProductB = null, ProductC = null });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "03 Jan 2014", ProductA= 60.38M, ProductB = 150.00M, ProductC = null });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "04 Jan 2014", ProductA= 40.49M, ProductB = 160.38M, ProductC = null });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "05 Jan 2014", ProductA= 60.79M, ProductB = 170.49M, ProductC = null });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "06 Jan 2014", ProductA= 67.39M, ProductB = 160.79M, ProductC = null });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "07 Jan 2014", ProductA= 61.58M, ProductB = 167.39M, ProductC = null });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "08 Jan 2014", ProductA= 61.41M, ProductB = 161.58M, ProductC = 20.00M });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "09 Jan 2014", ProductA= 82.18M, ProductB = 161.41M, ProductC = 10.38M });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "10 Jan 2014", ProductA= 103.76M, ProductB = 152.18M, ProductC = 30.49M });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "11 Jan 2014", ProductA= 84.38M, ProductB = 140.76M, ProductC = 10.79M });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "12 Jan 2014", ProductA= 54.35M, ProductB = 144.38M, ProductC = 33.90M });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "13 Jan 2014", ProductA= 65.53M, ProductB = 154.35M, ProductC = 11.58M });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "14 Jan 2014", ProductA= null, ProductB = 165.53M, ProductC = 14.41M });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "15 Jan 2014", ProductA= null, ProductB = 175.75M, ProductC = 14.41M });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "16 Jan 2014", ProductA= null, ProductB = 187.06M, ProductC = 14.41M });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "17 Jan 2014", ProductA= null, ProductB = 197.52M, ProductC = 14.41M });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "18 Jan 2014", ProductA= null, ProductB = 210.18M, ProductC = 14.41M });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "19 Jan 2014", ProductA= null, ProductB = 196.12M, ProductC = 14.41M });
            AreaIrregularcharts.Add(new AreaIrregularchart { IrregularDate = "20 Jan 2014", ProductA= null, ProductB = 207.34M, ProductC = null });
            return AreaIrregularcharts;
        }
        public static List<AreaNullValueschart> GetAreaNullValuescharts()
        {
            var AreaNullValuescharts = new List<AreaNullValueschart>();
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Dec 23 2017", Network = null });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Dec 24 2017", Network = 44  });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Dec 25 2017", Network = 31  });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Dec 26 2017", Network = 38  });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Dec 27 2017", Network = null  });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Dec 28 2017", Network = 32  });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Dec 29 2017", Network = 55  });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Dec 30 2017", Network = 51  });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Dec 31 2017", Network = 67 });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Jan 01 2018", Network = 22  });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Jan 02 2018", Network = 34  });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Jan 03 2018", Network = null  });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Jan 04 2018", Network = null });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Jan 05 2018", Network = 11  });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Jan 06 2018", Network = 4 });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Jan 07 2018", Network = 15  });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Jan 08 2018", Network = null });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Jan 09 2018", Network = 9 });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Jan 10 2018", Network = 34  });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Jan 11 2018", Network = null });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Jan 12 2018", Network = null });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Jan 13 2018", Network = 13 });
            AreaNullValuescharts.Add(new AreaNullValueschart { NetworkDate = "Jan 14 2018", Network = null });
            return AreaNullValuescharts;
        }

        public static List<AreaDatetimechart> GetAreaDatetimecharts()
        {
            List<AreaDatetimechart> AreaDatetimecharts = new List<AreaDatetimechart>();
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1327359600000), DatetimeValue = 30.95M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1327446000000), DatetimeValue = 31.34M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1327532400000), DatetimeValue = 31.18M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1327618800000), DatetimeValue = 31.05M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1327878000000), DatetimeValue = 31.00M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1327964400000), DatetimeValue = 30.95M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1328050800000), DatetimeValue = 31.24M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1328137200000), DatetimeValue = 31.29M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1328223600000), DatetimeValue = 31.85M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1328482800000), DatetimeValue = 31.86M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1328569200000), DatetimeValue = 32.28M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1328655600000), DatetimeValue = 32.10M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1328742000000), DatetimeValue = 32.65M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1328828400000), DatetimeValue = 32.21M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1329087600000), DatetimeValue = 32.35M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1329174000000), DatetimeValue = 32.44M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1329260400000), DatetimeValue = 32.46M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1329346800000), DatetimeValue = 32.86M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1329433200000), DatetimeValue = 32.75M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1329778800000), DatetimeValue = 32.54M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1329865200000), DatetimeValue = 32.33M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1329951600000), DatetimeValue = 32.97M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1330038000000), DatetimeValue = 33.41M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1330297200000), DatetimeValue = 33.27M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1330383600000), DatetimeValue = 33.27M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1330470000000), DatetimeValue = 32.89M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1330556400000), DatetimeValue = 33.10M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1330642800000), DatetimeValue = 33.73M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1330902000000), DatetimeValue = 33.22M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1330988400000), DatetimeValue = 31.99M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1331074800000), DatetimeValue = 32.41M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1331161200000), DatetimeValue = 33.05M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1331247600000), DatetimeValue = 33.64M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1331506800000), DatetimeValue = 33.56M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1331593200000), DatetimeValue = 34.22M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1331679600000), DatetimeValue = 33.77M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1331766000000), DatetimeValue = 34.17M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1331852400000), DatetimeValue = 33.82M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1332111600000), DatetimeValue = 34.51M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1332198000000), DatetimeValue = 33.16M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1332284400000), DatetimeValue = 33.56M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1332370800000), DatetimeValue = 33.71M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1332457200000), DatetimeValue = 33.81M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1332712800000), DatetimeValue = 34.40M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1332799200000), DatetimeValue = 34.63M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1332885600000), DatetimeValue = 34.46M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1332972000000), DatetimeValue = 34.48M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1333058400000), DatetimeValue = 34.31M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1333317600000), DatetimeValue = 34.70M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1333404000000), DatetimeValue = 34.31M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1333490400000), DatetimeValue = 33.46M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1333576800000), DatetimeValue = 33.59M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1333922400000), DatetimeValue = 33.22M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1334008800000), DatetimeValue = 32.61M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1334095200000), DatetimeValue = 33.01M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1334181600000), DatetimeValue = 33.55M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1334268000000), DatetimeValue = 33.18M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1334527200000), DatetimeValue = 32.84M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1334613600000), DatetimeValue = 33.84M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1334700000000), DatetimeValue = 33.39M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1334786400000), DatetimeValue = 32.91M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1334872800000), DatetimeValue = 33.06M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1335132000000), DatetimeValue = 32.62M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1335218400000), DatetimeValue = 32.40M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1335304800000), DatetimeValue = 33.13M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1335391200000), DatetimeValue = 33.26M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1335477600000), DatetimeValue = 33.58M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1335736800000), DatetimeValue = 33.55M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1335823200000), DatetimeValue = 33.77M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1335909600000), DatetimeValue = 33.76M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1335996000000), DatetimeValue = 33.32M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1336082400000), DatetimeValue = 32.61M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1336341600000), DatetimeValue = 32.52M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1336428000000), DatetimeValue = 32.67M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1336514400000), DatetimeValue = 32.52M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1336600800000), DatetimeValue = 31.92M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1336687200000), DatetimeValue = 32.20M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1336946400000), DatetimeValue = 32.23M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1337032800000), DatetimeValue = 32.33M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1337119200000), DatetimeValue = 32.36M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1337205600000), DatetimeValue = 32.01M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1337292000000), DatetimeValue = 31.31M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1337551200000), DatetimeValue = 32.01M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1337637600000), DatetimeValue = 32.01M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1337724000000), DatetimeValue = 32.18M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1337810400000), DatetimeValue = 31.54M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1337896800000), DatetimeValue = 31.60M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1338242400000), DatetimeValue = 32.05M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1338328800000), DatetimeValue = 31.29M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1338415200000), DatetimeValue = 31.05M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1338501600000), DatetimeValue = 29.82M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1338760800000), DatetimeValue = 30.31M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1338847200000), DatetimeValue = 30.70M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1338933600000), DatetimeValue = 31.69M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1339020000000), DatetimeValue = 31.32M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1339106400000), DatetimeValue = 31.65M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1339365600000), DatetimeValue = 31.13M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1339452000000), DatetimeValue = 31.77M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1339538400000), DatetimeValue = 31.79M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1339624800000), DatetimeValue = 31.67M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1339711200000), DatetimeValue = 32.39M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1339970400000), DatetimeValue = 32.63M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1340056800000), DatetimeValue = 32.89M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1340143200000), DatetimeValue = 31.99M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1340229600000), DatetimeValue = 31.23M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1340316000000), DatetimeValue = 31.57M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1340575200000), DatetimeValue = 30.84M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1340661600000), DatetimeValue = 31.07M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1340748000000), DatetimeValue = 31.41M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1340834400000), DatetimeValue = 31.17M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1340920800000), DatetimeValue = 32.37M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1341180000000), DatetimeValue = 32.19M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1341266400000), DatetimeValue = 32.51M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1341439200000), DatetimeValue = 32.53M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1341525600000), DatetimeValue = 31.37M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1341784800000), DatetimeValue = 30.43M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1341871200000), DatetimeValue = 30.44M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1341957600000), DatetimeValue = 30.20M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1342044000000), DatetimeValue = 30.14M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1342130400000), DatetimeValue = 30.65M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1342389600000), DatetimeValue = 30.40M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1342476000000), DatetimeValue = 30.65M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1342562400000), DatetimeValue = 31.43M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1342648800000), DatetimeValue = 31.89M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1342735200000), DatetimeValue = 31.38M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1342994400000), DatetimeValue = 30.64M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1343080800000), DatetimeValue = 30.02M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1343167200000), DatetimeValue = 30.33M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1343253600000), DatetimeValue = 30.95M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1343340000000), DatetimeValue = 31.89M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1343599200000), DatetimeValue = 31.01M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1343685600000), DatetimeValue = 30.88M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1343772000000), DatetimeValue = 30.69M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1343858400000), DatetimeValue = 30.58M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1343944800000), DatetimeValue = 32.02M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1344204000000), DatetimeValue = 32.14M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1344290400000), DatetimeValue = 32.37M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1344376800000), DatetimeValue = 32.51M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1344463200000), DatetimeValue = 32.65M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1344549600000), DatetimeValue = 32.64M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1344808800000), DatetimeValue = 32.27M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1344895200000), DatetimeValue = 32.10M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1344981600000), DatetimeValue = 32.91M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1345068000000), DatetimeValue = 33.65M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1345154400000), DatetimeValue = 33.80M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1345413600000), DatetimeValue = 33.92M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1345500000000), DatetimeValue = 33.75M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1345586400000), DatetimeValue = 33.84M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1345672800000), DatetimeValue = 33.50M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1345759200000), DatetimeValue = 32.26M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1346018400000), DatetimeValue = 32.32M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1346104800000), DatetimeValue = 32.06M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1346191200000), DatetimeValue = 31.96M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1346277600000), DatetimeValue = 31.46M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1346364000000), DatetimeValue = 31.27M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1346709600000), DatetimeValue = 31.43M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1346796000000), DatetimeValue = 32.26M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1346882400000), DatetimeValue = 32.79M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1346968800000), DatetimeValue = 32.46M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1347228000000), DatetimeValue = 32.13M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1347314400000), DatetimeValue = 32.43M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1347400800000), DatetimeValue = 32.42M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1347487200000), DatetimeValue = 32.81M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1347573600000), DatetimeValue = 33.34M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1347832800000), DatetimeValue = 33.41M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1347919200000), DatetimeValue = 32.57M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1348005600000), DatetimeValue = 33.12M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1348092000000), DatetimeValue = 34.53M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1348178400000), DatetimeValue = 33.83M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1348437600000), DatetimeValue = 33.41M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1348524000000), DatetimeValue = 32.90M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1348610400000), DatetimeValue = 32.53M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1348696800000), DatetimeValue = 32.80M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1348783200000), DatetimeValue = 32.44M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1349042400000), DatetimeValue = 32.62M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1349128800000), DatetimeValue = 32.57M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1349215200000), DatetimeValue = 32.60M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1349301600000), DatetimeValue = 32.68M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1349388000000), DatetimeValue = 32.47M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1349647200000), DatetimeValue = 32.23M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1349733600000), DatetimeValue = 31.68M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1349820000000), DatetimeValue = 31.51M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1349906400000), DatetimeValue = 31.78M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1349992800000), DatetimeValue = 31.94M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1350252000000), DatetimeValue = 32.33M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1350338400000), DatetimeValue = 33.24M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1350424800000), DatetimeValue = 33.44M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1350511200000), DatetimeValue = 33.48M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1350597600000), DatetimeValue = 33.24M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1350856800000), DatetimeValue = 33.49M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1350943200000), DatetimeValue = 33.31M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1351029600000), DatetimeValue = 33.36M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1351116000000), DatetimeValue = 33.40M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1351202400000), DatetimeValue = 34.01M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1351638000000), DatetimeValue = 34.02M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1351724400000), DatetimeValue = 34.36M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1351810800000), DatetimeValue = 34.39M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1352070000000), DatetimeValue = 34.24M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1352156400000), DatetimeValue = 34.39M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1352242800000), DatetimeValue = 33.47M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1352329200000), DatetimeValue = 32.98M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1352415600000), DatetimeValue = 32.90M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1352674800000), DatetimeValue = 32.70M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1352761200000), DatetimeValue = 32.54M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1352847600000), DatetimeValue = 32.23M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1352934000000), DatetimeValue = 32.64M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1353020400000), DatetimeValue = 32.65M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1353279600000), DatetimeValue = 32.92M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1353366000000), DatetimeValue = 32.64M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1353452400000), DatetimeValue = 32.84M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1353625200000), DatetimeValue = 33.40M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1353884400000), DatetimeValue = 33.30M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1353970800000), DatetimeValue = 33.18M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1354057200000), DatetimeValue = 33.88M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1354143600000), DatetimeValue = 34.09M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1354230000000), DatetimeValue = 34.61M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1354489200000), DatetimeValue = 34.70M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1354575600000), DatetimeValue = 35.30M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1354662000000), DatetimeValue = 35.40M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1354748400000), DatetimeValue = 35.14M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1354834800000), DatetimeValue = 35.48M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1355094000000), DatetimeValue = 35.75M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1355180400000), DatetimeValue = 35.54M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1355266800000), DatetimeValue = 35.96M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1355353200000), DatetimeValue = 35.53M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1355439600000), DatetimeValue = 37.56M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1355698800000), DatetimeValue = 37.42M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1355785200000), DatetimeValue = 37.49M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1355871600000), DatetimeValue = 38.09M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1355958000000), DatetimeValue = 37.87M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1356044400000), DatetimeValue = 37.71M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1356303600000), DatetimeValue = 37.53M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1356476400000), DatetimeValue = 37.55M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1356562800000), DatetimeValue = 37.30M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1356649200000), DatetimeValue = 36.90M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1356908400000), DatetimeValue = 37.68M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1357081200000), DatetimeValue = 38.34M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1357167600000), DatetimeValue = 37.75M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1357254000000), DatetimeValue = 38.13M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1357513200000), DatetimeValue = 37.94M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1357599600000), DatetimeValue = 38.14M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1357686000000), DatetimeValue = 38.66M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1357772400000), DatetimeValue = 38.62M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1357858800000), DatetimeValue = 38.09M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1358118000000), DatetimeValue = 38.16M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1358204400000), DatetimeValue = 38.15M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1358290800000), DatetimeValue = 37.88M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1358377200000), DatetimeValue = 37.73M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1358463600000), DatetimeValue = 37.98M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1358809200000), DatetimeValue = 37.95M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1358895600000), DatetimeValue = 38.25M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1358982000000), DatetimeValue = 38.10M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1359068400000), DatetimeValue = 38.32M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1359327600000), DatetimeValue = 38.24M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1359414000000), DatetimeValue = 38.52M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1359500400000), DatetimeValue = 37.94M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1359586800000), DatetimeValue = 37.83M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1359673200000), DatetimeValue = 38.34M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1359932400000), DatetimeValue = 38.10M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1360018800000), DatetimeValue = 38.51M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1360105200000), DatetimeValue = 38.40M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1360191600000), DatetimeValue = 38.07M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1360278000000), DatetimeValue = 39.12M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1360537200000), DatetimeValue = 38.64M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1360623600000), DatetimeValue = 38.89M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1360710000000), DatetimeValue = 38.81M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1360796400000), DatetimeValue = 38.61M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1360882800000), DatetimeValue = 38.63M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1361228400000), DatetimeValue = 38.99M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1361314800000), DatetimeValue = 38.77M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1361401200000), DatetimeValue = 38.34M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1361487600000), DatetimeValue = 38.55M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1361746800000), DatetimeValue = 38.11M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1361833200000), DatetimeValue = 38.59M});
            AreaDatetimecharts.Add(new AreaDatetimechart { DatetimeSeries = new DateTime(1361919600000), DatetimeValue = 39.60M});
            return AreaDatetimecharts;
        }
    }
}