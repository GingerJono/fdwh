
namespace MixedChartData
{
    public class Mixedbasic {
        public string? TrafficDate { get; set; }
        public decimal WebsiteValue { get; set; }
        public decimal MediaValue { get; set; }
    } ;
    public class MixedMultiple {
        public string? StocksYear { get; set; }
        public decimal IncomeValue { get; set; }
        public decimal CashflowValue { get; set; }
        public decimal RevenueValue { get; set; }
    } ;
    public class MixedLinearea {
        public string? TeamValue { get; set; }
        public decimal TeamAValue { get; set; }
        public decimal TeamBValue { get; set; }
    } ;
    public class MixedAll {
        public string? TEAMMixedValue { get; set; }
        public decimal TEAMAMixedValue { get; set; }
        public decimal TEAMBMixedValue { get; set; }
        public decimal TEAMCMixedValue { get; set; }
    } ;

    public class MixedChartService {
        public static List<Mixedbasic> GetMixedbasics() {
            var Mixedbasics = new List<Mixedbasic>();
            Mixedbasics.Add(new Mixedbasic { TrafficDate = "01 Jan 2001" , WebsiteValue = 440 , MediaValue = 23 });
            Mixedbasics.Add(new Mixedbasic { TrafficDate = "02 Jan 2001" , WebsiteValue = 505 , MediaValue = 42 });
            Mixedbasics.Add(new Mixedbasic { TrafficDate = "03 Jan 2001" , WebsiteValue = 414 , MediaValue = 35 });
            Mixedbasics.Add(new Mixedbasic { TrafficDate = "04 Jan 2001" , WebsiteValue = 671 , MediaValue = 27 });
            Mixedbasics.Add(new Mixedbasic { TrafficDate = "05 Jan 2001" , WebsiteValue = 227 , MediaValue = 43 });
            Mixedbasics.Add(new Mixedbasic { TrafficDate = "06 Jan 2001" , WebsiteValue = 413 , MediaValue = 22 });
            Mixedbasics.Add(new Mixedbasic { TrafficDate = "07 Jan 2001" , WebsiteValue = 201 , MediaValue = 17 });
            Mixedbasics.Add(new Mixedbasic { TrafficDate = "08 Jan 2001" , WebsiteValue = 352 , MediaValue = 31 });
            Mixedbasics.Add(new Mixedbasic { TrafficDate = "09 Jan 2001" , WebsiteValue = 752 , MediaValue = 22 });
            Mixedbasics.Add(new Mixedbasic { TrafficDate = "10 Jan 2001" , WebsiteValue = 320 , MediaValue = 22 });
            Mixedbasics.Add(new Mixedbasic { TrafficDate = "11 Jan 2001" , WebsiteValue = 257 , MediaValue = 12 });
            Mixedbasics.Add(new Mixedbasic { TrafficDate = "12 Jan 2001" , WebsiteValue = 160 , MediaValue = 16 });
            return Mixedbasics;
        }
        public static List<MixedMultiple> GetMixedMultiples() {
            var MixedMultiples = new List<MixedMultiple>();
            MixedMultiples.Add(new MixedMultiple { StocksYear = "2009" , IncomeValue = 1.4M , CashflowValue = 1.1M , RevenueValue = 20 });
            MixedMultiples.Add(new MixedMultiple { StocksYear = "2010" , IncomeValue = 2.0M , CashflowValue = 3.0M , RevenueValue = 29 });
            MixedMultiples.Add(new MixedMultiple { StocksYear = "2011" , IncomeValue = 2.5M , CashflowValue = 3.1M , RevenueValue = 37 });
            MixedMultiples.Add(new MixedMultiple { StocksYear = "2012" , IncomeValue = 1.5M , CashflowValue = 4.0M , RevenueValue = 36 });
            MixedMultiples.Add(new MixedMultiple { StocksYear = "2013" , IncomeValue = 2.5M , CashflowValue = 4.1M , RevenueValue = 44 });
            MixedMultiples.Add(new MixedMultiple { StocksYear = "2014" , IncomeValue = 2.8M , CashflowValue = 4.9M , RevenueValue = 45 });
            MixedMultiples.Add(new MixedMultiple { StocksYear = "2015" , IncomeValue = 3.8M , CashflowValue = 6.5M , RevenueValue = 50 });
            MixedMultiples.Add(new MixedMultiple { StocksYear = "2016" , IncomeValue = 4.6M , CashflowValue = 8.5M , RevenueValue = 58 });
            return MixedMultiples;
        }
        public static List<MixedLinearea> GetMixedLineareas() {
            var MixedLineareas = new List<MixedLinearea>();
            MixedLineareas.Add(new MixedLinearea { TeamValue = "Dec 01" , TeamAValue = 44,TeamBValue = 55 });
            MixedLineareas.Add(new MixedLinearea { TeamValue = "Dec 02" , TeamAValue = 55,TeamBValue = 69 });
            MixedLineareas.Add(new MixedLinearea { TeamValue = "Dec 03" , TeamAValue = 31,TeamBValue = 45 });
            MixedLineareas.Add(new MixedLinearea { TeamValue = "Dec 04" , TeamAValue = 47,TeamBValue = 61 });
            MixedLineareas.Add(new MixedLinearea { TeamValue = "Dec 05" , TeamAValue = 31,TeamBValue = 43 });
            MixedLineareas.Add(new MixedLinearea { TeamValue = "Dec 06" , TeamAValue = 43,TeamBValue = 54 });
            MixedLineareas.Add(new MixedLinearea { TeamValue = "Dec 07" , TeamAValue = 26,TeamBValue = 37 });
            MixedLineareas.Add(new MixedLinearea { TeamValue = "Dec 08" , TeamAValue = 41,TeamBValue = 52 });
            MixedLineareas.Add(new MixedLinearea { TeamValue = "Dec 09" , TeamAValue = 31,TeamBValue = 44 });
            MixedLineareas.Add(new MixedLinearea { TeamValue = "Dec 10" , TeamAValue = 47,TeamBValue = 61 });
            MixedLineareas.Add(new MixedLinearea { TeamValue = "Dec 11" , TeamAValue = 33,TeamBValue = 43 });
            return MixedLineareas;
        } 
        public static List<MixedAll> GetMixedAlls(){
            var MixedAlls = new List<MixedAll>();
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "01/01/2003" , TEAMAMixedValue = 23 , TEAMBMixedValue = 44 , TEAMCMixedValue = 30 });
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "02/01/2003" , TEAMAMixedValue = 11 , TEAMBMixedValue = 55 , TEAMCMixedValue = 25 });
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "03/01/2003" , TEAMAMixedValue = 22 , TEAMBMixedValue = 41 , TEAMCMixedValue = 36 });
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "04/01/2003" , TEAMAMixedValue = 27 , TEAMBMixedValue = 67 , TEAMCMixedValue = 30 });
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "05/01/2003" , TEAMAMixedValue = 13 , TEAMBMixedValue = 22 , TEAMCMixedValue = 45 });
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "06/01/2003" , TEAMAMixedValue = 22 , TEAMBMixedValue = 43 , TEAMCMixedValue = 35 });
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "07/01/2003" , TEAMAMixedValue = 37 , TEAMBMixedValue = 21 , TEAMCMixedValue = 64 });
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "08/01/2003" , TEAMAMixedValue = 21 , TEAMBMixedValue = 41 , TEAMCMixedValue = 52 });
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "09/01/2003" , TEAMAMixedValue = 44 , TEAMBMixedValue = 56 , TEAMCMixedValue = 59 });
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "10/01/2003" , TEAMAMixedValue = 22 , TEAMBMixedValue = 27 , TEAMCMixedValue = 36 });
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "11/01/2003" , TEAMAMixedValue = 30 , TEAMBMixedValue = 43 , TEAMCMixedValue = 39 });
            return MixedAlls;
        }
    }
}