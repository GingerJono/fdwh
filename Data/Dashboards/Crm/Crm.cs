using CardModel;
namespace Crm
{ 
    public class Profit {
        public int Series { get; set; }
        public decimal Profitvalue { get; set; }
    } ; 
    public class Revenue {
        public int Series { get; set; }
        public decimal revenuevalue { get; set; }
    } ; 
    public class CRMOverview {
        public string? Month { get; set; }
        public decimal Income { get; set; }
        public decimal Revenue { get; set; }
        public decimal Profit { get; set; }
    } ;
    public class Leads
    {
        public string? Year { get; set; }
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public int Value3 { get; set; }
        public int Value4 { get; set; }
    };

    public class SalesProfits {
        public int? Id { get; set;}
        public string? Icon { get; set;}
        public string? Color { get; set;}
        public string? Title { get; set;}
        public string? Desc { get; set;}
        public string? Value { get; set;}
        public string? Percentage { get; set;}
    }
    public class TasksList
    {  
        public decimal Id { get; set;}
        public string? Title { get; set;}
        public string? Desc { get; set;}
        public string? Icon { get; set;}
        public string? IconDesc { get; set;}
        public string? Color { get; set;}
        public string? Status { get; set;}
        public bool Selected { get; set;}
    }
    public class SalesTable 
    {  
        public decimal Id { get; set;}
        public string? Representative { get; set;}
        public string? RepresentativeImg { get; set;}
        public string? Deals  { get; set;}
        public string? Leads { get; set;}
        public string? Rate  { get; set;}
        public bool IsIncreased { get; set;}
    }
    public class LeadTable 
    {  
        public decimal Id { get; set;}
        public string? LeadImg { get; set;}
        public string? LeadName { get; set;}
        public string? LeadEmail { get; set;}
        public string? Company { get; set;}
        public string? Phone  { get; set;}
        public string? Status { get; set;}
        public string? Statusclass { get; set;}
        public string? Location  { get; set;}
        public string? Date  { get; set;}
        public string? Amount  { get; set;}
    }

}

