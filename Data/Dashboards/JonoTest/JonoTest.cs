using CardModel;

namespace JonoTest{
    public class SalesReport {
        public string? Month { get; set; }
        public decimal Sales { get; set; }
        public decimal Profit { get; set; }
        public decimal Expenses { get; set; }
    } ;
    public class TotalOrders
    {
        public string? CircularRadialLabel { get; set; }
        public decimal Value { get; set; }
    }
    public class WebsiteDesign {
        public string? Series { get; set; }
        public decimal Projects { get; set; }
    } ;
    public class JonoTestTable {
        public decimal Id { get; set; }
        public string? OrderId  { get; set; }
        public string? Customer { get; set; }
        public string? CustomerName { get; set; }
        public string? Product { get; set; }
        public string? ProductName { get; set; }
        public string? Date { get; set; }
        public string? Amount { get; set; }
        public string? Status { get; set; }
        public string? statusclass { get; set; }
        public string? Category { get; set; }
        public string? Discount { get; set; }
    } ;
    
    public class Payments 
    {
        public int Id { get; set; }
        public string? Iconclass { get; set; }
        public string? Icon { get; set; }
        public string? Title { get; set; }
        public string? Percentage { get; set; }
    }
    public class TrafficSources 
    {
        public int Id { get; set; }
        public string? Iconclass { get; set; }
        public string? Icon { get; set; }
        public string? Title { get; set; }
        public string? Progressbg { get; set; }
        public string? Percentage { get; set; }
        public string? Value { get; set; }
        public bool IsIncreased { get; set; }
    }
}

