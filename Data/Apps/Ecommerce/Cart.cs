
using CardModel;
namespace CartData
{
    public class CartList {
        
        public decimal CartId { get; set; }        
        public string? Img { get; set; }
        public string? Title { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public bool Instock { get; set; }
        public string? OfferBadge { get; set; }
        public string? OfferBadgeClass { get; set; }
        public string? Price { get; set; }
        public string? Total { get; set; }
        public bool IsDeleting { get; set; }
        public int Quantity { get; set; }
    }
    public class CartService {
        
        private List<CartList> CartListService = new List<CartList>()
        {
            new CartList { 
                CartId = 1,
                Img = "../assets/images/ecommerce/png/1.png",
                Title = "Compact Laptop ", 
                Size ="Compact",
                Color ="Grey",
                OfferBadgeClass ="bg-primary3",
                OfferBadge ="20 OFF",
                Instock =true,
                Price ="$554",
                Total ="$554",
                Quantity=1
            },
            new CartList { 
                CartId = 2,
                Img = "../assets/images/ecommerce/png/7.png",
                Title = "Bespoke Hand Bag", 
                Size ="Medium",
                Color ="Deep Lavendar",
                Instock =false,
                Price ="$187",
                Total ="$374",
                Quantity=2
            },
            new CartList { 
                CartId = 3,
                Img = "../assets/images/ecommerce/png/15.png",
                Title = "StrideMax Shoes ", 
                Size ="44mm dial",
                Color ="Bronze ",
                OfferBadgeClass ="bg-info",
                OfferBadge ="12 OFF",
                Instock =true,
                Price ="503",
                Total ="1,006",
                Quantity=2
            },
            new CartList { 
                CartId = 4,
                Img = "../assets/images/ecommerce/png/12.png",
                Title = "Kids' Party Wear Frock", 
                Size ="Medium",
                Color ="Light Pink",
                Instock =false,
                Price ="248",
                Total ="248",
                Quantity=1
            },
            new CartList { 
                CartId = 5,
                Img = "../assets/images/ecommerce/png/3.png",
                Title = "Trendy Sunglasses", 
                Size ="Large",
                Color ="Black",
                Instock =true,
                Price ="1,299",
                Total ="1,299",
                Quantity=1
            },
        };
        public List<CartList> GetCartData() => CartListService;
         public TableText[] CartTableHeaders = new TableText[]
        {
            new TableText { Title = "Product Name" },
            new TableText { Title = "Price" },
            new TableText { Title = "Quantity" },
            new TableText { Title = "Total" },
            new TableText { Title = "Action" },
        };
        public TableText[] GetCartHeadersData() => CartTableHeaders;
       
    }
}