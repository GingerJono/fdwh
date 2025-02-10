using CardModel;

namespace Crypto
{
    public class CryptoChart : ILineGraph {
        public decimal Series { get; set; }
        public decimal Value { get; set; }
    } ;
    public class Portfolio  {
        public decimal Id { get; set; }
        public string? CoinImg { get; set; }
        public string? Coin { get; set; }
        public string? Price { get; set; }
        public string? Volume { get; set; }
        public bool IsIncreased { get; set; }
        public string? Change { get; set; }
        public string? MarketCap { get; set; }
    }
    public class PortfolioChart : ILineGraph {
        public decimal Series { get; set; }
        public decimal Value { get; set; }
    } ;
    public class BalanceAnalysis {
        public string? Analysis { get; set; }
        public decimal AnalysisValue { get; set; }
    }
    public class CryptoCandlestickchart {
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
    }
    public class MarketCapList {
        public string? AvatarIcon { get; set; }
        public string? AvatarColor { get; set; }
        public string? Coin { get; set; }
        public string? Coinvalue { get; set; }
        public string? Value { get; set; }
        public string? Amount { get; set; }
        public bool IsIncreased { get; set; }
        public string? IncreasedValue { get; set; }
        public string? Increasedpercentage { get; set; }
    }   
     public class CryptoTransaction {
        public string? CoinImg { get; set; }
        public string? CoinColor { get; set; }
        public string? Coin { get; set; }
        public string? Coinvalue { get; set; }
        public string? Transaction { get; set; }
        public string? Transactiondate { get; set; }
        public bool IsIncreased { get; set; }
        public string? IncreasedValue { get; set; }
    }
}

