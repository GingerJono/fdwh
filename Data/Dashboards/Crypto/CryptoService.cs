using Sandbox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardModel;

namespace Crypto
{
    public class CryptoService{
        private List<CryptoMainChart> CryptoMainChartData = new List<CryptoMainChart>( )
        {
            new CryptoMainChart {CryptoImg="../assets/images/crypto-currencies/crypto-icons/bitcoin-btc-logo.svg",CryptoTitle="Bitcoin",CryptoSubTitle="BTC",CryptoValue="134.56",CryptoUsd="18,574.58",IsIncreased=true,Percentage="+0.57%"},

            new CryptoMainChart {CryptoImg="../assets/images/crypto-currencies/crypto-icons/binance-usd-busd-logo.svg",CryptoTitle="Binanace",CryptoSubTitle="BNB",CryptoValue="578.05 ",CryptoUsd="26,478.09 ",IsIncreased=false,Percentage="-0.12%"},
            
            new CryptoMainChart {CryptoImg="../assets/images/crypto-currencies/crypto-icons/cardano-ada-logo.svg",CryptoTitle="Cardano",CryptoSubTitle="ADA",CryptoValue="324.06",CryptoUsd="13,124.02",IsIncreased=true,Percentage="+0.12%"},

            new CryptoMainChart {CryptoImg="../assets/images/crypto-currencies/crypto-icons/ethereum-eth-logo.svg",CryptoTitle="Ethereum",CryptoSubTitle="ETH",CryptoValue="245.15",CryptoUsd="27,684.05",IsIncreased=true,Percentage="+0.15%"},

            new CryptoMainChart {CryptoImg="../assets/images/crypto-currencies/crypto-icons/tether-usdt-logo.svg" ,CryptoTitle="Tether",CryptoSubTitle="USDT",CryptoValue="297.01",CryptoUsd="26,478.09",IsIncreased=true,Percentage="+1.15%"},

            new CryptoMainChart {CryptoImg="../assets/images/crypto-currencies/crypto-icons/xrp-xrp-logo.svg" ,CryptoTitle="Ripple",CryptoSubTitle="XRP",CryptoValue="789.45",CryptoUsd="14,872.03",IsIncreased=false,Percentage="-0.16%"},

            new CryptoMainChart {CryptoImg="../assets/images/crypto-currencies/crypto-icons/solana-sol-logo.svg",CryptoTitle="Solana",CryptoSubTitle="SOL",CryptoValue="245.15",CryptoUsd="18,784.05",IsIncreased=true,Percentage="+0.15%"},
        };
        public List<CryptoMainChart> GetCryptoMainChart() => CryptoMainChartData;
        public static List<CryptoChart> GetCryptoChart(CryptoMainChart MainCard)
        {
            var cryptoChart = new List<CryptoChart>();
            var sharedValues = new List<decimal> { 5, 4, 3, 8, 5, 6, 3, 8, 6, 9, 5, 7, 3, 8 };
           var titles = new List<string>
            {
                "Bitcoin","Binanace","Cardano","Ethereum","Tether","Ripple","Solana",
            };
            var title = MainCard?.CryptoTitle;
            if (!string.IsNullOrEmpty(title) && titles.Contains(title))
            {
                for (int i = 0; i < sharedValues.Count; i++)
                {
                    cryptoChart.Add(new CryptoChart { Series = i + 1, Value = sharedValues[i] });
                }
            }
            return cryptoChart;
        }
        public TableText[] PortfolioHeadersData = new TableText[]{
            new TableText { Title = "#" },
            new TableText { Title = "Coin" },
            new TableText { Title = "Price" },
            new TableText { Title = "Price Graph" },
            new TableText { Title = "24h Volume" },
            new TableText { Title = "24h Change" },
            new TableText { Title = "Market Cap" },
            new TableText { Title = "Actions" },
        };        
        public TableText[] GetPortfolioHeadersData() => PortfolioHeadersData;
        private List<Portfolio> CryptoPortfolioData = new List<Portfolio>(){
            new Portfolio {Id=1,CoinImg="../assets/images/crypto-currencies/crypto-icons/bitcoin-btc-logo.svg",Coin="Bitcoin - BTC", Price="34,283.53" ,Volume="21,457.02M", IsIncreased=true,Change="39.23%",MarketCap="669,649,033,571"},
            new Portfolio {Id=2,CoinImg="../assets/images/crypto-currencies/crypto-icons/ethereum-eth-logo.svg",Coin="Etherium - ETH", Price="1,800.81" ,Volume="11,784.22M",IsIncreased=false,Change="58.63%",MarketCap="216,466,869,907"},
            new Portfolio {Id=3,CoinImg="../assets/images/crypto-currencies/crypto-icons/tether-usdt-logo.svg",Coin="Tether - USDT", Price="1.00" ,Volume="33,874.25M",IsIncreased=true,Change="49.30%",MarketCap="84,641,938,780"},
            new Portfolio {Id=4,CoinImg="../assets/images/crypto-currencies/crypto-icons/solana-sol-logo.svg",Coin="Solana - SOL", Price="35.97" ,Volume="33,749.56M",IsIncreased=false,Change="144.58%",MarketCap="15,083,616,607"},
            new Portfolio {Id=5,CoinImg="../assets/images/crypto-currencies/crypto-icons/cardano-ada-logo.svg",Coin="Cardano - ADA", Price="0.3008" ,Volume="89,554.62M",IsIncreased=false,Change="51.15%",MarketCap="10,600,249,889"},
            new Portfolio {Id=6,CoinImg="../assets/images/crypto-currencies/crypto-icons/binance-usd-busd-logo.svg",Coin="Binance - BNB", Price="227.36" ,Volume="65,547.15M",IsIncreased=true,Change="25.85%",MarketCap="34,488,924,548"},
        };
        public List<Portfolio> GetCryptoPortfolioData() => CryptoPortfolioData;
        public static List<PortfolioChart> GetCryptoPortfolioChart(Portfolio MainCard)
        {
            var cryptoPortfolioChart = new List<PortfolioChart>();
            var valuesMap = new Dictionary<string, List<decimal>>
            {
                { "Bitcoin - BTC", new List<decimal>  {0,45,54,38,56,24,65,31,37,39,62,51,35,41,35,27,93,53,61,27,54,43,19,46,} },
                { "Etherium - ETH", new List<decimal> {0,45,54,38,56,24,65,35,27,93,53,61,27,54,43,19,46,31,37,39,62,51,35,41,} },
                { "Tether - USDT", new List<decimal>  {61,27,54,43,19,46,31,37,39,0,45,54,38,56,24,65,35,27,93,53,62,51,35,41,} },
                { "Solana - SOL", new List<decimal>   {61,27,54,43,19,56,24,65,35,27,93,53,46,31,37,39,0,45,54,38,62,51,35,41,} },
                { "Cardano - ADA", new List<decimal>  {61,27,54,37,39,0,45,54,38,62,51,35,41,43,19,56,24,65,35,27,93,53,46,31,} },
                { "Binance - BNB", new List<decimal>  {62,51,35,41,43,19,56,24,65,35,27,93,53,46,31,61,27,54,37,39,0,45,54,38 } }
            };
            var title = MainCard?.Coin;
             if (!string.IsNullOrEmpty(title) && valuesMap.ContainsKey(title))
            {
                var values = valuesMap[title];
                for (int i = 0; i < values.Count; i++)
                {
                    cryptoPortfolioChart.Add(new PortfolioChart { Series = i + 1, Value = values[i] });
                }
            }
            return cryptoPortfolioChart;
        }
        
