
namespace ColumnData
{
    public class Columnbasicchart {
        public string? Month { get; set; }
        public decimal ProfitValue { get; set; }
        public decimal RevenueValue { get; set; }
        public decimal CashFlowValue { get; set; }
        
    } ;
    public class ColumnDatalabelschart {
        public string? Month { get; set; }
        public decimal Inflation { get; set; }
        
    } ;
    public class ColumnStackedchart {
        public string? ProductValue { get; set; }
        public decimal ProductA { get; set; }
        public decimal ProductB { get; set; }
        public decimal ProductC { get; set; }
        public decimal ProductD { get; set; }
        
    } ;
    public class ColumnFullStackedchart {
        public string? ProductValue { get; set; }
        public decimal ProductA { get; set; }
        public decimal ProductB { get; set; }
        public decimal ProductC { get; set; }
        
    } ;
    public class ColumnMarkerschart {
        public string? MarkersData { get; set; }
        public decimal GrossValue { get; set; }
        
    } ;
    public class ColumnRotatedchart {
        public string? Fruits { get; set; }
        public decimal ServingsValue { get; set; }
        
    } ;
    public class ColumnNegativechart {
        public string? FlowDate { get; set; }
        public decimal CashFlowValue { get; set; }
        
    } ;    
    public class Activity
    {
        public string? Team { get; set; }
        public string? Name { get; set; }
        public decimal StartValue { get; set; }
        public decimal EndValue { get; set; }
    }
    public class ColumnDistributedchart {
        public string? Persons { get; set; }
        public decimal SeriesValue { get; set; }
        
    } ;
    public class ColumnService {
        public static List<Columnbasicchart> GetColumnbasiccharts()
        {
            var Columnbasiccharts = new List<Columnbasicchart> ();
            Columnbasiccharts.Add(new Columnbasicchart { Month = "Feb", ProfitValue = 44, RevenueValue = 76,  CashFlowValue = 35});
            Columnbasiccharts.Add(new Columnbasicchart { Month = "Mar", ProfitValue = 55, RevenueValue = 85,  CashFlowValue = 41});
            Columnbasiccharts.Add(new Columnbasicchart { Month = "Apr", ProfitValue = 57, RevenueValue = 101, CashFlowValue = 36});
            Columnbasiccharts.Add(new Columnbasicchart { Month = "May", ProfitValue = 56, RevenueValue = 98,  CashFlowValue = 26});
            Columnbasiccharts.Add(new Columnbasicchart { Month = "Jun", ProfitValue = 61, RevenueValue = 87,  CashFlowValue = 45});
            Columnbasiccharts.Add(new Columnbasicchart { Month = "Jul", ProfitValue = 58, RevenueValue = 105, CashFlowValue = 48});
            Columnbasiccharts.Add(new Columnbasicchart { Month = "Aug", ProfitValue = 63, RevenueValue = 91,  CashFlowValue = 52});
            Columnbasiccharts.Add(new Columnbasicchart { Month = "Sep", ProfitValue = 60, RevenueValue = 114, CashFlowValue = 53});
            Columnbasiccharts.Add(new Columnbasicchart { Month = "Oct", ProfitValue = 66, RevenueValue = 94,  CashFlowValue = 41});
            return Columnbasiccharts;
        }
        public static List<ColumnDatalabelschart> GetColumnDatalabelscharts()
        {
           var ColumnDatalabelscharts = new List<ColumnDatalabelschart> ();
            ColumnDatalabelscharts.Add(new ColumnDatalabelschart { Month = "Jan", Inflation = 2.3M });
            ColumnDatalabelscharts.Add(new ColumnDatalabelschart { Month = "Feb", Inflation = 3.1M });
            ColumnDatalabelscharts.Add(new ColumnDatalabelschart { Month = "Mar", Inflation = 4.0M  });
            ColumnDatalabelscharts.Add(new ColumnDatalabelschart { Month = "Apr", Inflation = 10.1M});
            ColumnDatalabelscharts.Add(new ColumnDatalabelschart { Month = "May", Inflation = 4.0M });
            ColumnDatalabelscharts.Add(new ColumnDatalabelschart { Month = "Jun", Inflation = 3.6M });
            ColumnDatalabelscharts.Add(new ColumnDatalabelschart { Month = "Jul", Inflation = 3.2M });
            ColumnDatalabelscharts.Add(new ColumnDatalabelschart { Month = "Aug", Inflation = 2.3M });
            ColumnDatalabelscharts.Add(new ColumnDatalabelschart { Month = "Sep", Inflation = 1.4M });
            ColumnDatalabelscharts.Add(new ColumnDatalabelschart { Month = "Oct", Inflation = 0.8M });
            ColumnDatalabelscharts.Add(new ColumnDatalabelschart { Month = "Nov", Inflation = 0.5M });
            ColumnDatalabelscharts.Add(new ColumnDatalabelschart { Month = "Dec", Inflation = 0.2M });
            return ColumnDatalabelscharts;
        }
        public static List<ColumnStackedchart> GetColumnStackedcharts()
        {
            var ColumnStackedcharts = new List<ColumnStackedchart>();
            ColumnStackedcharts.Add(new ColumnStackedchart { ProductValue = "01/01/2011 GMT", ProductA = 44, ProductB = 13, ProductC = 11 , ProductD = 21 });
            ColumnStackedcharts.Add(new ColumnStackedchart { ProductValue = "01/02/2011 GMT", ProductA = 55, ProductB = 23, ProductC = 17 , ProductD = 7 });
            ColumnStackedcharts.Add(new ColumnStackedchart { ProductValue = "01/03/2011 GMT", ProductA = 41, ProductB = 20, ProductC = 15 , ProductD = 25 });
            ColumnStackedcharts.Add(new ColumnStackedchart { ProductValue = "01/04/2011 GMT", ProductA = 67, ProductB = 8, ProductC =  15 , ProductD = 13 });
            ColumnStackedcharts.Add(new ColumnStackedchart { ProductValue = "01/05/2011 GMT", ProductA = 22, ProductB = 13, ProductC = 21 , ProductD = 22 });
            ColumnStackedcharts.Add(new ColumnStackedchart { ProductValue = "01/06/2011 GMT", ProductA = 43, ProductB = 27, ProductC = 14 , ProductD = 8 });
            return ColumnStackedcharts;
        }
        public static List<ColumnFullStackedchart> GetColumnFullStackedcharts()
        {
            var ColumnFullStackedcharts = new List<ColumnFullStackedchart>();
           ColumnFullStackedcharts.Add(new ColumnFullStackedchart { ProductValue = "2011 Q1", ProductA = 44, ProductB = 13, ProductC = 11 });
           ColumnFullStackedcharts.Add(new ColumnFullStackedchart { ProductValue = "2011 Q2", ProductA = 55, ProductB = 23, ProductC = 17 });
           ColumnFullStackedcharts.Add(new ColumnFullStackedchart { ProductValue = "2011 Q3", ProductA = 41, ProductB = 20, ProductC = 15 });
           ColumnFullStackedcharts.Add(new ColumnFullStackedchart { ProductValue = "2011 Q4", ProductA = 67, ProductB = 8, ProductC =  15 });
           ColumnFullStackedcharts.Add(new ColumnFullStackedchart { ProductValue = "2012 Q1", ProductA = 22, ProductB = 13, ProductC = 21 });
           ColumnFullStackedcharts.Add(new ColumnFullStackedchart { ProductValue = "2012 Q2", ProductA = 43, ProductB = 27, ProductC = 14 });
           ColumnFullStackedcharts.Add(new ColumnFullStackedchart { ProductValue = "2012 Q3", ProductA = 21, ProductB = 33, ProductC = 15 });
           ColumnFullStackedcharts.Add(new ColumnFullStackedchart { ProductValue = "2012 Q4", ProductA = 49, ProductB = 12, ProductC = 13 });
            return ColumnFullStackedcharts;
        }
        public static List<ColumnMarkerschart> GetColumnMarkerscharts()
        {
            var ColumnMarkerscharts = new List<ColumnMarkerschart>();
            ColumnMarkerscharts.Add(new ColumnMarkerschart { MarkersData = "2011", GrossValue = 1292});
            ColumnMarkerscharts.Add(new ColumnMarkerschart { MarkersData = "2012", GrossValue = 4432});
            ColumnMarkerscharts.Add(new ColumnMarkerschart { MarkersData = "2013", GrossValue = 5423});
            ColumnMarkerscharts.Add(new ColumnMarkerschart { MarkersData = "2014", GrossValue = 6653});
            ColumnMarkerscharts.Add(new ColumnMarkerschart { MarkersData = "2015", GrossValue = 8133});
            ColumnMarkerscharts.Add(new ColumnMarkerschart { MarkersData = "2016", GrossValue = 7132});
            ColumnMarkerscharts.Add(new ColumnMarkerschart { MarkersData = "2017", GrossValue = 7332});
            ColumnMarkerscharts.Add(new ColumnMarkerschart { MarkersData = "2018", GrossValue = 6553});
            return ColumnMarkerscharts;
        }
        public static List<ColumnRotatedchart> GetColumnRotatedcharts()
        {
            var ColumnRotatedcharts = new List<ColumnRotatedchart>();
            ColumnRotatedcharts.Add(new ColumnRotatedchart { Fruits = "Apples", ServingsValue = 44});
            ColumnRotatedcharts.Add(new ColumnRotatedchart { Fruits = "Oranges", ServingsValue = 55});
            ColumnRotatedcharts.Add(new ColumnRotatedchart { Fruits = "Strawberries", ServingsValue = 41});
            ColumnRotatedcharts.Add(new ColumnRotatedchart { Fruits = "Pineapples", ServingsValue = 67});
            ColumnRotatedcharts.Add(new ColumnRotatedchart { Fruits = "Mangoes", ServingsValue = 22});
            ColumnRotatedcharts.Add(new ColumnRotatedchart { Fruits = "Bananas", ServingsValue = 43});
            ColumnRotatedcharts.Add(new ColumnRotatedchart { Fruits = "Blackberries", ServingsValue = 21});
            ColumnRotatedcharts.Add(new ColumnRotatedchart { Fruits = "Pears", ServingsValue = 33});
            ColumnRotatedcharts.Add(new ColumnRotatedchart { Fruits = "Watermelons", ServingsValue = 45});
            ColumnRotatedcharts.Add(new ColumnRotatedchart { Fruits = "Cherries", ServingsValue = 31});
            ColumnRotatedcharts.Add(new ColumnRotatedchart { Fruits = "Pomegranates", ServingsValue = 87});
            ColumnRotatedcharts.Add(new ColumnRotatedchart { Fruits = "Tangerines", ServingsValue = 65});
            ColumnRotatedcharts.Add(new ColumnRotatedchart { Fruits = "Papayas", ServingsValue = 35});
            return ColumnRotatedcharts;
        }
        public static List<ColumnNegativechart> GetColumnNegativecharts()
        {
            var ColumnNegativecharts = new List<ColumnNegativechart>();
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2011-01-01", CashFlowValue = 1.45M   });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2011-02-01", CashFlowValue = 5.42M   });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2011-03-01", CashFlowValue = 5.9M    });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2011-04-01", CashFlowValue = -0.42M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2011-05-01", CashFlowValue = -12.6M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2011-06-01", CashFlowValue = -18.1M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2011-07-01", CashFlowValue = -18.2M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2011-08-01", CashFlowValue = -14.16M });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2011-09-01", CashFlowValue = -11.1M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2011-10-01", CashFlowValue = -6.09M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2011-11-01", CashFlowValue = 0.34M   });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2011-12-01", CashFlowValue = 3.88M   });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2012-01-01", CashFlowValue = 13.07M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2012-02-01", CashFlowValue = 5.8M    });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2012-03-01", CashFlowValue = 2.0M    });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2012-04-01", CashFlowValue = 7.37M   });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2012-05-01", CashFlowValue = 8.1M    });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2012-06-01", CashFlowValue = 13.57M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2012-07-01", CashFlowValue = 15.75M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2012-08-01", CashFlowValue = 17.1M   });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2012-09-01", CashFlowValue = 19.8M   });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2012-10-01", CashFlowValue = -27.03M });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2012-11-01", CashFlowValue = -54.4M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2012-12-01", CashFlowValue = -47.2M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2013-01-01", CashFlowValue = -43.3M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2013-02-01", CashFlowValue = -18.6M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2013-03-01", CashFlowValue = -48.6M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2013-04-01", CashFlowValue = -41.1M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2013-05-01", CashFlowValue = -39.6M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2013-06-01", CashFlowValue = -37.6M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2013-07-01", CashFlowValue = -29.4M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2013-08-01", CashFlowValue = -21.4M  });
            ColumnNegativecharts.Add(new ColumnNegativechart { FlowDate = "2013-09-01", CashFlowValue = -2.4M   });
            return ColumnNegativecharts;
        }
        public static List<ColumnDistributedchart> GetColumnDistributedcharts()
        {
           var ColumnDistributedcharts = new List<ColumnDistributedchart>();
           ColumnDistributedcharts.Add( new ColumnDistributedchart { Persons = "JohnDoe", SeriesValue = 21});
           ColumnDistributedcharts.Add( new ColumnDistributedchart { Persons = "JoeSmith", SeriesValue = 22});
           ColumnDistributedcharts.Add( new ColumnDistributedchart { Persons = "JakeWilliams", SeriesValue = 10});
           ColumnDistributedcharts.Add( new ColumnDistributedchart { Persons = "Amber", SeriesValue = 28});
           ColumnDistributedcharts.Add( new ColumnDistributedchart { Persons = "Peter Brown", SeriesValue = 16});
           ColumnDistributedcharts.Add( new ColumnDistributedchart { Persons = "MaryEvans", SeriesValue = 21});
           ColumnDistributedcharts.Add( new ColumnDistributedchart { Persons = "DavidWilson", SeriesValue = 13});
           ColumnDistributedcharts.Add( new ColumnDistributedchart { Persons = "LilyRoberts", SeriesValue = 30});
            return ColumnDistributedcharts;
        }
    }
}