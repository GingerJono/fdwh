
using CardModel;
namespace OrderdetailsData
{
    public class OrderdetailsList {
        
        public decimal Id { get; set; }        
        public string? Img { get; set; }
        public string? Title { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public string? OfferBadge { get; set; }
        public string? OfferBadgeClass { get; set; }
        public string? TrackingID { get; set; }
        public string? Price { get; set; }
        public string? Quantity { get; set; }
        public string? TotalPrice { get; set; }
    }
    public class OrderdetailsService {
        
        private List<OrderdetailsList> OrderdetailsListService = new List<OrderdetailsList>()
        {
            new OrderdetailsList { 
                Id = 1,
                Img = "../assets/images/ecommerce/png/28.png",
                Title = "Lightweight Sneakers", 
                Size ="Men's 10",
                Color ="Light Pink",
                TrackingID="SPK1218153635",
                Price="$1,249",
                Quantity="1",
                TotalPrice="$1,249",
            },
            new OrderdetailsList { 
                Id = 2,
                Img = "../assets/images/ecommerce/png/12.png",
                Title = "Kids' Party Wear Frock", 
                Size ="6-7 Years",
                Color ="Gold",
                OfferBadge ="In Offer",
                OfferBadgeClass ="bg-success",
                TrackingID="SPK3789423789",
                Price="$499",
                Quantity="2",
                TotalPrice="$998",
            },
            new OrderdetailsList { 
                Id = 3,
                Img = "../assets/images/ecommerce/png/29.png",
                Title = "Ladies' Slim Bag", 
                Size ="Small",
                Color ="Red",
                OfferBadge ="32% Off",
                OfferBadgeClass ="bg-primary",
                TrackingID="SPK1120324532",
                Price="$799",
                Quantity="1",
                TotalPrice="$799",
            },
            new OrderdetailsList { 
                Id = 4,
                Img = "../assets/images/ecommerce/png/14.png",
                Title = "Elegant Flower Pot", 
                Size ="33mm",
                Color ="Brown",
                TrackingID="SPK1218153635",
                Price="$1,249",
                Quantity="1",
                TotalPrice="$1,249",
            },
            new OrderdetailsList { 
                Id = 5,
                Img = "../assets/images/ecommerce/png/11.png",
                Title = "Trendy Sunglasses", 
                Size ="9",
                Color ="Light Gray",
                OfferBadge ="In Offer",
                OfferBadgeClass ="bg-success",
                TrackingID="SPK1218153635",
                Price="$1,249",
                Quantity="1",
                TotalPrice="$1,249",
            },
            new OrderdetailsList { 
                Id = 6,
                Img = "../assets/images/ecommerce/png/13.png",
                Title = "Sleek Modern Chair", 
                Size ="Small",
                Color ="Yellow",
                OfferBadge ="32% Off",
                OfferBadgeClass ="bg-primary",
                TrackingID="SPK1120324532",
                Price="$799",
                Quantity="1",
                TotalPrice="$799",
            },
        };
        public List<OrderdetailsList> GetOrderdetailsData() => OrderdetailsListService;
         public TableText[] OrderdetailsTableHeaders = new TableText[]
        {
            new TableText { Title = "Item" },
            new TableText { Title = "Tracking ID" },
            new TableText { Title = "Price" },
            new TableText { Title = "Quantity" },
            new TableText { Title = "Total Price" },
        };
        public TableText[] GetOrderdetailsHeadersData() => OrderdetailsTableHeaders;
       
    }
}