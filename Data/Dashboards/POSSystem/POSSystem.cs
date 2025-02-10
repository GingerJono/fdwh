using CardModel;

namespace POSSystem
{
    public class Orderlist {
        public int id { get; set; }
         public string? imgSrc { get; set; }
         public string? title { get; set; }
         public string? subtitle { get; set; }
         public string? quantity { get; set; }
         public string? price { get; set; }
         public string? discount { get; set; }
         public int Quantity { get; set; }
    } ;
    public class Productlist {
        public int id { get; set; }
        public string? imgSrc { get; set; }
        public string? title { get; set; }
        public string? category { get; set; }
        public string? price { get; set; }
        public string? orders { get; set; }
        public string? discount { get; set; }
        public string? discountcolor { get; set; }
    } ;
}

