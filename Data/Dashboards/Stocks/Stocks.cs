using CardModel;

namespace Stocks
{
    public class StocksChart : ILineGraph {
        public decimal Series { get; set; }
        public decimal Value { get; set; }
    } ;
    public class Analysis {
        public string? Week { get; set; }
        public decimal ThisWeek { get; set; }
        public decimal LastWeek { get; set; }
    } ;
    public class Statistics
    {
        public string? Source { get; set; }
        public int SourceValue { get; set; }
    }
    public class TimeSeries
    {
        public DateTime X { get; set; } 
        public double? Y { get; set; }  
    }
    public class Watchlist
    {
        public string? SourceIcon { get; set; }
        public string? SourceClass { get; set; }
        public string? Source { get; set; }
        public string? SourceSubTitle { get; set; }
        public string? SourceValue { get; set; }
        public bool IsIncreased { get; set; }
        public string? Percentage { get; set; }
    }
    public class Stockslist
    {
        public string? StockIcon { get; set; }
        public string? StockClass { get; set; }
        public string? Stock { get; set; }
        public string? StockSubTitle { get; set; }
        public string? Quantity { get; set; }
        public string? Price { get; set; }
        public bool IsIncreased { get; set; }
        public string? Change { get; set; }
        public string? StockValue { get; set; }
    }
    public class Transactionlist
    {
        public string? StockImg { get; set; }
        public string? StockIcon { get; set; }
        public string? StockClass { get; set; }
        public string? Stock { get; set; }
        public string? Date { get; set; }
        public string? Shares { get; set; }
        public bool TransactionType { get; set; }
        public string? Price { get; set; }
        public string? PriceValue { get; set; }
        public bool IsIncreased { get; set; }
        public string? Change { get; set; }
    }
    public class MarketList 
    {
        public string? Symbol { get; set; }
        public string? Market { get; set; }
        public bool IsIncreased { get; set; }
        public string? Change { get; set; }
        public string? Price { get; set; }
        public string? Changepercentage { get; set; }
        public string? Volume { get; set; }

    }
}

