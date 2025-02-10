
namespace ScatterData
{
    public class Scatterbasicchart
    {
        public decimal SAMPLEDATA { get; set; }
        public decimal SAMPLEA { get; set; }
        public decimal SAMPLEB { get; set; }
        public decimal SAMPLEC { get; set; }
    }
    public class TimeSeries
    {
        public long DateMilliseconds => Date.ToUnixTimeMilliseconds();
        public DateTimeOffset Date { get; set; }
        public decimal Value { get; set; }
        public decimal Value2 { get; set; }
        public int Value3 { get; set; }
        public int Value4 { get; set; }
        public int Value5 { get; set; }
    }
    public class ScatterImagechart
    {
        public decimal SocailData { get; set; }
        public decimal Messenger { get; set; }
        public decimal Instagram { get; set; }
    }
    public class ScatterService {
        
        public static List<Scatterbasicchart> GetScatterbasiccharts()
        {
            return new List<Scatterbasicchart>
            {
                new Scatterbasicchart { SAMPLEDATA = 16.4M, SAMPLEA =  5.4M},
                new Scatterbasicchart { SAMPLEDATA = 21.7M, SAMPLEA =  2.0M},
                new Scatterbasicchart { SAMPLEDATA = 25.4M, SAMPLEA =  3.0M},
                new Scatterbasicchart { SAMPLEDATA = 19.0M, SAMPLEA =  2.0M},
                new Scatterbasicchart { SAMPLEDATA = 10.9M, SAMPLEA =  1.0M},
                new Scatterbasicchart { SAMPLEDATA = 13.6M, SAMPLEA =  3.2M},
                new Scatterbasicchart { SAMPLEDATA = 10.9M, SAMPLEA =  7.4M},
                new Scatterbasicchart { SAMPLEDATA = 10.9M, SAMPLEA =  0.0M},
                new Scatterbasicchart { SAMPLEDATA = 10.9M, SAMPLEA =  8.2M},
                new Scatterbasicchart { SAMPLEDATA = 16.4M, SAMPLEA =  0.0M},
                new Scatterbasicchart { SAMPLEDATA = 16.4M, SAMPLEA =  1.8M},
                new Scatterbasicchart { SAMPLEDATA = 13.6M, SAMPLEA =  0.3M},
                new Scatterbasicchart { SAMPLEDATA = 13.6M, SAMPLEA =  0.0M},
                new Scatterbasicchart { SAMPLEDATA = 29.9M, SAMPLEA =  0.0M},
                new Scatterbasicchart { SAMPLEDATA = 27.1M, SAMPLEA =  2.3M},
                new Scatterbasicchart { SAMPLEDATA = 16.4M, SAMPLEA =  0.0M},
                new Scatterbasicchart { SAMPLEDATA = 13.6M, SAMPLEA =  3.7M},
                new Scatterbasicchart { SAMPLEDATA = 10.9M, SAMPLEA =  5.2M},
                new Scatterbasicchart { SAMPLEDATA = 16.4M, SAMPLEA =  6.5M},
                new Scatterbasicchart { SAMPLEDATA = 10.9M, SAMPLEA =  0.0M},
                new Scatterbasicchart { SAMPLEDATA = 24.5M, SAMPLEA =  7.1M},
                new Scatterbasicchart { SAMPLEDATA = 10.9M, SAMPLEA =  0.0M},
                new Scatterbasicchart { SAMPLEDATA = 8.1M, SAMPLEA =  4.7M},
                new Scatterbasicchart { SAMPLEDATA = 19.0M, SAMPLEA =  0.0M},
                new Scatterbasicchart { SAMPLEDATA = 21.7M, SAMPLEA =  1.8M},
                new Scatterbasicchart { SAMPLEDATA = 27.1M, SAMPLEA =  0.0M},
                new Scatterbasicchart { SAMPLEDATA = 24.5M, SAMPLEA =  0.0M},
                new Scatterbasicchart { SAMPLEDATA = 27.1M, SAMPLEA =  0.0M},
                new Scatterbasicchart { SAMPLEDATA = 29.9M, SAMPLEA =  1.5M},
                new Scatterbasicchart { SAMPLEDATA = 27.1M, SAMPLEA =  0.8M},
                new Scatterbasicchart { SAMPLEDATA = 22.1M, SAMPLEA =  2.0M},         
                new Scatterbasicchart { SAMPLEDATA = 36.4M, SAMPLEB =  13.4M},
                new Scatterbasicchart { SAMPLEDATA = 1.7M, SAMPLEB =  11.0M},
                new Scatterbasicchart { SAMPLEDATA = 5.4M, SAMPLEB =  8.0M},
                new Scatterbasicchart { SAMPLEDATA = 9.0M, SAMPLEB =  17.0M},
                new Scatterbasicchart { SAMPLEDATA = 1.9M, SAMPLEB =  4.0M},
                new Scatterbasicchart { SAMPLEDATA = 3.6M, SAMPLEB =  12.2M},
                new Scatterbasicchart { SAMPLEDATA = 1.9M, SAMPLEB =  14.4M},
                new Scatterbasicchart { SAMPLEDATA = 1.9M, SAMPLEB =  9.0M},
                new Scatterbasicchart { SAMPLEDATA = 1.9M, SAMPLEB =  13.2M},
                new Scatterbasicchart { SAMPLEDATA = 1.4M, SAMPLEB =  7.0M},
                new Scatterbasicchart { SAMPLEDATA = 6.4M, SAMPLEB =  8.8M},
                new Scatterbasicchart { SAMPLEDATA = 3.6M, SAMPLEB =  4.3M},
                new Scatterbasicchart { SAMPLEDATA = 1.6M, SAMPLEB =  10.0M},
                new Scatterbasicchart { SAMPLEDATA = 9.9M, SAMPLEB =  2.0M},
                new Scatterbasicchart { SAMPLEDATA = 7.1M, SAMPLEB =  15.0M},
                new Scatterbasicchart { SAMPLEDATA = 1.4M, SAMPLEB =  0.0M},
                new Scatterbasicchart { SAMPLEDATA = 3.6M, SAMPLEB =  13.7M},
                new Scatterbasicchart { SAMPLEDATA = 1.9M, SAMPLEB =  15.2M},
                new Scatterbasicchart { SAMPLEDATA = 6.4M, SAMPLEB =  16.5M},
                new Scatterbasicchart { SAMPLEDATA = 0.9M, SAMPLEB =  10.0M},
                new Scatterbasicchart { SAMPLEDATA = 4.5M, SAMPLEB =  17.1M},
                new Scatterbasicchart { SAMPLEDATA = 10.9M, SAMPLEB =  10.0M},
                new Scatterbasicchart { SAMPLEDATA = 0.1M, SAMPLEB =  14.7M},
                new Scatterbasicchart { SAMPLEDATA = 9.0M, SAMPLEB =  10.0M},
                new Scatterbasicchart { SAMPLEDATA = 12.7M, SAMPLEB =  11.8M},
                new Scatterbasicchart { SAMPLEDATA = 2.1M, SAMPLEB =  10.0M},
                new Scatterbasicchart { SAMPLEDATA = 2.5M, SAMPLEB =  10.0M},
                new Scatterbasicchart { SAMPLEDATA = 27.1M, SAMPLEB =  10.0M},
                new Scatterbasicchart { SAMPLEDATA = 2.9M, SAMPLEB =  11.5M},
                new Scatterbasicchart { SAMPLEDATA = 7.1M, SAMPLEB =  10.8M},
                new Scatterbasicchart { SAMPLEDATA = 2.1M, SAMPLEB =  12.0M},
                new Scatterbasicchart { SAMPLEDATA = 21.7M, SAMPLEC = 3.0M},
                new Scatterbasicchart { SAMPLEDATA = 23.6M, SAMPLEC = 3.5M},
                new Scatterbasicchart { SAMPLEDATA = 24.6M, SAMPLEC = 3.0M},
                new Scatterbasicchart { SAMPLEDATA = 29.9M, SAMPLEC = 3.0M},
                new Scatterbasicchart { SAMPLEDATA = 21.7M, SAMPLEC = 20.0M},
                new Scatterbasicchart { SAMPLEDATA = 23.0M, SAMPLEC = 2.0M},
                new Scatterbasicchart { SAMPLEDATA = 10.9M, SAMPLEC = 3.0M},
                new Scatterbasicchart { SAMPLEDATA = 28.0M, SAMPLEC = 4.0M},
                new Scatterbasicchart { SAMPLEDATA = 27.1M, SAMPLEC = 0.3M},
                new Scatterbasicchart { SAMPLEDATA = 16.4M, SAMPLEC = 4.0M},
                new Scatterbasicchart { SAMPLEDATA = 13.6M, SAMPLEC = 0.0M},
                new Scatterbasicchart { SAMPLEDATA = 19.0M, SAMPLEC = 5.0M},
                new Scatterbasicchart { SAMPLEDATA = 22.4M, SAMPLEC = 3.0M},
                new Scatterbasicchart { SAMPLEDATA = 24.5M, SAMPLEC = 3.0M},
                new Scatterbasicchart { SAMPLEDATA = 32.6M, SAMPLEC = 3.0M},
                new Scatterbasicchart { SAMPLEDATA = 27.1M, SAMPLEC = 4.0M},
                new Scatterbasicchart { SAMPLEDATA = 29.6M, SAMPLEC = 6.0M},
                new Scatterbasicchart { SAMPLEDATA = 31.6M, SAMPLEC = 8.0M},
                new Scatterbasicchart { SAMPLEDATA = 21.6M, SAMPLEC = 5.0M},
                new Scatterbasicchart { SAMPLEDATA = 20.9M, SAMPLEC = 4.0M},
                new Scatterbasicchart { SAMPLEDATA = 22.4M, SAMPLEC = 0.0M},
                new Scatterbasicchart { SAMPLEDATA = 32.6M, SAMPLEC = 10.3M},
                new Scatterbasicchart { SAMPLEDATA = 29.7M, SAMPLEC = 20.8M},
                new Scatterbasicchart { SAMPLEDATA = 24.5M, SAMPLEC = 0.8M},
                new Scatterbasicchart { SAMPLEDATA = 21.4M, SAMPLEC = 0.0M},
                new Scatterbasicchart { SAMPLEDATA = 21.7M, SAMPLEC = 6.9M},
                new Scatterbasicchart { SAMPLEDATA = 28.6M, SAMPLEC = 7.7M},
                new Scatterbasicchart { SAMPLEDATA = 15.4M, SAMPLEC = 0.0M},
                new Scatterbasicchart { SAMPLEDATA = 18.1M, SAMPLEC = 0.0M},
                new Scatterbasicchart { SAMPLEDATA = 33.4M, SAMPLEC = 0.0M},
                new Scatterbasicchart { SAMPLEDATA = 16.4M, SAMPLEC = 0.0M},
            };
        }
        public static List<ScatterImagechart> GetScatterImagecharts()
        {
            return new List<ScatterImagechart>
            {
                new ScatterImagechart { SocailData = 16.4M, Messenger = 5.4M},
                new ScatterImagechart { SocailData = 21.7M, Messenger = 4M},
                new ScatterImagechart { SocailData = 25.4M, Messenger = 3M},
                new ScatterImagechart { SocailData = 19M,   Messenger = 2M},
                new ScatterImagechart { SocailData = 10.9M, Messenger = 1M},
                new ScatterImagechart { SocailData = 13.6M, Messenger = 3.2M},
                new ScatterImagechart { SocailData = 10.9M, Messenger = 7M},
                new ScatterImagechart { SocailData = 10.9M, Messenger = 8.2M},
                new ScatterImagechart { SocailData = 16.4M, Messenger = 4M},
                new ScatterImagechart { SocailData = 13.6M, Messenger = 4.3M},
                new ScatterImagechart { SocailData = 13.6M, Messenger = 12M},
                new ScatterImagechart { SocailData = 29.9M, Messenger = 3M},
                new ScatterImagechart { SocailData = 10.9M, Messenger = 5.2M},
                new ScatterImagechart { SocailData = 16.4M, Messenger = 6.5M},
                new ScatterImagechart { SocailData = 10.9M, Messenger = 8M},
                new ScatterImagechart { SocailData = 24.5M, Messenger = 7.1M},
                new ScatterImagechart { SocailData = 10.9M, Messenger = 7M},
                new ScatterImagechart { SocailData = 8.1M, Messenger = 4.7M},
                new ScatterImagechart { SocailData = 19M, Messenger = 10M},
                new ScatterImagechart { SocailData = 27.1M, Messenger = 10M},
                new ScatterImagechart { SocailData = 24.5M, Messenger = 8M},
                new ScatterImagechart { SocailData = 27.1M, Messenger = 3M},
                new ScatterImagechart { SocailData = 29.9M, Messenger = 11.5M},
                new ScatterImagechart { SocailData = 27.1M, Messenger = 0.8M},
                new ScatterImagechart { SocailData = 22.1M, Messenger = 2M},
            };
        }
    }
}