
namespace BarData
{
    public class Barbasicchart {
        public string? Country { get; set; }
        public decimal GrossValue { get; set; }
        
    } ;
    public class BarGroupedchart {
        public string? SeriesData { get; set; }
        public decimal SeriesValue1 { get; set; }
        public decimal SeriesValue2 { get; set; }
        
    } ;
    public class BarStackedchart {
        public string? SalesValue { get; set; }
        public decimal SpriteValue { get; set; }
        public decimal StrikingValue { get; set; }
        public decimal TankValue { get; set; }
        public decimal BucketValue { get; set; }
        public decimal RebornValue { get; set; }
        
    } ;
    public class BarFullStackedchart {
        public string? SalesValue { get; set; }
        public decimal SpriteValue { get; set; }
        public decimal StrikingValue { get; set; }
        public decimal TankValue { get; set; }
        public decimal BucketValue { get; set; }
        public decimal RebornValue { get; set; }
        
    } ;
    public class BarNegativechart {
        public string? populationData { get; set; }
        public decimal MaleValue { get; set; }
        public decimal FemaleValue { get; set; }
        
    } ;
    public class BarMarkerschart {
        public string? MarkersData { get; set; }
        public decimal GrossValue { get; set; }
        
    } ;
    public class BarReversedchart {
        public string? Month { get; set; }
        public decimal GrossValue { get; set; }
        
    } ;
    public class BarDataLabelschart {
        public string? Country { get; set; }
        public decimal GrossValue { get; set; }
        
    } ;
    public class BarPatternchart {
        public string? SalesValue { get; set; }
        public decimal SpriteValue { get; set; }
        public decimal StrikingValue { get; set; }
        public decimal TankValue { get; set; }
        public decimal BucketValue { get; set; }
        
    } ;
    public class BarImageFillchart {
        public decimal CoinsSeries { get; set; }
        public decimal CoinsValue { get; set; }
        
    } ;
    public class BarService {
        public static List<Barbasicchart> GetBarbasiccharts(){
            var Barbasiccharts = new List<Barbasicchart>();
            Barbasiccharts.Add(new Barbasicchart { Country = "South Korea",    GrossValue = 400});
            Barbasiccharts.Add(new Barbasicchart { Country = "Canada",         GrossValue = 430});
            Barbasiccharts.Add(new Barbasicchart { Country = "United Kingdom", GrossValue = 448});
            Barbasiccharts.Add(new Barbasicchart { Country = "Netherlands",    GrossValue = 470});
            Barbasiccharts.Add(new Barbasicchart { Country = "Italy",          GrossValue = 540});
            Barbasiccharts.Add(new Barbasicchart { Country = "France",         GrossValue = 580});
            Barbasiccharts.Add(new Barbasicchart { Country = "Japan",          GrossValue = 690});
            Barbasiccharts.Add(new Barbasicchart { Country = "United States",  GrossValue = 1100});
            Barbasiccharts.Add(new Barbasicchart { Country = "China",          GrossValue = 1200});
            Barbasiccharts.Add(new Barbasicchart { Country = "Germany",        GrossValue = 1380});
            return Barbasiccharts;
        }
        public static List<BarGroupedchart> GetBarGroupedcharts() {
            var BarGroupedcharts = new List<BarGroupedchart>();
            BarGroupedcharts.Add(new BarGroupedchart { SeriesData = "2001", SeriesValue1 = 44, SeriesValue2 = 53 });
            BarGroupedcharts.Add(new BarGroupedchart { SeriesData = "2002", SeriesValue1 = 55, SeriesValue2 = 32 });
            BarGroupedcharts.Add(new BarGroupedchart { SeriesData = "2003", SeriesValue1 = 41, SeriesValue2 = 33 });
            BarGroupedcharts.Add(new BarGroupedchart { SeriesData = "2004", SeriesValue1 = 64, SeriesValue2 = 52 });
            BarGroupedcharts.Add(new BarGroupedchart { SeriesData = "2005", SeriesValue1 = 22, SeriesValue2 = 13 });
            BarGroupedcharts.Add(new BarGroupedchart { SeriesData = "2006", SeriesValue1 = 43, SeriesValue2 = 44 });
            BarGroupedcharts.Add(new BarGroupedchart { SeriesData = "2007", SeriesValue1 = 21, SeriesValue2 = 32 });
            return BarGroupedcharts;
        }
        public static List<BarStackedchart> GetBarStackedcharts() {
            var BarStackedcharts = new List<BarStackedchart>();
            BarStackedcharts.Add(new BarStackedchart { SalesValue = "2008", SpriteValue = 44, StrikingValue = 53, TankValue = 12 , BucketValue = 9 , RebornValue = 25 });
            BarStackedcharts.Add(new BarStackedchart { SalesValue = "2009", SpriteValue = 55, StrikingValue = 32, TankValue = 17 , BucketValue = 7 , RebornValue = 12 });
            BarStackedcharts.Add(new BarStackedchart { SalesValue = "2010", SpriteValue = 41, StrikingValue = 33, TankValue = 11 , BucketValue = 5 , RebornValue = 19 });
            BarStackedcharts.Add(new BarStackedchart { SalesValue = "2011", SpriteValue = 37, StrikingValue = 52, TankValue =  9 , BucketValue = 8 , RebornValue = 32 });
            BarStackedcharts.Add(new BarStackedchart { SalesValue = "2012", SpriteValue = 22, StrikingValue = 13, TankValue = 15 , BucketValue = 6 , RebornValue = 25 });
            BarStackedcharts.Add(new BarStackedchart { SalesValue = "2013", SpriteValue = 43, StrikingValue = 43, TankValue = 11 , BucketValue = 9 , RebornValue = 24 });
            BarStackedcharts.Add(new BarStackedchart { SalesValue = "2014", SpriteValue = 21, StrikingValue = 32, TankValue = 20 , BucketValue = 4 , RebornValue = 10 });
            return BarStackedcharts;
        }
        public static List<BarFullStackedchart> GetBarFullStackedcharts() {
           var BarFullStackedcharts = new List<BarFullStackedchart>();
            BarFullStackedcharts.Add(new BarFullStackedchart { SalesValue = "2008", SpriteValue = 44, StrikingValue = 53, TankValue = 12 , BucketValue = 9 , RebornValue = 25 });
            BarFullStackedcharts.Add(new BarFullStackedchart { SalesValue = "2009", SpriteValue = 55, StrikingValue = 32, TankValue = 17 , BucketValue = 7 , RebornValue = 12 });
            BarFullStackedcharts.Add(new BarFullStackedchart { SalesValue = "2010", SpriteValue = 41, StrikingValue = 33, TankValue = 11 , BucketValue = 5 , RebornValue = 19 });
            BarFullStackedcharts.Add(new BarFullStackedchart { SalesValue = "2011", SpriteValue = 37, StrikingValue = 52, TankValue =  9 , BucketValue = 8 , RebornValue = 32 });
            BarFullStackedcharts.Add(new BarFullStackedchart { SalesValue = "2012", SpriteValue = 22, StrikingValue = 13, TankValue = 15 , BucketValue = 6 , RebornValue = 25 });
            BarFullStackedcharts.Add(new BarFullStackedchart { SalesValue = "2013", SpriteValue = 43, StrikingValue = 43, TankValue = 11 , BucketValue = 9 , RebornValue = 24 });
            BarFullStackedcharts.Add(new BarFullStackedchart { SalesValue = "2014", SpriteValue = 21, StrikingValue = 32, TankValue = 20 , BucketValue = 4 , RebornValue = 10 });
            return BarFullStackedcharts;
        }
        public static List<BarNegativechart> GetBarNegativecharts() {
            var BarNegativecharts = new List<BarNegativechart>();
            BarNegativecharts.Add(new BarNegativechart { populationData = "85+", MaleValue = 0.4M, FemaleValue = -0.8M });
            BarNegativecharts.Add(new BarNegativechart { populationData = "80-84", MaleValue = 0.65M, FemaleValue = -1.05M });
            BarNegativecharts.Add(new BarNegativechart { populationData = "75-79", MaleValue = 0.76M, FemaleValue = -1.06M });
            BarNegativecharts.Add(new BarNegativechart { populationData = "70-74", MaleValue = 0.88M, FemaleValue = -1.18M });
            BarNegativecharts.Add(new BarNegativechart { populationData = "65-69", MaleValue = 1.5M, FemaleValue = -1.4M });
            BarNegativecharts.Add(new BarNegativechart { populationData = "60-64", MaleValue = 2.1M, FemaleValue = -2.2M });
            BarNegativecharts.Add(new BarNegativechart { populationData = "55-59", MaleValue = 2.9M, FemaleValue = -2.85M });
            BarNegativecharts.Add(new BarNegativechart { populationData = "50-54", MaleValue = 3.8M, FemaleValue = -3.7M });
            BarNegativecharts.Add(new BarNegativechart { populationData = "45-49", MaleValue = 3.9M, FemaleValue = -3.96M });
            BarNegativecharts.Add(new BarNegativechart { populationData = "40-44", MaleValue = 4.2M, FemaleValue = -4.22M });
            BarNegativecharts.Add(new BarNegativechart { populationData = "35-39", MaleValue = 4.0M, FemaleValue = -4.3M });
            BarNegativecharts.Add(new BarNegativechart { populationData = "30-34", MaleValue = 4.3M, FemaleValue = -4.4M });
            BarNegativecharts.Add(new BarNegativechart { populationData = "25-29", MaleValue = 4.1M, FemaleValue = -4.1M });
            BarNegativecharts.Add(new BarNegativechart { populationData = "20-24", MaleValue = 4.2M, FemaleValue = -4.0M });
            BarNegativecharts.Add(new BarNegativechart { populationData = "15-19", MaleValue = 4.5M, FemaleValue = -4.1M });
            BarNegativecharts.Add(new BarNegativechart { populationData = "10-14", MaleValue = 3.9M, FemaleValue = -3.4M });
            BarNegativecharts.Add(new BarNegativechart { populationData = "5-9", MaleValue = 3.5M, FemaleValue = -3.1M });
            BarNegativecharts.Add(new BarNegativechart { populationData = "0-4", MaleValue = 3.0M, FemaleValue = -2.8M });
            return BarNegativecharts;
        }
        public static List<BarMarkerschart> GetBarMarkerscharts() {
            var BarMarkerscharts = new List<BarMarkerschart>();
            BarMarkerscharts.Add(new BarMarkerschart { MarkersData = "2011", GrossValue = 12});
            BarMarkerscharts.Add(new BarMarkerschart { MarkersData = "2012", GrossValue = 44});
            BarMarkerscharts.Add(new BarMarkerschart { MarkersData = "2013", GrossValue = 54});
            BarMarkerscharts.Add(new BarMarkerschart { MarkersData = "2014", GrossValue = 66});
            BarMarkerscharts.Add(new BarMarkerschart { MarkersData = "2015", GrossValue = 81});
            BarMarkerscharts.Add(new BarMarkerschart { MarkersData = "2016", GrossValue = 67});
            return BarMarkerscharts;
        }
        public static List<BarReversedchart> GetBarReversedcharts() {
            var BarReversedcharts = new List<BarReversedchart>();
            BarReversedcharts.Add(new BarReversedchart { Month = "June",      GrossValue = 400});
            BarReversedcharts.Add(new BarReversedchart { Month = "July",      GrossValue = 430});
            BarReversedcharts.Add(new BarReversedchart { Month = "August",    GrossValue = 448});
            BarReversedcharts.Add(new BarReversedchart { Month = "September", GrossValue = 470});
            BarReversedcharts.Add(new BarReversedchart { Month = "October",   GrossValue = 540});
            BarReversedcharts.Add(new BarReversedchart { Month = "November",  GrossValue = 580});
            BarReversedcharts.Add(new BarReversedchart { Month = "December",  GrossValue = 690});
            return BarReversedcharts;
        }
        public static List<BarDataLabelschart> GetBarDataLabelscharts() {
            List<BarDataLabelschart> BarDataLabelscharts = new List<BarDataLabelschart>();
            BarDataLabelscharts.Add(new BarDataLabelschart { Country = "South Korea",    GrossValue = 400});
            BarDataLabelscharts.Add(new BarDataLabelschart { Country = "Canada",         GrossValue = 430});
            BarDataLabelscharts.Add(new BarDataLabelschart { Country = "United Kingdom", GrossValue = 448});
            BarDataLabelscharts.Add(new BarDataLabelschart { Country = "Netherlands",    GrossValue = 470});
            BarDataLabelscharts.Add(new BarDataLabelschart { Country = "Italy",          GrossValue = 540});
            BarDataLabelscharts.Add(new BarDataLabelschart { Country = "France",         GrossValue = 580});
            BarDataLabelscharts.Add(new BarDataLabelschart { Country = "Japan",          GrossValue = 690});
            BarDataLabelscharts.Add(new BarDataLabelschart { Country = "United States",  GrossValue = 1100});
            BarDataLabelscharts.Add(new BarDataLabelschart { Country = "China",          GrossValue = 1200});
            BarDataLabelscharts.Add(new BarDataLabelschart { Country = "India",        GrossValue = 1380});
            return BarDataLabelscharts;
        }
        public static List<BarPatternchart> GetBarPatterncharts() {
            var BarPatterncharts = new List<BarPatternchart>();
            BarPatterncharts.Add(new BarPatternchart { SalesValue = "2008", SpriteValue = 44, StrikingValue = 53, TankValue = 12 , BucketValue = 9 });
            BarPatterncharts.Add(new BarPatternchart { SalesValue = "2009", SpriteValue = 55, StrikingValue = 32, TankValue = 17 , BucketValue = 7 });
            BarPatterncharts.Add(new BarPatternchart { SalesValue = "2010", SpriteValue = 41, StrikingValue = 33, TankValue = 11 , BucketValue = 5 });
            BarPatterncharts.Add(new BarPatternchart { SalesValue = "2011", SpriteValue = 37, StrikingValue = 52, TankValue =  9 , BucketValue = 8 });
            BarPatterncharts.Add(new BarPatternchart { SalesValue = "2012", SpriteValue = 22, StrikingValue = 13, TankValue = 15 , BucketValue = 6 });
            BarPatterncharts.Add(new BarPatternchart { SalesValue = "2013", SpriteValue = 43, StrikingValue = 43, TankValue = 11 , BucketValue = 9 });
            BarPatterncharts.Add(new BarPatternchart { SalesValue = "2014", SpriteValue = 21, StrikingValue = 32, TankValue = 20 , BucketValue = 4 });
            return BarPatterncharts;
        }
        public static List<BarImageFillchart> GetBarImageFillcharts()
        {
            var BarImageFillcharts = new List<BarImageFillchart>();
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 1, CoinsValue = 2});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 2, CoinsValue = 4});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 3, CoinsValue = 3});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 4, CoinsValue = 4});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 5, CoinsValue = 3});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 6, CoinsValue = 5});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 7, CoinsValue = 5});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 8, CoinsValue = 6.5M});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 9, CoinsValue = 6});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 10, CoinsValue = 5});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 11, CoinsValue = 4});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 12, CoinsValue = 5});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 13, CoinsValue = 8});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 14, CoinsValue = 7});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 15, CoinsValue = 7});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 16, CoinsValue = 8});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 17, CoinsValue = 8});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 18, CoinsValue = 10});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 19, CoinsValue = 9});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 20, CoinsValue = 9});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 21, CoinsValue = 12});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 22, CoinsValue = 12});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 23, CoinsValue = 11});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 24, CoinsValue = 12});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 25, CoinsValue = 13});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 26, CoinsValue = 14});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 27, CoinsValue = 16});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 28, CoinsValue = 14});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 29, CoinsValue = 15});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 30, CoinsValue = 17});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 30, CoinsValue = 19});
            BarImageFillcharts.Add(new BarImageFillchart { CoinsSeries = 32, CoinsValue = 21});
            return BarImageFillcharts;
        }

    }
}