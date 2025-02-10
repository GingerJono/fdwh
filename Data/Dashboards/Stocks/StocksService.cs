using Sandbox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardModel;

namespace Stocks
{
    public class StocksService{
        private List<CryptoMainChart> StocksMainChartData = new List<CryptoMainChart>( )
        {
            new CryptoMainChart {CryptoIcon="bi bi-apple", CryptoIconClass="dark",CryptoTitle="Apple",CryptoSubTitle="AAPL",CryptoValue="$1,780.80",IsIncreased=true,Percentage="+0.14%"},
            new CryptoMainChart {CryptoIcon="bi bi-currency-bitcoin", CryptoIconClass="warning",CryptoTitle="Bitcoin",CryptoSubTitle="BTC",CryptoValue="$58,151.02",IsIncreased=false,Percentage="-2.14%"},
            new CryptoMainChart {CryptoIcon="bi bi-card-list", CryptoIconClass="primary1",CryptoTitle="Tesla",CryptoSubTitle="TSLA",CryptoValue="$4,125.63",IsIncreased=true,Percentage="+4.02%"},
            new CryptoMainChart {CryptoIcon="bi bi-gift", CryptoIconClass="primary2",CryptoTitle="Amazon",CryptoSubTitle="AMZN",CryptoValue="$63,251.11",IsIncreased=false,Percentage="-5.14%"},
            new CryptoMainChart {CryptoIcon="bi bi-truck", CryptoIconClass="primary3",CryptoTitle="Aliexpress",CryptoSubTitle="AE",CryptoValue="$5,401.50",IsIncreased=true,Percentage="+1.14%"},
            new CryptoMainChart {CryptoIcon="bi bi-phone", CryptoIconClass="secondary",CryptoTitle="Samsung",CryptoSubTitle="SSNLF",CryptoValue="$10,732.12",IsIncreased=true,Percentage="+2.14%"},
            new CryptoMainChart {CryptoIcon="bi bi-nvidia", CryptoIconClass="info",CryptoTitle="Nvidia",CryptoSubTitle="NVDA",CryptoValue="$23,235.25",IsIncreased=false,Percentage="-2.13%"},
        };
        public List<CryptoMainChart> GetStocksMainChart() => StocksMainChartData;
        public static List<StocksChart> GetStocksChart(CryptoMainChart MainCard)
        {
            var StocksChart = new List<StocksChart>();
            var sharedValues = new List<decimal> { 15, 42, 22, 42, 35, 32, 56, 35 };
           var titles = new List<string>
            {
                "Apple","Bitcoin","Tesla","Amazon","Aliexpress","Samsung","Nvidia",
            };
            var title = MainCard?.CryptoTitle;
            if (!string.IsNullOrEmpty(title) && titles.Contains(title))
            {
                for (int i = 0; i < sharedValues.Count; i++)
                {
                    StocksChart.Add(new StocksChart { Series = i + 1, Value = sharedValues[i] });
                }
            }
            return StocksChart;
        }
        public static List<Analysis> GetAnalysis() {
            var GrowthAnalysis = new List<Analysis>();
            GrowthAnalysis.Add(new Analysis { Week = "Mon", ThisWeek = 25, LastWeek = 35, });
            GrowthAnalysis.Add(new Analysis { Week = "Tue", ThisWeek = 50, LastWeek = 25, });
            GrowthAnalysis.Add(new Analysis { Week = "Wed", ThisWeek = 30, LastWeek = 40, });
            GrowthAnalysis.Add(new Analysis { Week = "Thu", ThisWeek = 55, LastWeek = 30, });
            GrowthAnalysis.Add(new Analysis { Week = "Fri", ThisWeek = 20, LastWeek = 45, });
            GrowthAnalysis.Add(new Analysis { Week = "Sat", ThisWeek = 45, LastWeek = 35, });
            GrowthAnalysis.Add(new Analysis { Week = "Sun", ThisWeek = 30, LastWeek = 60, });
            return GrowthAnalysis;
        }
        public static List<Statistics> GetStatisticss()
        {
           var statistics = new List<Statistics>();
            statistics.Add(new Statistics { Source = "Stocks", SourceValue = 1624 });
            statistics.Add(new Statistics { Source = "Funds", SourceValue = 1267 });
            statistics.Add(new Statistics { Source = "Bond", SourceValue = 1153 });
            return statistics;
        }
        public List<TimeSeries> GenerateDayWiseTimeSeries(DateTime startDate, int count, int min, int max)
        {
            var data = new List<TimeSeries>();
            var random = new Random();

            for (int i = 0; i < count; i++)
            {
                var currentDate = startDate.AddDays(i);
                var value = random.Next(min, max);
                data.Add(new TimeSeries { X = currentDate,Y = (double?)value});
            }

            return data;
        }
        private List<Watchlist> WatchlistData = new List<Watchlist>( )
        {
            new Watchlist {Source ="Apple",SourceIcon ="../assets/images/media/apps/apple.png",SourceClass ="dark",SourceSubTitle ="AAPL",SourceValue ="150.20",IsIncreased =true,Percentage ="+1.50%",},
            new Watchlist {Source ="Google",SourceIcon ="../assets/images/media/apps/google.png",SourceClass ="primary2",SourceSubTitle ="GOOG",SourceValue ="2,500.5",IsIncreased =false,Percentage ="-5.25%",},
            new Watchlist {Source ="Microsoft",SourceIcon ="../assets/images/media/apps/microsoft.png",SourceClass ="primary3",SourceSubTitle ="MSFT",SourceValue ="300.75",IsIncreased =true,Percentage ="+2.30%",},
            new Watchlist {Source ="Amazon",SourceIcon ="../assets/images/media/apps/amazon.png",SourceClass ="secondary",SourceSubTitle ="AMZN",SourceValue ="3,000.00",IsIncreased =false,Percentage ="-10.50%",},
            new Watchlist {Source ="Tesla",SourceIcon ="../assets/images/media/apps/tesla.png",SourceClass ="warning",SourceSubTitle ="TSLA",SourceValue ="700.80",IsIncreased =true,Percentage ="+8.00%",},
            new Watchlist {Source ="Facebook",SourceIcon ="../assets/images/media/apps/facebook.png",SourceClass ="info",SourceSubTitle ="FB",SourceValue ="350.40",IsIncreased =false,Percentage ="-3.20%",},
            new Watchlist {Source ="Nvidia",SourceIcon ="../assets/images/media/apps/nvidia.png",SourceClass ="success",SourceSubTitle ="NVDA",SourceValue ="800.60",IsIncreased =true,Percentage ="+5.75%",},
        };
        public List<Watchlist> GetWatchlist() => WatchlistData;
        public static List<StocksChart> GetWatchlistChart(Watchlist Watchlist)
        {
            var StocksChart = new List<StocksChart>();
            var sharedValues = new List<decimal> {  0, 45, 54, 38, 56, 24, 65, 31, 37, 39, 62, 51, 35, 41, 35, 27, 93, 53, 61, 27, 54, 43, 19, 46,};
           var titles = new List<string>
            {
                "Apple","Google","Microsoft","Amazon","Tesla","Facebook","Nvidia",
            };
            var title = Watchlist?.Source;
            if (!string.IsNullOrEmpty(title) && titles.Contains(title))
            {
                for (int i = 0; i < sharedValues.Count; i++)
                {
                    StocksChart.Add(new StocksChart { Series = i + 1, Value = sharedValues[i] });
                }
            }
            return StocksChart;
        }
        private List<Stockslist> StockslistData = new List<Stockslist>( )
        {
            new Stockslist {StockIcon="ri-github-fill",StockClass="primary",Stock="Gituhb, Demo Inc",StockSubTitle="GTHB",Quantity="100",Price="$145.20",IsIncreased=true,Change="+$1,230.00",StockValue="$14,520.00"},
            new Stockslist {StockIcon="ri-amazon-fill",StockClass="primary1",Stock="Amazon.com Inc.",StockSubTitle="AMZN",Quantity="50",Price="$3,500.00",IsIncreased=false,Change="-$5,500.00",StockValue="$175,000.00"},
            new Stockslist {StockIcon="ri-microsoft-fill",StockClass="primary2",Stock="Microsoft Corporation",StockSubTitle="MSFT",Quantity="75",Price="$265.75",IsIncreased=true,Change="+$876.25",StockValue="$19,931.25"},
            new Stockslist {StockIcon="ri-google-fill",StockClass="primary3",Stock="Alphabet Inc. (Google)",StockSubTitle="GOOGL",Quantity="30",Price="$2,550.00",IsIncreased=true,Change="+$1,800.00",StockValue="$76,500.00"},
            new Stockslist {StockIcon="ri-facebook-circle-fill",StockClass="info",Stock="Facebook, Inc.",StockSubTitle="FB",Quantity="60",Price="$325.60",IsIncreased=false,Change="-$364.00",StockValue="$19,536.00"},
        };
        public List<Stockslist> GetStockslist() => StockslistData;
        
