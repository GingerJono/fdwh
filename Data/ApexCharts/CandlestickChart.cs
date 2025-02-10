
namespace CandlestickData
{
    public class Candlestickbasicchart
    {
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
    }
    public class CandlestickSyncedchart
    {
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
    }
    public class CandlestickSyncedchart2
    {
        public DateTime Date { get; set; }
        public decimal Quantity { get; set; }
    }
    public class CandlestickAnnotationchart
    {
        public string? AnnotationsDate { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
    }    
    public class CandlestickLinechart
    {
        public string? LinesDate { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public decimal LinesValue { get; set; }
    }
    public class CandlestickService {
        public static List<Candlestickbasicchart> GetCandlestickbasicData()
        {
           var CandlestickbasicData = new List<Candlestickbasicchart>();
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538778600000), Open = 6629.81M, High = 6650.5M, Low = 6623.04M, Close = 6633.33M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538780400000), Open = 6632.01M, High = 6643.59M, Low = 6620M, Close = 6630.11M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538782200000), Open = 6630.71M, High = 6648.95M, Low = 6623.34M, Close = 6635.65M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538784000000), Open = 6635.65M, High = 6651M, Low = 6629.67M, Close = 6638.24M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538785800000), Open = 6638.24M, High = 6640M, Low = 6620M, Close = 6624.47M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538787600000), Open = 6624.53M, High = 6636.03M, Low = 6621.68M, Close = 6624.31M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538789400000), Open = 6624.61M, High = 6632.2M, Low = 6617M, Close = 6626.02M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538791200000), Open = 6627M, High = 6627.62M, Low = 6584.22M, Close = 6603.02M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538793000000), Open = 6605M, High = 6608.03M, Low = 6598.95M, Close = 6604.01M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538794800000), Open = 6604.5M, High = 6614.4M, Low = 6602.26M, Close = 6608.02M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538796600000), Open = 6608.02M, High = 6610.68M, Low = 6601.99M, Close = 6608.91M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538798400000), Open = 6608.91M, High = 6618.99M, Low = 6608.01M, Close = 6612M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538800200000), Open = 6612M, High = 6615.13M, Low = 6605.09M, Close = 6612M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538802000000), Open = 6612M, High = 6624.12M, Low = 6608.43M, Close = 6622.95M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538803800000), Open = 6623.91M, High = 6623.91M, Low = 6615M, Close = 6615.67M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538805600000), Open = 6618.69M, High = 6618.74M, Low = 6610M, Close = 6610.4M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538807400000), Open = 6611M, High = 6622.78M, Low = 6610.4M, Close = 6614.9M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538809200000), Open = 6614.9M, High = 6626.2M, Low = 6613.33M, Close = 6623.45M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538811000000), Open = 6623.48M, High = 6627M, Low = 6618.38M, Close = 6620.35M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538812800000), Open = 6619.43M, High = 6620.35M, Low = 6610.05M, Close = 6615.53M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538814600000), Open = 6615.53M, High = 6617.93M, Low = 6610M, Close = 6615.19M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538816400000), Open = 6615.19M, High = 6621.6M, Low = 6608.2M, Close = 6620M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538818200000), Open = 6619.54M, High = 6625.17M, Low = 6614.15M, Close = 6620M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538820000000), Open = 6620.33M, High = 6634.15M, Low = 6617.24M, Close = 6624.61M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538821800000), Open = 6625.95M, High = 6626M, Low = 6611.66M, Close = 6617.58M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538823600000), Open = 6619M, High = 6625.97M, Low = 6595.27M, Close = 6598.86M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538825400000), Open = 6598.86M, High = 6598.88M, Low = 6570M, Close = 6587.16M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538827200000), Open = 6588.86M, High = 6600M, Low = 6580M, Close = 6593.4M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538829000000), Open = 6593.99M, High = 6598.89M, Low = 6585M, Close = 6587.81M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538830800000), Open = 6587.81M, High = 6592.73M, Low = 6567.14M, Close = 6578M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538832600000), Open = 6578.35M, High = 6581.72M, Low = 6567.39M, Close = 6579M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538834400000), Open = 6579.38M, High = 6580.92M, Low = 6566.77M, Close = 6575.96M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538836200000), Open = 6575.96M, High = 6589M, Low = 6571.77M, Close = 6588.92M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538838000000), Open = 6588.92M, High = 6594M, Low = 6577.55M, Close = 6589.22M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538839800000), Open = 6589.3M, High = 6598.89M, Low = 6589.1M, Close = 6596.08M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538841600000), Open = 6597.5M, High = 6600M, Low = 6588.39M, Close = 6596.25M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538843400000), Open = 6598.03M, High = 6600M, Low = 6588.73M, Close = 6595.97M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538845200000), Open = 6595.97M, High = 6602.01M, Low = 6588.17M, Close = 6602M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538847000000), Open = 6602M, High = 6607M, Low = 6596.51M, Close = 6599.95M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538848800000), Open = 6600.63M, High = 6601.21M, Low = 6590.39M, Close = 6591.02M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538850600000), Open = 6591.02M, High = 6603.08M, Low = 6591M, Close = 6591M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538852400000), Open = 6591M, High = 6601.32M, Low = 6585M, Close = 6592M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538854200000), Open = 6593.13M, High = 6596.01M, Low = 6590M, Close = 6593.34M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538856000000), Open = 6593.34M, High = 6604.76M, Low = 6582.63M, Close = 6593.86M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538857800000), Open = 6593.86M, High = 6604.28M, Low = 6586.57M, Close = 6600.01M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538859600000), Open = 6601.81M, High = 6603.21M, Low = 6592.78M, Close = 6596.25M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538861400000), Open = 6596.25M, High = 6604.2M, Low = 6590M, Close = 6602.99M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538863200000), Open = 6602.99M, High = 6606M, Low = 6584.99M, Close = 6587.81M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538865000000), Open = 6587.81M, High = 6595M, Low = 6583.27M, Close = 6591.96M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538866800000), Open = 6591.97M, High = 6596.07M, Low = 6585M, Close = 6588.39M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538868600000), Open = 6587.6M, High = 6598.21M, Low = 6587.6M, Close = 6594.27M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538870400000), Open = 6596.44M, High = 6601M, Low = 6590M, Close = 6596.55M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538872200000), Open = 6598.91M, High = 6605M, Low = 6596.61M, Close = 6600.02M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538874000000), Open = 6600.55M, High = 6605M, Low = 6589.14M, Close = 6593.01M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538875800000), Open = 6593.15M, High = 6605M, Low = 6592M, Close = 6603.06M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538877600000), Open = 6603.07M, High = 6604.5M, Low = 6599.09M, Close =6603.89M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538879400000), Open = 6604.44M, High = 6604.44M, Low = 6600M, Close = 6603.5M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538881200000), Open = 6603.5M, High = 6603.99M, Low = 6597.5M, Close = 6603.86M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538883000000), Open = 6603.85M, High = 6605M, Low = 6600M, Close = 6604.07M });
                CandlestickbasicData.Add(new Candlestickbasicchart { Date =new DateTime(1538884800000), Open = 6604.98M, High = 6606M, Low = 6604.07M, Close = 6606M });
            return CandlestickbasicData;

        }
        
        public static List<CandlestickSyncedchart> GetCandlestickSyncedData()
        {
            var CandlestickSyncedData = new List<CandlestickSyncedchart>();
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2016, 01, 01), Open = 51.98M, High = 56.29M, Low = 51.59M, Close = 53.85M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2016, 02, 01), Open = 53.66M, High = 54.99M, Low = 51.35M, Close = 52.95M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2016, 03, 01), Open = 52.96M, High = 53.78M, Low = 51.54M, Close = 52.48M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2016, 04, 01), Open = 52.54M, High = 52.79M, Low = 47.88M, Close = 49.24M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2016, 05, 01), Open = 49.10M, High = 52.86M, Low = 47.70M, Close = 52.78M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2016, 06, 01), Open = 52.83M, High = 53.48M, Low = 50.32M, Close = 52.29M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2016, 07, 01), Open = 52.20M, High = 54.48M, Low = 51.64M, Close = 52.58M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2016, 08, 01), Open = 52.76M, High = 57.35M, Low = 52.15M, Close = 57.03M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2016, 09, 01), Open = 57.04M, High = 58.15M, Low = 48.88M, Close = 56.19M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2016, 10, 01), Open = 56.09M, High = 58.85M, Low = 55.48M, Close = 58.79M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2016, 11, 01), Open = 58.78M, High = 59.65M, Low = 58.23M, Close = 59.05M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2016, 12, 01), Open = 59.37M, High = 61.11M, Low = 59.35M, Close = 60.34M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2017, 01, 01), Open = 60.40M, High = 60.52M, Low = 56.71M, Close = 56.93M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2017, 02, 01), Open = 57.02M, High = 59.71M, Low = 56.04M, Close = 56.82M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2017, 03, 01), Open = 56.97M, High = 59.62M, Low = 54.77M, Close = 59.30M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2017, 04, 01), Open = 59.11M, High = 62.29M, Low = 59.10M, Close = 59.85M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2017, 05, 01), Open = 59.97M, High = 60.11M, Low = 55.66M, Close = 58.42M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2017, 06, 01), Open = 58.34M, High = 60.93M, Low = 56.75M, Close = 57.42M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2017, 07, 01), Open = 57.76M, High = 58.08M, Low = 51.18M, Close = 54.71M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2017, 08, 01), Open = 54.80M, High = 61.42M, Low = 53.18M, Close = 57.35M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2017, 09, 01), Open = 57.56M, High = 63.09M, Low = 57.00M, Close = 62.99M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2017, 10, 01), Open = 62.89M, High = 63.42M, Low = 59.72M, Close = 61.76M});
            CandlestickSyncedData.Add(new CandlestickSyncedchart { Date =new DateTime(2017, 11, 01), Open = 61.71M, High = 64.15M, Low = 61.29M, Close = 63.04M});
            return CandlestickSyncedData;

        }
        public static List<CandlestickSyncedchart2> GetCandlestickSyncedData2()
        {
            var CandlestickSyncedData2 = new List<CandlestickSyncedchart2>();
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2016, 01, 01), Quantity = 3.85M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2016, 02, 01), Quantity = 2.95M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2016, 03, 01), Quantity = -12.48M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2016, 04, 01), Quantity = 19.24M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2016, 05, 01), Quantity = 12.78M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2016, 06, 01), Quantity = 22.29M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2016, 07, 01), Quantity = -12.58M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2016, 08, 01), Quantity = -17.03M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2016, 09, 01), Quantity = -19.19M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2016, 10, 01), Quantity = -28.79M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2016, 11, 01), Quantity = -39.05M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2016, 12, 01), Quantity = 20.34M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2017, 01, 01), Quantity = 36.93M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2017, 02, 01), Quantity = 36.82M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2017, 03, 01), Quantity = 29.30M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2017, 04, 01), Quantity = 39.85M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2017, 05, 01), Quantity = 28.42M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2017, 06, 01), Quantity = 37.42M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2017, 07, 01), Quantity = 24.71M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2017, 08, 01), Quantity = 37.35M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2017, 09, 01), Quantity = 32.99M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2017, 10, 01), Quantity = 31.76M });
            CandlestickSyncedData2.Add(new CandlestickSyncedchart2 { Date =new DateTime(2017, 11, 01), Quantity = 43.04M });
            return CandlestickSyncedData2;
        }
        public static List<CandlestickAnnotationchart> GetCandlestickAnnotationData()
        {
            var CandlestickAnnotationData = new List<CandlestickAnnotationchart>();
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="13 Nov 2017", Open = 6629.81M, High = 6650.5M, Low = 6623.04M, Close = 6633.33M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="14 Nov 2017", Open = 6632.01M, High = 6643.59M, Low = 6620M, Close = 6630.11M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="15 Nov 2017", Open = 6630.71M, High = 6648.95M, Low = 6623.34M, Close = 6635.65M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="16 Nov 2017", Open = 6635.65M, High = 6651M, Low = 6629.67M, Close = 6638.24M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="17 Nov 2017", Open = 6638.24M, High = 6640M, Low = 6620M, Close = 6624.47M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="18 Nov 2017", Open = 6624.53M, High = 6636.03M, Low = 6621.68M, Close = 6624.31M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="19 Nov 2017", Open = 6624.61M, High = 6632.2M, Low = 6617M, Close = 6626.02M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="20 Nov 2017", Open = 6627M, High = 6627.62M, Low = 6584.22M, Close = 6603.02M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="21 Nov 2017", Open = 6605M, High = 6608.03M, Low = 6598.95M, Close = 6604.01M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="22 Nov 2017", Open = 6604.5M, High = 6614.4M, Low = 6602.26M, Close = 6608.02M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="23 Nov 2017", Open = 6608.02M, High = 6610.68M, Low = 6601.99M, Close = 6608.91M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="24 Nov 2017", Open = 6608.91M, High = 6618.99M, Low = 6608.01M, Close = 6612M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="25 Nov 2017", Open = 6612M, High = 6615.13M, Low = 6605.09M, Close = 6612M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="26 Nov 2017", Open = 6612M, High = 6624.12M, Low = 6608.43M, Close = 6622.95M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="27 Nov 2017", Open = 6623.91M, High = 6623.91M, Low = 6615M, Close = 6615.67M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="28 Nov 2017", Open = 6618.69M, High = 6618.74M, Low = 6610M, Close = 6610.4M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="29 Nov 2017", Open = 6611M, High = 6622.78M, Low = 6610.4M, Close = 6614.9M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="30 Nov 2017", Open = 6614.9M, High = 6626.2M, Low = 6613.33M, Close = 6623.45M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="1 Dec 2017", Open = 6623.48M, High = 6627M, Low = 6618.38M, Close = 6620.35M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="2 Dec 2017", Open = 6619.43M, High = 6620.35M, Low = 6610.05M, Close = 6615.53M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="3 Dec 2017", Open = 6615.53M, High = 6617.93M, Low = 6610M, Close = 6615.19M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="4 Dec 2017", Open = 6615.19M, High = 6621.6M, Low = 6608.2M, Close = 6620M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="5 Dec 2017", Open = 6619.54M, High = 6625.17M, Low = 6614.15M, Close = 6620M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="6 Dec 2017", Open = 6620.33M, High = 6634.15M, Low = 6617.24M, Close = 6624.61M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="7 Dec 2017", Open = 6625.95M, High = 6626M, Low = 6611.66M, Close = 6617.58M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="8 Dec 2017", Open = 6619M, High = 6625.97M, Low = 6595.27M, Close = 6598.86M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="9 Dec 2017", Open = 6598.86M, High = 6598.88M, Low = 6570M, Close = 6587.16M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="10 Dec 2017", Open = 6588.86M, High = 6600M, Low = 6580M, Close = 6593.4M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="11 Dec 2017", Open = 6593.99M, High = 6598.89M, Low = 6585M, Close = 6587.81M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="12 Dec 2017", Open = 6587.81M, High = 6592.73M, Low = 6567.14M, Close = 6578M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="13 Dec 2017", Open = 6578.35M, High = 6581.72M, Low = 6567.39M, Close = 6579M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="14 Dec 2017", Open = 6579.38M, High = 6580.92M, Low = 6566.77M, Close = 6575.96M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="15 Dec 2017", Open = 6575.96M, High = 6589M, Low = 6571.77M, Close = 6588.92M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="16 Dec 2017", Open = 6588.92M, High = 6594M, Low = 6577.55M, Close = 6589.22M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="17 Dec 2017", Open = 6589.3M, High = 6598.89M, Low = 6589.1M, Close = 6596.08M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="18 Dec 2017", Open = 6597.5M, High = 6600M, Low = 6588.39M, Close = 6596.25M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="19 Dec 2017", Open = 6598.03M, High = 6600M, Low = 6588.73M, Close = 6595.97M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="20 Dec 2017", Open = 6595.97M, High = 6602.01M, Low = 6588.17M, Close = 6602M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="21 Dec 2017", Open = 6602M, High = 6607M, Low = 6596.51M, Close = 6599.95M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="22 Dec 2017", Open = 6600.63M, High = 6601.21M, Low = 6590.39M, Close = 6591.02M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="23 Dec 2017", Open = 6591.02M, High = 6603.08M, Low = 6591M, Close = 6591M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="24 Dec 2017", Open = 6591M, High = 6601.32M, Low = 6585M, Close = 6592M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="25 Dec 2017", Open = 6593.13M, High = 6596.01M, Low = 6590M, Close = 6593.34M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="26 Dec 2017", Open = 6593.34M, High = 6604.76M, Low = 6582.63M, Close = 6593.86M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="27 Dec 2017", Open = 6593.86M, High = 6604.28M, Low = 6586.57M, Close = 6600.01M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="28 Dec 2017", Open = 6601.81M, High = 6603.21M, Low = 6592.78M, Close = 6596.25M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="29 Dec 2017", Open = 6596.25M, High = 6604.2M, Low = 6590M, Close = 6602.99M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="30 Dec 2017", Open = 6602.99M, High = 6606M, Low = 6584.99M, Close = 6587.81M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="31 Dec 2017", Open = 6587.81M, High = 6595M, Low = 6583.27M, Close = 6591.96M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="1 Jan 2018", Open = 6591.97M, High = 6596.07M, Low = 6585M, Close = 6588.39M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="2 Jan 2018", Open = 6587.6M, High = 6598.21M, Low = 6587.6M, Close = 6594.27M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="3 Jan 2018", Open = 6596.44M, High = 6601M, Low = 6590M, Close = 6596.55M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="4 Jan 2018", Open = 6598.91M, High = 6605M, Low = 6596.61M, Close = 6600.02M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="5 Jan 2018", Open = 6600.55M, High = 6605M, Low = 6589.14M, Close = 6593.01M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="6 Jan 2018", Open = 6593.15M, High = 6605M, Low = 6592M, Close = 6603.06M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="7 Jan 2018", Open = 6603.07M, High = 6604.5M, Low = 6599.09M, Close =6603.89M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="8 Jan 2018", Open = 6604.44M, High = 6604.44M, Low = 6600M, Close = 6603.5M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="9 Jan 2018", Open = 6603.5M, High = 6603.99M, Low = 6597.5M, Close = 6603.86M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="10 Jan 2018", Open = 6603.85M, High = 6605M, Low = 6600M, Close = 6604.07M });
            CandlestickAnnotationData.Add(new CandlestickAnnotationchart { AnnotationsDate ="11 Jan 2018", Open = 6604.98M, High = 6606M, Low = 6604.07M, Close = 6606M });
            return CandlestickAnnotationData;

        }
        public static List<CandlestickLinechart> GetCandlestickLineData()
        {
            var CandlestickLineData = new List<CandlestickLinechart>();
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="13 Nov 2017", Open = 6629.81M, High = 6650.5M, Low = 6623.04M, Close = 6633.33M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="14 Nov 2017", Open = 6632.01M, High = 6643.59M, Low = 6620M, Close = 6630.11M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="15 Nov 2017", Open = 6630.71M, High = 6648.95M, Low = 6623.34M, Close = 6635.65M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="16 Nov 2017", Open = 6635.65M, High = 6651M, Low = 6629.67M, Close = 6638.24M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="17 Nov 2017", Open = 6638.24M, High = 6640M, Low = 6620M, Close = 6624.47M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="18 Nov 2017", Open = 6624.53M, High = 6636.03M, Low = 6621.68M, Close = 6624.31M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="19 Nov 2017", Open = 6624.61M, High = 6632.2M, Low = 6617M, Close = 6626.02M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="20 Nov 2017", Open = 6627M, High = 6627.62M, Low = 6584.22M, Close = 6603.02M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="21 Nov 2017", Open = 6605M, High = 6608.03M, Low = 6598.95M, Close = 6604.01M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="22 Nov 2017", Open = 6604.5M, High = 6614.4M, Low = 6602.26M, Close = 6608.02M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="23 Nov 2017", Open = 6608.02M, High = 6610.68M, Low = 6601.99M, Close = 6608.91M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="24 Nov 2017", Open = 6608.91M, High = 6618.99M, Low = 6608.01M, Close = 6612M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="25 Nov 2017", Open = 6612M, High = 6615.13M, Low = 6605.09M, Close = 6612M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="26 Nov 2017", Open = 6612M, High = 6624.12M, Low = 6608.43M, Close = 6622.95M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="27 Nov 2017", Open = 6623.91M, High = 6623.91M, Low = 6615M, Close = 6615.67M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="28 Nov 2017", Open = 6618.69M, High = 6618.74M, Low = 6610M, Close = 6610.4M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="29 Nov 2017", Open = 6611M, High = 6622.78M, Low = 6610.4M, Close = 6614.9M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="30 Nov 2017", Open = 6614.9M, High = 6626.2M, Low = 6613.33M, Close = 6623.45M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="1 Dec 2017", Open = 6623.48M, High = 6627M, Low = 6618.38M, Close = 6620.35M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="2 Dec 2017", Open = 6619.43M, High = 6620.35M, Low = 6610.05M, Close = 6615.53M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="3 Dec 2017", Open = 6615.53M, High = 6617.93M, Low = 6610M, Close = 6615.19M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="4 Dec 2017", Open = 6615.19M, High = 6621.6M, Low = 6608.2M, Close = 6620M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="5 Dec 2017", Open = 6619.54M, High = 6625.17M, Low = 6614.15M, Close = 6620M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="6 Dec 2017", Open = 6620.33M, High = 6634.15M, Low = 6617.24M, Close = 6624.61M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="7 Dec 2017", Open = 6625.95M, High = 6626M, Low = 6611.66M, Close = 6617.58M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="8 Dec 2017", Open = 6619M, High = 6625.97M, Low = 6595.27M, Close = 6598.86M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="9 Dec 2017", Open = 6598.86M, High = 6598.88M, Low = 6570M, Close = 6587.16M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="10 Dec 2017", Open = 6588.86M, High = 6600M, Low = 6580M, Close = 6593.4M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="11 Dec 2017", Open = 6593.99M, High = 6598.89M, Low = 6585M, Close = 6587.81M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="12 Dec 2017", Open = 6587.81M, High = 6592.73M, Low = 6567.14M, Close = 6578M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="13 Dec 2017", Open = 6578.35M, High = 6581.72M, Low = 6567.39M, Close = 6579M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="14 Dec 2017", Open = 6579.38M, High = 6580.92M, Low = 6566.77M, Close = 6575.96M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="15 Dec 2017", Open = 6575.96M, High = 6589M, Low = 6571.77M, Close = 6588.92M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="16 Dec 2017", Open = 6588.92M, High = 6594M, Low = 6577.55M, Close = 6589.22M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="17 Dec 2017", Open = 6589.3M, High = 6598.89M, Low = 6589.1M, Close = 6596.08M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="18 Dec 2017", Open = 6597.5M, High = 6600M, Low = 6588.39M, Close = 6596.25M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="19 Dec 2017", Open = 6598.03M, High = 6600M, Low = 6588.73M, Close = 6595.97M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="20 Dec 2017", Open = 6595.97M, High = 6602.01M, Low = 6588.17M, Close = 6602M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="21 Dec 2017", Open = 6602M, High = 6607M, Low = 6596.51M, Close = 6599.95M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="22 Dec 2017", Open = 6600.63M, High = 6601.21M, Low = 6590.39M, Close = 6591.02M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="23 Dec 2017", Open = 6591.02M, High = 6603.08M, Low = 6591M, Close = 6591M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="24 Dec 2017", Open = 6591M, High = 6601.32M, Low = 6585M, Close = 6592M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="25 Dec 2017", Open = 6593.13M, High = 6596.01M, Low = 6590M, Close = 6593.34M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="26 Dec 2017", Open = 6593.34M, High = 6604.76M, Low = 6582.63M, Close = 6593.86M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="27 Dec 2017", Open = 6593.86M, High = 6604.28M, Low = 6586.57M, Close = 6600.01M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="28 Dec 2017", Open = 6601.81M, High = 6603.21M, Low = 6592.78M, Close = 6596.25M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="29 Dec 2017", Open = 6596.25M, High = 6604.2M, Low = 6590M, Close = 6602.99M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="30 Dec 2017", Open = 6602.99M, High = 6606M, Low = 6584.99M, Close = 6587.81M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="31 Dec 2017", Open = 6587.81M, High = 6595M, Low = 6583.27M, Close = 6591.96M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="1 Jan 2018", Open = 6591.97M, High = 6596.07M, Low = 6585M, Close = 6588.39M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="2 Jan 2018", Open = 6587.6M, High = 6598.21M, Low = 6587.6M, Close = 6594.27M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="3 Jan 2018", Open = 6596.44M, High = 6601M, Low = 6590M, Close = 6596.55M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="4 Jan 2018", Open = 6598.91M, High = 6605M, Low = 6596.61M, Close = 6600.02M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="5 Jan 2018", Open = 6600.55M, High = 6605M, Low = 6589.14M, Close = 6593.01M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="6 Jan 2018", Open = 6593.15M, High = 6605M, Low = 6592M, Close = 6603.06M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="7 Jan 2018", Open = 6603.07M, High = 6604.5M, Low = 6599.09M, Close =6603.89M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="8 Jan 2018", Open = 6604.44M, High = 6604.44M, Low = 6600M, Close = 6603.5M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="9 Jan 2018", Open = 6603.5M, High = 6603.99M, Low = 6597.5M, Close = 6603.86M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="10 Jan 2018", Open = 6603.85M, High = 6605M, Low = 6600M, Close = 6604.07M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="11 Jan 2018", Open = 6604.98M, High = 6606M, Low = 6604.07M, Close = 6606M });
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="13 Nov 2017", LinesValue = 6604M,});
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="15 Nov 2017", LinesValue = 6602M,});
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="3 Dec 2017", LinesValue = 6607M,});
            CandlestickLineData.Add(new CandlestickLinechart { LinesDate ="11 Jan 2018", LinesValue = 6620M,});
            return CandlestickLineData;
        }
    }
}