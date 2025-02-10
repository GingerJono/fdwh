
using CardModel;
namespace OrdersData
{
    public class OrdersList {
        public decimal Id { get; set; }
        public string? ProductImg { get; set; }
        public string? ClientImg { get; set; }
        public string? ProductName { get; set; }
        public string? ClientName { get; set; }
        public string? OrderId { get; set; }
        public string? OrderedDate { get; set; }
        public string? Paymentmode { get; set; }
        public string? Cost { get; set; }
        public string? Amount { get; set; }
        public string? Status { get; set; }
        public string? StatusColor { get; set; }
        public string? Mobilenumber { get; set; }
    }
    public class OrdersService {
        
        private List<OrdersList> OrdersListService = new List<OrdersList>()
        {
            new OrdersList { Id=1,ProductImg="../assets/images/ecommerce/png/28.png", Cost="$177.00", Paymentmode="Cash On Delivery", ProductName = "Lightweight Sneakers",ClientName="Violeta Tilly", ClientImg = "../assets/images/faces/4.jpg", OrderId = "#1172553", OrderedDate = "11 Jan 2024", Amount = "$212.45", Status = "Shipped",StatusColor="success", Mobilenumber = "(222) 111 - 57840" },

            new OrdersList { Id=2,ProductImg="../assets/images/ecommerce/png/12.png", Cost="$153.00", Paymentmode="Online Payment", ProductName = "Kids' Party Wear Frock",ClientName="Danny Raj", ClientImg = "../assets/images/faces/15.jpg", OrderId = "#1172555", OrderedDate = "23 Jan 2024", Amount = "$512.99", Status = "Pending",StatusColor="warning", Mobilenumber = "(222) 687-9954" },
            
            new OrdersList { Id=3,ProductImg="../assets/images/ecommerce/png/29.png", Cost="$203.00", Paymentmode="Cash On Delivery", ProductName = "Ladies' Slim Bag",ClientName="Sissera William", ClientImg = "../assets/images/faces/8.jpg", OrderId = "#1202513", OrderedDate = "19 Feb 2024", Amount = "$2199.49", Status = "Shipped",StatusColor="success", Mobilenumber = "(222) 987-1323" },

            new OrdersList { Id=4,ProductImg="../assets/images/ecommerce/png/14.png", Cost="$211.00", Paymentmode="Online Payment", ProductName = "Elegant Flower Pot",ClientName="Red Stark", ClientImg = "../assets/images/faces/11.jpg", OrderId = "#1202510", OrderedDate = "06 Mar 2024", Amount = "$1569.99", Status = "Cancelled",StatusColor="danger", Mobilenumber = "(222) 447-4518" },

            new OrdersList { Id=5,ProductImg="../assets/images/ecommerce/png/11.png", Cost="$265.00", Paymentmode="Cash On Delivery", ProductName = "Trendy Sunglasses",ClientName="Henry Milo", ClientImg = "../assets/images/faces/1.jpg", OrderId = "#1222516", OrderedDate = "18 Mar 2024", Amount = "$4,873.99", Status = "Shipped",StatusColor="success", Mobilenumber = "(222) 666-8080" },

            new OrdersList { Id=6,ProductImg="../assets/images/ecommerce/png/13.png", Cost="$203.00", Paymentmode="Cash On Delivery", ProductName = "Sleek Modern Chair",ClientName="Sissera William", ClientImg = "../assets/images/faces/8.jpg", OrderId = "#1202513", OrderedDate = "19 Feb 2024", Amount = "$1923.99", Status = "Shipped",StatusColor="success", Mobilenumber = "(222) 144-1423" },

            new OrdersList { Id=7,ProductImg="../assets/images/ecommerce/png/30.png", Cost="$211.00", Paymentmode="Online Payment", ProductName = "Wireless Headphones",ClientName="Red Stark", ClientImg = "../assets/images/faces/11.jpg", OrderId = "#1202510", OrderedDate = "06 Mar 2024", Amount = "$1,623.99", Status = "Cancelled",StatusColor="danger", Mobilenumber = "(222) 985-4715" },

            new OrdersList { Id=8,ProductImg="../assets/images/ecommerce/png/31.png", Cost="$265.00", Paymentmode="Cash On Delivery", ProductName = "Wireless Earbuds",ClientName="Henry Milo", ClientImg = "../assets/images/faces/1.jpg", OrderId = "#1222516", OrderedDate = "18 Mar 2024", Amount = "$3,423.99", Status = "Pending",StatusColor="warning", Mobilenumber = "(222) 887-1323" },
        };
        public List<OrdersList> GetOrdersData() => OrdersListService;
         public TableText[] OrdersTableHeaders = new TableText[]
        {
            new TableText { Title = "Order Id" },
            new TableText { Title = "Product" },
            new TableText { Title = "Customer" },
            new TableText { Title = "Mobile Number" },
            new TableText { Title = "Ordered Date" },
            new TableText { Title = "Status" },
            new TableText { Title = "Payment Mode" },
            new TableText { Title = "Cost" },
            new TableText { Title = "Action" },
        };
        public TableText[] GetOrdersHeadersData() => OrdersTableHeaders;
       
    }
}