        public TableText[] StockslistHeadersData = new TableText[]
        {
            new TableText { Title = "Stock"},
            new TableText { Title = "Quantity"},
            new TableText { Title = "Stock Price"},
            new TableText { Title = "Change"},
            new TableText { Title = "Total Value"},
            new TableText { Title = "Actions"},
        };        
        public TableText[] GetStockslistHeadersData() => StockslistHeadersData;        
        public TableText[] TransactionHeadersData = new TableText[]
        {
            new TableText { Title = "Date"},
            new TableText { Title = "Stock"},
            new TableText { Title = "Shares"},
            new TableText { Title = "Type"},
            new TableText { Title = "Price"},
            new TableText { Title = "Change"},
        };        
        public TableText[] GetTransactionHeadersData() => TransactionHeadersData;      
        public TableText[] MarketHeadersData = new TableText[]
        {
            new TableText { Title = "Symbol"},
            new TableText { Title = "Company Name"},
            new TableText { Title = "Change"},
            new TableText { Title = "Price"},
            new TableText { Title = "% Change"},
            new TableText { Title = "Volume"},
        };        
        public TableText[] GetMarketHeadersData() => MarketHeadersData;
        private List<Transactionlist> TransactionlistData = new List<Transactionlist>( )
        {
            new Transactionlist {StockImg ="../assets/images/media/apps/apple.png",StockClass ="dark",Stock ="APPL - Apple Inc.",Date ="12 Apr, 2024",Shares ="50",TransactionType =true,Price ="$150.00",PriceValue ="$7,500.00",IsIncreased =true,Change ="+2%",},
            new Transactionlist {StockImg ="../assets/images/media/apps/google.png",StockClass ="primary2",Stock ="GOOGL-Alphabet Inc..",Date ="14 Apr, 2024",Shares ="20",TransactionType =false,Price ="$2,400.00",PriceValue ="$48,000.00",IsIncreased =false,Change ="-1.5%",},
            new Transactionlist {StockImg ="../assets/images/media/apps/tesla.png",StockClass ="warning",Stock ="TSLA - Tesla Inc.",Date ="18 Apr, 2024",Shares ="15",TransactionType =true,Price ="$650.00",PriceValue ="$9,750.00",IsIncreased =true,Change ="+1.2%",},
            new Transactionlist {StockImg ="../assets/images/media/apps/microsoft.png",StockClass ="primary3",Stock ="MSFT - Microsoft Corp.",Date ="20 Apr, 2024",Shares ="30",TransactionType =false,Price ="$280.00",PriceValue ="$8,400.00",IsIncreased =false,Change ="-0.8%",},
            new Transactionlist {StockIcon ="ri-netflix-line",StockClass ="danger",Stock ="NFLX - Netflix Inc.",Date ="22 Apr, 2024",Shares ="25",TransactionType =true,Price ="$500.00",PriceValue ="$12,500.00",IsIncreased =true,Change ="+0.5%",},
        };
        public List<Transactionlist> GetTransactionlist() => TransactionlistData;
        private List<MarketList> MarketListData = new List<MarketList>( )
        {
            new MarketList {Symbol="AAPL",Market="Apple Inc.",IsIncreased=true,Change="$5.00",Price="$150.00",Changepercentage="+3.45%",Volume="1,000,000"},
            new MarketList {Symbol="GOOGL",Market="Alphabet Inc.",IsIncreased=false,Change="-$10.00",Price="$2,500.00",Changepercentage="-0.40%",Volume="500,000"},
            new MarketList {Symbol="MSFT",Market="Microsoft Corporation",IsIncreased=true,Change="$3.00",Price="$300.00",Changepercentage="+1.01%",Volume="800,000"},
            new MarketList {Symbol="TSLA",Market="Tesla, Inc.",IsIncreased=true,Change="$20.00",Price="$700.00",Changepercentage="+2.94%",Volume="1,200,000"},
            new MarketList {Symbol="NFLX",Market="Netflix, Inc.",IsIncreased=false,Change="-$5.00",Price="$400.00",Changepercentage="-1.23%",Volume="600,000"},
            new MarketList {Symbol="AMZN",Market="Amazon.com, Inc.",IsIncreased=true,Change="$50.00",Price="$3,000.00",Changepercentage="+1.69%",Volume="1,500,000"},
            new MarketList {Symbol="FB",Market="Facebook.com, Inc.",IsIncreased=true,Change="$24.00",Price="$6,000.00",Changepercentage="+2.08%",Volume="2,258,450"},
        };
        public List<MarketList> GetMarketList() => MarketListData;


    }
}