        private List<MarketCapList> MarketCapData = new List<MarketCapList>( )
        {
            new MarketCapList {AvatarIcon="<svg xmlns='http://www.w3.org/2000/svg' height='28' width='28' viewBox='0 0 128 128'><path d='M64 128C28.7 128 0 99.3 0 64S28.7 0 64 0s64 28.7 64 64-28.7 64-64 64z'></path><path fill='#fff' d='M94.3 71.4c-.5-3.6-2.3-6.4-5.4-8.2-1.4-.8-3.1-1.4-4.7-2.1.2-.1.3-.3.4-.3 7.9-4.1 7.2-16.3 1.5-20.5-2.3-1.7-4.9-2.8-7.7-3.4-2-.4-3.9-.7-6-1.1 0-3.5.1-8.5.1-12.4H65c0 3.8-.1 8.7-.1 12.1H59c0-3.5 0-8.3.1-12.1h-7.4c0 4-.1 8.8-.1 12.3-5.1 0-10-.1-15-.1 0 2.7 0 5.3-.1 7.9h3c.9 0 1.9 0 2.8.1 2.6.2 3.9 1.6 3.9 4.2l-.3 31.9c0 2.3-1 3.3-3.3 3.3h-5c-.5 3-1 5.9-1.6 8.9 5 .1 10 .1 15 .2 0 3.8 0 8.7-.1 12.7h7.4c0-4 .1-8.7.1-12.5 2.1.1 4 .1 5.9.2 0 3.8-.1 8.4-.1 12.3h7.4c0-4 .1-8.7.1-12.4.3 0 .5-.1.6-.1 3.5-.6 7.2-.9 10.6-1.7 4.5-1.1 8.1-3.7 9.9-8.2 1.7-3.6 2-7.2 1.5-11zM59 44.3c4.6 0 9.1-.4 13.4 1.5 2.8 1.2 4.2 3.5 4 6.3-.2 2.9-1.9 5-4.8 6-4.1 1.3-8.3 1.3-12.7 1.1 0-5 .1-9.8.1-14.9zm16.2 37.1c-4.1 1.8-8.5 1.8-12.8 1.9-1.2 0-2.4-.1-3.8-.1.1-5.5.1-10.9.2-16.4 5.6 0 11.2-.4 16.5 1.9 2.7 1.2 4.3 3.3 4.3 6.4 0 3.1-1.6 5.1-4.4 6.3z'></path></svg>" ,AvatarColor="primary",Coin="Bitcoin",Coinvalue="BTC",Value="15" ,Amount="18,907.01",IsIncreased=true,IncreasedValue="+1,30.90",Increasedpercentage="2.9%"},
            
            new MarketCapList {AvatarIcon="<svg xmlns='http://www.w3.org/2000/svg' height='28' width='28' viewBox='0 0 128 128'><path d='M64 128C28.7 128 0 99.3 0 64S28.7 0 64 0s64 28.7 64 64-28.7 64-64 64z'></path><path fill='#fff' d='M65.2 87.2v22.7l28.1-39.5zM92.3 63.1l-27.1-45v32.7zM65.2 53.3v28l26.9-15.7zM35.8 63.1l27-45v32.7zM62.8 53.3v28L35.9 65.6zM62.8 87.2v22.7L34.7 70.4z'></path></svg>" ,AvatarColor="secondary",Coin="Ethereum",Coinvalue="ETH",Value="11" ,Amount="15,135.25",IsIncreased=true,IncreasedValue="+1,07.09",Increasedpercentage="3.0%"},
            
            new MarketCapList {AvatarIcon="<svg xmlns='http://www.w3.org/2000/svg' height='28' width='28' viewBox='0 0 128 128'><path d='M64 128C28.7 128 0 99.3 0 64S28.7 0 64 0s64 28.7 64 64-28.7 64-64 64z'></path><path fill='#fff' d='M20.8 89.3c1.4-4.1 2.7-7.9 4.1-11.8.1-.4.9-.7 1.3-.7 2.3-.1 4.7 0 7 0H79c1.2 0 1.8-.4 2.1-1.5 2.5-7.5 5.2-15 7.8-22.5.1-.4.2-.8.4-1.4H33.8c1.4-4.2 2.8-8.1 4.1-12 .1-.3.7-.6 1.1-.6 1.4-.1 2.8 0 4.2 0 18.8 0 37.6.1 56.3-.1 5.6-.1 11.6 4.3 9.2 12.5-1.8 6.1-4.1 12.1-6.2 18.2-.7 2.1-1.4 4.1-2.1 6.2-2.6 7.2-7.9 11.6-15.2 13.6-.7.2-1.4.2-2.1.2H22.3c-.4-.1-.8-.1-1.5-.1z'></path><path fill='#fff' d='M55.9 58.1c-1.4 4-2.8 7.7-4.2 11.4-.1.3-.7.5-1 .5H19.2c-.1 0-.3-.1-.6-.2 1.3-3.7 2.6-7.3 4-10.9.1-.3.7-.7 1-.7 10.7-.1 21.4-.1 32.3-.1z'></path></svg>" ,AvatarColor="success",Coin="Dash",Coinvalue="DASH",Value="23" ,Amount="15,176.46",IsIncreased=false,IncreasedValue="-1,8.01",Increasedpercentage="0.1%"},
            
            new MarketCapList {AvatarIcon="<svg xmlns='http://www.w3.org/2000/svg' height='28' width='28' viewBox='0 0 128 128'><path d='M64 128C28.7 128 0 99.3 0 64S28.7 0 64 0s64 28.7 64 64-28.7 64-64 64z'></path><path fill='#fff' d='M63.8 22.6c3.7-.1 7.2.6 10.2 2.7 1.4.9 2.4.8 3.6-.5 2.4-2.6 5-5 7.5-7.6.9-.9 1.8-1.5 2.9-.2 1.1 1.1.8 2-.2 2.9-2.6 2.6-5 5.2-7.6 7.8-1.1 1.1-1.3 1.9-.5 3.3 5.8 10.4 2.9 22.5-8.6 28.1-1.1.5-2.3.8-3.5 1-1.4.3-1.9 1-1.9 2.5.1 3 .1 6 0 8.9 0 1.6.5 2.3 2.1 2.7 6.2 1.5 10.6 5.2 13.3 10.9 2.6 5.5 1.9 15.4-3.8 21.3-4.8 4.9-13.2 6.9-19.5 4.4-7.5-3-12.1-9.6-12.2-17.5-.1-9.6 5.1-16.4 14.3-19 1.4-.4 2.2-1 2.1-2.5-.1-3.4 0-6.8-.2-10.2 0-.6-1.1-1.4-1.8-1.6-6-1.6-10.4-5.2-12.9-10.8-5.6-13 4.3-27.4 16.7-26.6zM79 92.8c0-7.9-6.9-15.1-14.5-15.1-8-.1-15.3 7-15.4 15-.1 7.9 7.3 15.6 14.9 15.5 8.1-.1 15-7.2 15-15.4zM49.3 41.1c0 8.6 6.6 15.6 14.9 15.6 7.7 0 14.8-7.1 14.8-15.1 0-7.4-5.5-15.2-14.7-15-8.4.1-14.9 6.3-15 14.5z'></path></svg>" ,AvatarColor="warning",Coin="Golem",Coinvalue="GLM",Value="2" ,Amount="11,576.1",IsIncreased=true,IncreasedValue="+1,67.08",Increasedpercentage="0.03%"},
            
            new MarketCapList {AvatarIcon="<svg xmlns='http://www.w3.org/2000/svg' height='28' width='28' viewBox='0 0 128 128'><path d='M64 128C28.7 128 0 99.3 0 64S28.7 0 64 0s64 28.7 64 64-28.7 64-64 64z'></path><path fill='#fff' d='M59.5 87.6l5-19 11.9-4.4 3-11.2-.1-.2-11.7 4.3L76 25.2H52L40.9 66.8l-9.2 3.4-3.1 11.5 9.3-3.4-6.6 24.5h64l4.1-15.2z'></path></svg>" ,AvatarColor="info",Coin="Litecoin",Coinvalue="LTC",Value="13" ,Amount="16,581.81",IsIncreased=false,IncreasedValue="-1,01.05",Increasedpercentage="3.8%"},
            
            new MarketCapList {AvatarIcon="<svg xmlns='http://www.w3.org/2000/svg' height='28' width='28' viewBox='0 0 128 128'><path d='M64 128C28.7 128 0 99.3 0 64S28.7 0 64 0s64 28.7 64 64-28.7 64-64 64z'></path><path fill='#fff' d='M63.9 111.8c-.9-.4-1.7-.7-2.4-1.1-11.8-7-23.7-14.1-35.5-21.2-2.7-1.6-3.2-3.2-1.6-6.1 12-21.5 24-43 35.9-64.5.8-1.5 1.8-2.6 3.6-2.6s2.8 1.2 3.6 2.7c11.9 21.4 23.9 42.9 35.8 64.3 1.6 2.9 1.2 4.5-1.6 6.2l-35.1 21c-.8.5-1.8.9-2.7 1.3zm-4.2-22.2c-2.8-1.7-5.5-3.3-8.2-4.9-2-1.2-3.9-2.6-5.9-3.8-.8-.5-2-.9-2.9-.6-4.9 1.4-9.4 3.9-14 6.8 11.3 6.7 22.2 13.3 33.4 20 0-4.5.1-8.6 0-12.7-.1-2.5.9-4.5 2.6-6.1 1.2-1.1 2.6-2.1 4-2.8 4-1.9 7.2-4.5 9-8.9.8 1.3 1.5 2.3 2.2 3.4-1.9 3.5-4.7 6-8.1 7.8-1.6.8-3.1 1.8-4.5 2.9-.7.6-1.6 1.6-1.6 2.4-.2 4.5-.1 9.1-.1 14 11.2-6.7 22-13.2 33.3-19.9-4.4-2.2-8.4-4.3-12.4-6.2-2.9-1.4-4.9-3.4-6.1-6.3-.8-2-1.5-4.1-2.1-6.3-1.5-5.8-5-9.6-10.8-11.3-.6-.2-1.3-.3-2-.5 2.4-3.4 2.4-3.4 5.9-1.8 5.3 2.5 8.9 6.6 10.1 12.3 1.2 6 3.8 10.5 9.9 12.5 1.6.5 3.1 1.5 4.6 2.3.9.4 1.7.8 2.6 1.2.1-.1.2-.2.3-.4-10.8-19.6-21.8-39.2-32.7-58.8-.2 0-.4.1-.6.1v2.2c0 7-.2 14 .1 21 .1 4.1-1.5 6.8-4.8 8.9-1.2.8-2.4 1.5-3.7 2.1-4 2-6.7 5.2-7.6 9.5-.5 2.4-.4 4.9-.5 7.3-3.7-1.1-3.7-1.1-3.4-5.1.6-6.8 4.1-11.7 10-15 1.6-.9 3.3-1.7 4.6-3 .9-.9 1.7-2.4 1.7-3.7.2-7.7.1-15.4.1-23.2 0-.4-.1-.9-.3-1.7-11 20-21.8 39.4-32.9 59.2 3.8-1.8 7.2-3.3 10.6-4.9 2.8-1.3 5.6-1.1 8.2.3 1.7.9 3.4 1.8 4.9 3.1 2.8 2.5 5.8 4.5 9.8 5-.9 1.2-1.6 2.1-2.7 3.6z'></path></svg>" ,AvatarColor="danger",Coin="Augur",Coinvalue="REP",Value="10" ,Amount="10,107.51",IsIncreased=true,IncreasedValue="+1,10.30",Increasedpercentage="1.89%"},
        };
        public List<MarketCapList> GetMarketCap() => MarketCapData;
        public TableText[] CryptoTransactionHeadersData = new TableText[]{
            new TableText { Title = "Cryptocurrency" },
            new TableText { Title = "Action" },
            new TableText { Title = "Date & Time" },
            new TableText { Title = "Change" },
        };        
        public  TableText[] GetCryptoTransactionHeadersData() => CryptoTransactionHeadersData;
        public List<CryptoTransaction> CryptoTransactionData = new List<CryptoTransaction>{
            new CryptoTransaction { CoinImg = "../assets/images/crypto-currencies/crypto-icons/bitcoin-btc-logo.svg",Coin="Bitcoin",CoinColor="bg-primary3-transparent",Coinvalue="BTC" ,Transaction="Deposited",Transactiondate="12 Apr, 2024 13:12",IsIncreased=true,IncreasedValue="+ 25,00 BTC"},
            new CryptoTransaction { CoinImg = "../assets/images/crypto-currencies/crypto-icons/ethereum-eth-logo.svg",Coin="Ethereum",CoinColor="bg-gray-200",Coinvalue="ETH" ,Transaction="Withdraw",Transactiondate="20 Apr, 2024 08:14",IsIncreased=false,IncreasedValue="- 25,00 ETH"},
            new CryptoTransaction { CoinImg = "../assets/images/crypto-currencies/crypto-icons/bitcoin-btc-logo.svg",Coin="Bitcoin",CoinColor="bg-primary3-transparent",Coinvalue="BTC" ,Transaction="Buy",Transactiondate="12 Apr, 2024 16:37",IsIncreased=true,IncreasedValue="+ 25,00 BTC"},
            new CryptoTransaction { CoinImg = "../assets/images/crypto-currencies/crypto-icons/tether-usdt-logo.svg",Coin="Tether",CoinColor="bg-success-transparent",Coinvalue="USDT" ,Transaction="Convert",Transactiondate="12 Apr, 2024 11:45",IsIncreased=true,IncreasedValue="+ $610,539 USDT"},
            new CryptoTransaction { CoinImg = "../assets/images/crypto-currencies/crypto-icons/ethereum-eth-logo.svg",Coin="Ethereum",CoinColor="bg-gray-200",Coinvalue="ETH" ,Transaction="Deposited",Transactiondate="20 Apr, 2024 08:55",IsIncreased=false,IncreasedValue="- 25,00 ETH"},
        };        
        public List<CryptoTransaction> GetCryptoTransactionData() => CryptoTransactionData;
        public static List<BalanceAnalysis> BalanceAnalysis()
        {
            var balance = new List<BalanceAnalysis>();
            balance.Add(new BalanceAnalysis { Analysis = "Funding", AnalysisValue = 85});
            balance.Add(new BalanceAnalysis { Analysis = "Trading", AnalysisValue = 75});
            return balance;
        }
        public static List<CryptoCandlestickchart> GetCryptoData() {
            var cryptoData = new List<CryptoCandlestickchart>();
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538778600000), Open = 6629.81M, High = 6650.5M, Low = 6623.04M, Close = 6633.33M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538780400000), Open = 6632.01M, High = 6643.59M, Low = 6620M, Close = 6630.11M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538782200000), Open = 6630.71M, High = 6648.95M, Low = 6623.34M, Close = 6635.65M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538784000000), Open = 6635.65M, High = 6651M, Low = 6629.67M, Close = 6638.24M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538785800000), Open = 6638.24M, High = 6640M, Low = 6620M, Close = 6624.47M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538787600000), Open = 6624.53M, High = 6636.03M, Low = 6621.68M, Close = 6624.31M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538789400000), Open = 6624.61M, High = 6632.2M, Low = 6617M, Close = 6626.02M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538791200000), Open = 6627M, High = 6627.62M, Low = 6584.22M, Close = 6603.02M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538793000000), Open = 6605M, High = 6608.03M, Low = 6598.95M, Close = 6604.01M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538794800000), Open = 6604.5M, High = 6614.4M, Low = 6602.26M, Close = 6608.02M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538796600000), Open = 6608.02M, High = 6610.68M, Low = 6601.99M, Close = 6608.91M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538798400000), Open = 6608.91M, High = 6618.99M, Low = 6608.01M, Close = 6612M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538800200000), Open = 6612M, High = 6615.13M, Low = 6605.09M, Close = 6612M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538802000000), Open = 6612M, High = 6624.12M, Low = 6608.43M, Close = 6622.95M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538803800000), Open = 6623.91M, High = 6623.91M, Low = 6615M, Close = 6615.67M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538805600000), Open = 6618.69M, High = 6618.74M, Low = 6610M, Close = 6610.4M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538807400000), Open = 6611M, High = 6622.78M, Low = 6610.4M, Close = 6614.9M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538809200000), Open = 6614.9M, High = 6626.2M, Low = 6613.33M, Close = 6623.45M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538811000000), Open = 6623.48M, High = 6627M, Low = 6618.38M, Close = 6620.35M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538812800000), Open = 6619.43M, High = 6620.35M, Low = 6610.05M, Close = 6615.53M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538814600000), Open = 6615.53M, High = 6617.93M, Low = 6610M, Close = 6615.19M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538816400000), Open = 6615.19M, High = 6621.6M, Low = 6608.2M, Close = 6620M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538818200000), Open = 6619.54M, High = 6625.17M, Low = 6614.15M, Close = 6620M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538820000000), Open = 6620.33M, High = 6634.15M, Low = 6617.24M, Close = 6624.61M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538821800000), Open = 6625.95M, High = 6626M, Low = 6611.66M, Close = 6617.58M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538823600000), Open = 6619M, High = 6625.97M, Low = 6595.27M, Close = 6598.86M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538825400000), Open = 6598.86M, High = 6598.88M, Low = 6570M, Close = 6587.16M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538827200000), Open = 6588.86M, High = 6600M, Low = 6580M, Close = 6593.4M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538829000000), Open = 6593.99M, High = 6598.89M, Low = 6585M, Close = 6587.81M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538830800000), Open = 6587.81M, High = 6592.73M, Low = 6567.14M, Close = 6578M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538832600000), Open = 6578.35M, High = 6581.72M, Low = 6567.39M, Close = 6579M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538834400000), Open = 6579.38M, High = 6580.92M, Low = 6566.77M, Close = 6575.96M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538836200000), Open = 6575.96M, High = 6589M, Low = 6571.77M, Close = 6588.92M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538838000000), Open = 6588.92M, High = 6594M, Low = 6577.55M, Close = 6589.22M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538839800000), Open = 6589.3M, High = 6598.89M, Low = 6589.1M, Close = 6596.08M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538841600000), Open = 6597.5M, High = 6600M, Low = 6588.39M, Close = 6596.25M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538843400000), Open = 6598.03M, High = 6600M, Low = 6588.73M, Close = 6595.97M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538845200000), Open = 6595.97M, High = 6602.01M, Low = 6588.17M, Close = 6602M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538847000000), Open = 6602M, High = 6607M, Low = 6596.51M, Close = 6599.95M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538848800000), Open = 6600.63M, High = 6601.21M, Low = 6590.39M, Close = 6591.02M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538850600000), Open = 6591.02M, High = 6603.08M, Low = 6591M, Close = 6591M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538852400000), Open = 6591M, High = 6601.32M, Low = 6585M, Close = 6592M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538854200000), Open = 6593.13M, High = 6596.01M, Low = 6590M, Close = 6593.34M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538856000000), Open = 6593.34M, High = 6604.76M, Low = 6582.63M, Close = 6593.86M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538857800000), Open = 6593.86M, High = 6604.28M, Low = 6586.57M, Close = 6600.01M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538859600000), Open = 6601.81M, High = 6603.21M, Low = 6592.78M, Close = 6596.25M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538861400000), Open = 6596.25M, High = 6604.2M, Low = 6590M, Close = 6602.99M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538863200000), Open = 6602.99M, High = 6606M, Low = 6584.99M, Close = 6587.81M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538865000000), Open = 6587.81M, High = 6595M, Low = 6583.27M, Close = 6591.96M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538866800000), Open = 6591.97M, High = 6596.07M, Low = 6585M, Close = 6588.39M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538868600000), Open = 6587.6M, High = 6598.21M, Low = 6587.6M, Close = 6594.27M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538870400000), Open = 6596.44M, High = 6601M, Low = 6590M, Close = 6596.55M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538872200000), Open = 6598.91M, High = 6605M, Low = 6596.61M, Close = 6600.02M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538874000000), Open = 6600.55M, High = 6605M, Low = 6589.14M, Close = 6593.01M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538875800000), Open = 6593.15M, High = 6605M, Low = 6592M, Close = 6603.06M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538877600000), Open = 6603.07M, High = 6604.5M, Low = 6599.09M, Close =6603.89M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538879400000), Open = 6604.44M, High = 6604.44M, Low = 6600M, Close = 6603.5M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538881200000), Open = 6603.5M, High = 6603.99M, Low = 6597.5M, Close = 6603.86M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538883000000), Open = 6603.85M, High = 6605M, Low = 6600M, Close = 6604.07M });
            cryptoData.Add(new CryptoCandlestickchart { Date =new DateTime(1538884800000), Open = 6604.98M, High = 6606M, Low = 6604.07M, Close = 6606M });
            return cryptoData;
        }
    }
}
