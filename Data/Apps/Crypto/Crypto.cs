using CardModel;
namespace CryptoData
{
    public class Transaction
    {
        public string? CryptocurrrencyImg { get; set; }
        public string? CryptocurrrencyName { get; set; }
        public string? DateTime { get; set; }
        public string? TransactionId { get; set; }
        public string? Type { get; set; }
        public string? Amount { get; set; }
        public string? Status { get; set; }
        public string? RecipientAddress { get; set; }
        public bool IsDeleting { get; set; }
    }
    
    public class MarketCapList
    {
        public decimal Id { get; set; }
        public string? CryptoImg { get; set; }
        public string? Crypto { get; set; }
        public string? MarketCap { get; set; }
        public bool Change { get; set; }
        public string? Changevalue { get; set; }
        public string? Price { get; set; }
        public bool Change24h { get; set; }
        public string? Changevalue24h { get; set; }
        public string? Volume { get; set; }
        public string? Supply { get; set; }
        public string? SupplyValue { get; set; }
        public string? SupplyValue2 { get; set; }
    }
    public class ExchangeChart : ILineGraph {
        public decimal Series { get; set; }
        public decimal Value { get; set; }
    } ;
    public class AudienceMetric {
        public string? Month { get; set; }
        public decimal Viewers { get; set; }
        public decimal Sessions { get; set; }
    } ;
    public class CryptoDataService {
        private List<Transaction> Transactions = new List<Transaction>()
        {
            new Transaction { 
                CryptocurrrencyImg  = "../assets/images/crypto-currencies/regular/Bitcoin.svg",
                CryptocurrrencyName  = "Bitcoin (BTC)",
                DateTime  = "2024-06-01 10:15:22",
                TransactionId  ="TXN123456789",
                Type  ="Withdrawal",
                Amount  ="0.5 BTC",
                Status  ="Completed",
                RecipientAddress  ="1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa",
            }, 
            new Transaction { 
                CryptocurrrencyImg  = "../assets/images/crypto-currencies/regular/Ethereum.svg",
                CryptocurrrencyName  = "Ethereum (ETH)",
                DateTime  = "2024-06-02 14:30:45",
                TransactionId  ="TXN987654321",
                Type  ="Deposit",
                Amount  ="10.0 ETH",
                Status  ="Pending",
                RecipientAddress  ="0x32Be343B94f860124dC4fEe278FDCBD38C102D88",
            },
            new Transaction { 
                CryptocurrrencyImg  = "../assets/images/crypto-currencies/regular/litecoin.svg",
                CryptocurrrencyName  = "Litecoin (LTC)",
                DateTime  = "2024-06-03 09:45:10",
                TransactionId  ="TXN567890123",
                Type  ="Buy",
                Amount  ="50.0 LTC",
                Status  ="Completed",
                RecipientAddress  ="MV3rLMY1Tep6Rhbt4x8fZ2rERKx1CBYKFz",
            },
            new Transaction { 
                CryptocurrrencyImg  = "../assets/images/crypto-currencies/regular/Ripple.svg",
                CryptocurrrencyName  = "Ripple (XRP)",
                DateTime  = "2024-06-04 16:20:55",
                TransactionId  ="TXN246801357",
                Type  ="Sell",
                Amount  ="1000 XRP",
                Status  ="Failed",
                RecipientAddress  ="rEb8TK3gBgk5auZkwc6sHnwrGVJH8DuaLh",
            },
            new Transaction { 
                CryptocurrrencyImg  = "../assets/images/crypto-currencies/regular/Bitcoin.svg",
                CryptocurrrencyName  = "Bitcoin (BTC)",
                DateTime  = "2024-06-05 11:55:30",
                TransactionId  ="TXN654321789",
                Type  ="Transfer",
                Amount  ="1.2 BTC",
                Status  ="Completed",
                RecipientAddress  ="3BbDtxBSjgfTRxaBUgRqAeW1XVo8JpEzYy",
            },
            new Transaction { 
                CryptocurrrencyImg  = "../assets/images/crypto-currencies/regular/Ethereum.svg",
                CryptocurrrencyName  = "Ethereum (ETH)",
                DateTime  = "2024-06-06 08:10:18",
                TransactionId  ="TXN135790246",
                Type  ="Withdrawal",
                Amount  ="5.5 ETH",
                Status  ="Pending",
                RecipientAddress  ="0x1dF62f291b2E969f6B5e158bcCC90eD80720D82e",
            },
            new Transaction { 
                CryptocurrrencyImg  = "../assets/images/crypto-currencies/regular/Bitcoin.svg",
                CryptocurrrencyName  = "Bitcoin (BTC)",
                DateTime  = "2024-06-07 15:20:35",
                TransactionId  ="TXN789012345",
                Type  ="Deposit",
                Amount  ="0.8 BTC",
                Status  ="Completed",
                RecipientAddress  ="1F1tAaz5x1HUXrCNLbtMDqcw6o5GNn4xqX",
            },
            new Transaction { 
                CryptocurrrencyImg  = "../assets/images/crypto-currencies/regular/litecoin.svg",
                CryptocurrrencyName  = "Litecoin (LTC)",
                DateTime  = "2024-06-08 12:55:50",
                TransactionId  ="TXN456789012",
                Type  ="Sell",
                Amount  ="25.0 LTC",
                Status  ="Completed",
                RecipientAddress  ="LPnPZ8qY2TAnYXUTtrBMHK5h8BQ4mP51sU",
            },
            new Transaction { 
                CryptocurrrencyImg  = "../assets/images/crypto-currencies/regular/Ripple.svg",
                CryptocurrrencyName  = "Ripple (XRP)",
                DateTime  = "2024-06-09 09:30:05",
                TransactionId  ="TXN901234567",
                Type  ="Buy",
                Amount  ="500 XRP",
                Status  ="Pending",
                RecipientAddress  ="rw2ciyaNshpHe7bCHo4bRWq6pqqynnWKQg",
            },
            new Transaction { 
                CryptocurrrencyImg  = "../assets/images/crypto-currencies/regular/Bitcoin.svg",
                CryptocurrrencyName  = "Bitcoin (BTC)",
                DateTime  = "2024-06-10 14:45:22",
                TransactionId  ="TXN234567890",
                Type  ="Transfer",
                Amount  ="1.0 BTC",
                Status  ="Completed",
                RecipientAddress  ="3CwTjvdAx2T1ZCFjHoUYaX6jTEy4d8BQsE",
            },
        };
        public List<Transaction> GetTransactions() => Transactions;    
        public TableText[] TransactionTableHeaders = new TableText[]
        {
            new TableText { Title = "Cryptocurrency" },
            new TableText { Title = "Date & Time" },
            new TableText { Title = "Transaction ID" },
            new TableText { Title = "Type" },
            new TableText { Title = "Amount" },
            new TableText { Title = "Status" },
            new TableText { Title = "Recipient Address" },
            new TableText { Title = "Actions" },
        };
        public TableText[] GetTransactionHeadersData() => TransactionTableHeaders;
        private List<MarketCap> ExchangeData = new List<MarketCap>( )
        {
            new MarketCap {CryptoImg="../assets/images/crypto-currencies/square-color/Bitcoin.svg",CryptoTitle="Bitcoin",CryptoSubTitle="- BTC",CryptoValue="24.3%",CryptoRatio="0.00434",CryptoUsd="$30.29",IsIncreased=true,Percentage="+0.59"},
            new MarketCap {CryptoImg="../assets/images/crypto-currencies/square-color/Ethereum.svg",CryptoTitle="Ethereum",CryptoSubTitle="- ETH",CryptoValue="18.7%",CryptoRatio="0.01758",CryptoUsd="$2564.89",IsIncreased=true,Percentage="+0.92"},
            new MarketCap {CryptoImg="../assets/images/crypto-currencies/square-color/Dash.svg",CryptoTitle="Dash",CryptoSubTitle="- DASH",CryptoValue="12.5%",CryptoRatio="0.00487",CryptoUsd="$116.78",IsIncreased=false,Percentage="-0.30"},
            new MarketCap {CryptoImg="../assets/images/crypto-currencies/square-color/Litecoin.svg",CryptoTitle="Litecoin",CryptoSubTitle="- LTC",CryptoValue="8.2%",CryptoRatio="0.00789",CryptoUsd="$158.42",IsIncreased=true,Percentage="+0.15"},
            new MarketCap {CryptoImg="../assets/images/crypto-currencies/square-color/Ripple.svg",CryptoTitle="Ripple",CryptoSubTitle="- XRP",CryptoValue="6.5%",CryptoRatio="0.00123 ",CryptoUsd="$0.79",IsIncreased=true,Percentage="+0.10"},
            new MarketCap {CryptoImg="../assets/images/crypto-currencies/square-color/Golem.svg",CryptoTitle="Golem",CryptoSubTitle="- GNT",CryptoValue="4.8%",CryptoRatio="0.000045",CryptoUsd="$1.23",IsIncreased=false,Percentage="-0.02"},
            new MarketCap {CryptoImg="../assets/images/crypto-currencies/square-color/Monero.svg",CryptoTitle="Monero",CryptoSubTitle="- XMR",CryptoValue="3.2%",CryptoRatio="0.00456",CryptoUsd="$182.34",IsIncreased=true,Percentage="+0.08"},
            new MarketCap {CryptoImg="../assets/images/crypto-currencies/square-color/EOS.svg",CryptoTitle="EOS",CryptoSubTitle="- EOS",CryptoValue="5.7%",CryptoRatio="0.00234",CryptoUsd="$4.78",IsIncreased=true,Percentage="+0.23"},
            new MarketCap {CryptoImg="../assets/images/crypto-currencies/square-color/Stratis.svg",CryptoTitle="Stratis",CryptoSubTitle="- STRAX",CryptoValue="2.1%",CryptoRatio="0.001234",CryptoUsd="$2.34",IsIncreased=true,Percentage="+0.04"},
        };
        public List<MarketCap> GetExchangeData() => ExchangeData;
        public static List<ExchangeChart> GetExchangeChart(MarketCap MainCard)
        {
            var ExchangeChart = new List<ExchangeChart>();
            var sharedValues = new List<decimal> { 54, 38, 56, 35, 65, 43, 53, 45, 62, 80, 35, 48 };
           var titles = new List<string>
            {
                "Bitcoin","Ethereum","Dash","Litecoin","Ripple","Golem","Monero","EOS","Stratis",
            };
            var title = MainCard?.CryptoTitle;
            if (!string.IsNullOrEmpty(title) && titles.Contains(title))
            {
                for (int i = 0; i < sharedValues.Count; i++)
                {
                    ExchangeChart.Add(new ExchangeChart { Series = i + 1, Value = sharedValues[i] });
                }
            }
            return ExchangeChart;
        }
        public static List<AudienceMetric> GetAudienceMetric() {
            var audienceMetric = new List<AudienceMetric> ();
            audienceMetric.Add(new AudienceMetric { Month = "Jan", Viewers = 85, Sessions = 20});
            audienceMetric.Add(new AudienceMetric { Month = "Feb", Viewers = 65, Sessions = 38});
            audienceMetric.Add(new AudienceMetric { Month = "Mar", Viewers = 75, Sessions = 38});
            audienceMetric.Add(new AudienceMetric { Month = "Apr", Viewers = 38, Sessions = 72});
            audienceMetric.Add(new AudienceMetric { Month = "May", Viewers = 85, Sessions = 55});
            audienceMetric.Add(new AudienceMetric { Month = "Jun", Viewers = 35, Sessions = 63});
            audienceMetric.Add(new AudienceMetric { Month = "Jul", Viewers = 62, Sessions = 43});
            audienceMetric.Add(new AudienceMetric { Month = "Aug", Viewers = 40, Sessions = 76});
            audienceMetric.Add(new AudienceMetric { Month = "Sep", Viewers = 40, Sessions = 55});
            audienceMetric.Add(new AudienceMetric { Month = "Oct", Viewers = 64, Sessions = 80});
            audienceMetric.Add(new AudienceMetric { Month = "Nov", Viewers = 50, Sessions = 40});
            audienceMetric.Add(new AudienceMetric { Month = "Dec", Viewers = 89, Sessions = 80});
            return audienceMetric;
        }
        private List<MarketCap> MarketcapData = new List<MarketCap>( )
        {
            new MarketCap {CryptoImg="../assets/images/crypto-currencies/square-color/Bitcoin.svg",CryptoTitle="Bitcoin",CryptoSubTitle="BTC - Rank 1",CryptoValue="$1.04",Volume="+2.33%",CryptoValue2="$35,876.29",CryptoValue2Sub="BTC",CryptoRatio="+280.30",CryptoUsd="$1.054B",IsIncreased=true,Percentage="0.96%"},
            new MarketCap {CryptoImg="../assets/images/crypto-currencies/square-color/Dash.svg",CryptoTitle="Dash",CryptoSubTitle="DASH - Rank 50",CryptoValue="$112.45",Volume="+1.25%",CryptoValue2="$112.34",CryptoValue2Sub="DASH",CryptoRatio="-0.05",CryptoUsd="$1.21B",IsIncreased=false,Percentage="-0.02%"},
            new MarketCap {CryptoImg="../assets/images/crypto-currencies/square-color/Ethereum.svg",CryptoTitle="Ethereum",CryptoSubTitle="ETH - Rank 2",CryptoValue="$2.15K",Volume="+3.12%",CryptoValue2="$2,135.67",CryptoValue2Sub="ETH",CryptoRatio="+5.42",CryptoUsd="$250.87B",IsIncreased=true,Percentage="2.21%"},
        };
        public List<MarketCap> GetMarketcapData() => MarketcapData;
        public static List<ExchangeChart> GetMarketcapChart(MarketCap MainCard)
        {
            var ExchangeChart = new List<ExchangeChart>();
            var sharedValues = new List<decimal> { 0, 45, 54, 38, 56, 24, 65, 31, 37, 39, 62, 51, 35, 41, 35, 27, 93, 53, 61, 27, 54, 43, 19, 46};
           var titles = new List<string>
            {
                "Bitcoin","Dash","Ethereum",
            };
            var title = MainCard?.CryptoTitle;
            if (!string.IsNullOrEmpty(title) && titles.Contains(title))
            {
                for (int i = 0; i < sharedValues.Count; i++)
                {
                    ExchangeChart.Add(new ExchangeChart { Series = i + 1, Value = sharedValues[i] });
                }
            }
            return ExchangeChart;
        }
        public TableText[] MarketCapTableHeaders = new TableText[]
        {
            new TableText { Title = "" },
            new TableText { Title = "#" },
            new TableText { Title = "Crypto Name" },
            new TableText { Title = "MarketCap" },
            new TableText { Title = "last 1Week" },
            new TableText { Title = "1h Change" },
            new TableText { Title = "Price<span class='text-muted ms-1'>(USD)" },
            new TableText { Title = "24h Change" },
            new TableText { Title = "Volume (24h)" },
            new TableText { Title = "Circulating Supply" },
            new TableText { Title = "Trade" },
        };
        public TableText[] GetMarketCapHeadersData() => MarketCapTableHeaders;
        private List<MarketCapList> MarketCapListData = new List<MarketCapList>( )
        {
            new MarketCapList {Id =1,CryptoImg ="../assets/images/crypto-currencies/square-color/Bitcoin.svg",Crypto ="Bitcoin (BTC)",MarketCap ="$582.23B",Change =false,Changevalue ="0.483%",Price="$29,948.80",Change24h =true,Changevalue24h ="0.239%",Volume ="$11.79B USD",Supply ="19.43M of (21M)",SupplyValue ="88",SupplyValue2 ="12",},
            new MarketCapList {Id =2,CryptoImg ="../assets/images/crypto-currencies/square-color/Ethereum.svg",Crypto ="Etherium (ETH)",MarketCap ="$226.91B",Change =false,Changevalue ="0.87%",Price="$1,895.96",Change24h =false,Changevalue24h ="0.29%",Volume ="$2.83B USD",Supply ="120M",},
            new MarketCapList {Id =3,CryptoImg ="../assets/images/crypto-currencies/square-color/Golem.svg",Crypto ="Golem (GLM)",MarketCap ="$202.07M",Change =true,Changevalue ="0.61%",Price="$1.201472",Change24h =false,Changevalue24h ="34.96%",Volume ="$2,112,645 USD",Supply ="1,000M",SupplyValue ="100",SupplyValue2 ="0",},
            new MarketCapList {Id =4,CryptoImg ="../assets/images/crypto-currencies/square-color/Dash.svg",Crypto ="Dash (DASH)",MarketCap ="$365.877M",Change =true,Changevalue ="0.59%",Price="$32.13",Change24h =true,Changevalue24h ="1.24%",Volume ="$3.61M USD",Supply ="11.37M of (18.92M)",SupplyValue ="56",SupplyValue2 ="44",},
            new MarketCapList {Id =5,CryptoImg ="../assets/images/crypto-currencies/square-color/Litecoin.svg",Crypto ="Litecoin (LTC)",MarketCap ="$6.80B",Change =false,Changevalue ="0.90%",Price="$92.98",Change24h =true,Changevalue24h ="2.22%",Volume ="$11.46B USD",Supply ="73.40M",SupplyValue ="100",SupplyValue2 ="0",},
            new MarketCapList {Id =6,CryptoImg ="../assets/images/crypto-currencies/square-color/Ripple.svg",Crypto ="Ripple (XRP)",MarketCap ="$42.48B",Change =true,Changevalue ="0.01%",Price="$1.83",Change24h =true,Changevalue24h ="0.91%",Volume ="$2.99B USD",Supply ="52.54B of (100B)",SupplyValue ="52",SupplyValue2 ="48",},
            new MarketCapList {Id =7,CryptoImg ="../assets/images/crypto-currencies/square-color/EOS.svg",Crypto ="EOs",MarketCap ="$85.2M",Change =false,Changevalue ="0.61%",Price="$1.765957",Change24h =false,Changevalue24h ="20.65%",Volume ="$116.91M USD",Supply ="10.1B of (105B)",SupplyValue ="10",SupplyValue2 ="90",},
            new MarketCapList {Id =8,CryptoImg ="../assets/images/crypto-currencies/square-color/Bytecoin.svg",Crypto ="Bytecoin (BCN)",MarketCap ="$6.2M",Change =false,Changevalue ="25.24%",Price="$1.00039",Change24h =false,Changevalue24h ="27.12%",Volume ="$6,184 USD",Supply ="184.02B of (184.07B)",SupplyValue ="99",SupplyValue2 ="1",},
            new MarketCapList {Id =9,CryptoImg ="../assets/images/crypto-currencies/square-color/IOTA.svg",Crypto ="IOTA",MarketCap ="$510.429M",Change =false,Changevalue ="1.08%",Price="$1.184992",Change24h =false,Changevalue24h ="1.41%",Volume ="$7.50M USD",Supply ="2.78B"},
            new MarketCapList {Id =10,CryptoImg ="../assets/images/crypto-currencies/square-color/Monero.svg",Crypto ="Monero",MarketCap ="$3.062B",Change =false,Changevalue ="3.22%",Price="$165.76",Change24h =false,Changevalue24h ="3.48%",Volume ="	$105.8M USD",Supply ="18.15M"},
        };
        public List<MarketCapList> GetMarketCapListData() => MarketCapListData;
        public static List<ExchangeChart> GetMarketCapListChart(MarketCapList Item)
        {
            var ExchangeChart = new List<ExchangeChart>();
            var sharedValues = new List<decimal> { 0, 45, 54, 38, 56, 24, 65, 31, 37, 39, 62, 51, 35, 41, 35, 27, 93, 53, 61, 27, 54, 43, 19, 46, 25, 45, 54, 38, 56, 24, 65, 31, 37, 39, 62};
            var titles = new List<decimal>
            {
                1,2,3,4,5,6,7,8,9,10
            };
            var title = Item?.Id;
            if (title.HasValue && titles.Contains(title.Value))
            {
                for (int i = 0; i < sharedValues.Count; i++)
                {
                    ExchangeChart.Add(new ExchangeChart { Series = i + 1, Value = sharedValues[i] });
                }
            }
            return ExchangeChart;
        }

    }
}