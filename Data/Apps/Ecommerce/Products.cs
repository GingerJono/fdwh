
using CardModel;
namespace ProductsData
{
    public class ProductList
    {
        public decimal ProductId { get; set; }
        public string? Product { get; set; }
        public string? ProductTitle { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? Price { get; set; }
        public string? Stock { get; set; }
        public string? BadgeClass { get; set; }
        public string? Status { get; set; }
        public string? Statusbadge { get; set; }
        public string? SellerImg { get; set; }
        public string? Seller { get; set; }
        public string? Published { get; set; }
        public bool Selected { get; set; }
    }
    public class ProductsService {
        private List<ProductCard> ProductsListService = new List<ProductCard>()
        {
           new ProductCard { 
                Id= 1,
                Img= "../../../assets/images/ecommerce/png/28.png",
                Title= "Lightweight Sneakers",
                Subtitle= "Stealth Series",
                Trendingtitle ="Trending",
                TrendingtitleClass="info",
                OfferBadge ="12% Off",
                OfferBadgeClass ="primary3",
                Rating= "(874)",
                DiscountPrice= "$771",
                ActualPrice= "$880",
            },
            new ProductCard { 
                Id= 2,
                Img= "../../../assets/images/ecommerce/png/12.png",
                Title= " KIds' Party Wear Frock",
                Subtitle= "Twinkle Twirl",
                OfferBadge ="15% Off",
                OfferBadgeClass ="info",
                Rating= "(231)",
                DiscountPrice= "$236",
                ActualPrice= "$267",
            },
            new ProductCard { 
                Id= 3,
                Img= "../../../assets/images/ecommerce/png/29.png",
                Title= "Ladies' Slim Bag",
                Subtitle= "Sleek Elegance",
                OfferBadge ="24% Off",
                OfferBadgeClass ="primary1",
                Rating= "(110)",
                DiscountPrice= "$124",
                ActualPrice= "$214",
            },
            new ProductCard { 
                Id= 4,
                Img= "../../../assets/images/ecommerce/png/14.png",
                Title= "Elegant Flower Pot",
                Subtitle= "Serene Garden",
                OfferBadge ="60% Off",
                OfferBadgeClass ="success",
                Rating= "(211)",
                DiscountPrice= "$314",
                ActualPrice= "$547",
            },
            new ProductCard { 
                Id= 5,
                Img= "../../../assets/images/ecommerce/png/11.png",
                Title= "Trendy Sunglasses",
                Subtitle= "Crystal Clear",
                OfferBadge ="10% Off",
                OfferBadgeClass ="primary2",
                Rating= "(514)",
                DiscountPrice= "$251",
                ActualPrice= "$399",
            },
            new ProductCard { 
                Id= 6,
                Img= "../../../assets/images/ecommerce/png/13.png",
                Title= "Sleek Modern Chair",
                Subtitle= "Artisanal Comfort",
                OfferBadge ="60% Off",
                OfferBadgeClass ="success",
                Rating= "(211)",
                DiscountPrice= "$314",
                ActualPrice= "$547",
            },
            new ProductCard { 
                Id= 7,
                Img= "../../../assets/images/ecommerce/png/23.png",
                Title= " Advanced Smartwatch",
                Subtitle= "SmartSync 2024",
                Trendingtitle ="Trending",
                TrendingtitleClass="danger",
                OfferBadge ="15% Off",
                OfferBadgeClass ="warning",
                Rating= "(255)",
                DiscountPrice= "$354",
                ActualPrice= "$455",
            },
            new ProductCard { 
                Id= 8,
                Img= "../../../assets/images/ecommerce/png/10.png",
                Title= "Classic T-Shirt ",
                Subtitle= "Casual Everyday",
                OfferBadge ="50% Off",
                OfferBadgeClass ="danger",
                Rating= "(142)",
                DiscountPrice= "$251",
                ActualPrice= "$399",
            },
            new ProductCard { 
                Id= 9,
                Img= "../../../assets/images/ecommerce/png/9.png",
                Title= " Versatile Hoodie",
                Subtitle= "Urban Flex",
                OfferBadge ="15% Off",
                OfferBadgeClass ="info",
                Rating= "(142)",
                DiscountPrice= "$251",
                ActualPrice= "$399",
            },
            new ProductCard { 
                Id= 10,
                Img= "../../../assets/images/ecommerce/png/30.png",
                Title= "Wireless Headphones",
                Subtitle= "SoundWave",
                OfferBadge ="21% Off",
                OfferBadgeClass ="primary1",
                Rating= "(142)",
                DiscountPrice= "$251",
                ActualPrice= "$399",
            },
            new ProductCard { 
                Id= 11,
                Img= "../../../assets/images/ecommerce/png/31.png",
                Title= " Wireless Earbuds",
                Subtitle= "AirPods Max",
                OfferBadge ="60% Off",
                OfferBadgeClass ="success",
                Rating= "(211)",
                DiscountPrice= "$314",
                ActualPrice= "$547",
            
            },
            new ProductCard { 
                Id= 12,
                Img= "../../../assets/images/ecommerce/png/11.png",
                Title= "Trendy Sunglasses",
                Subtitle= "Crystal Clear",
                OfferBadge ="10% Off",
                OfferBadgeClass ="primary2",
                Rating= "(514)",
                DiscountPrice= "$251",
                ActualPrice= "$399",
            },
        };
        public List<ProductCard> GetProductsData() => ProductsListService;
        private List<ProductCard> FeaturedListService = new List<ProductCard>()
        {
           new ProductCard {Id=1,Img="../assets/images/ecommerce/png/29.png",Title="Ladies' Slim Bag ",DiscountPrice="$1,099",ActualPrice="$1,759",Rating="(16K)"},
           new ProductCard {Id=2,Img="../assets/images/ecommerce/png/30.png",Title="Wireless Headphones",DiscountPrice="$7,99",ActualPrice="$1,299",Rating="(5k)"},
           new ProductCard {Id=3,Img="../assets/images/ecommerce/png/31.png",Title="Wireless Earbuds",DiscountPrice="$1,499",ActualPrice="$2,599",Rating="(2k)"},
           new ProductCard {Id=4,Img="../assets/images/ecommerce/png/32.png",Title="Voluptatem Alarm Clock ",DiscountPrice="$2,299",ActualPrice="$3,299",Rating="(12k)"},
           new ProductCard {Id=5,Img="../assets/images/ecommerce/png/28.png",Title="Lightweight Sneakers",DiscountPrice="$8,99",ActualPrice="$1,299",Rating="(12k)"},
        };
        public List<ProductCard> GetFeaturedData() => FeaturedListService;
        private List<ProductList> ProductListData = new List<ProductList>()
        {
            new ProductList { ProductId = 1, Product = "../assets/images/ecommerce/png/30.png", SellerImg="../assets/images/faces/4.jpg", Statusbadge="bg-primary-transparent", ProductTitle = " Wireless Headphones", Description = "SoundWave", Price = "$1,229", BadgeClass = "bg-secondary-transparent", Category = "Electronics", Stock = "283", Status = "Published", Seller = "Mayor Kelly", Published = "24,Nov 2023 - 04:42PM", },
            new ProductList { ProductId = 2, Product = "../assets/images/ecommerce/png/14.png", SellerImg="../assets/images/faces/15.jpg", Statusbadge="bg-danger-transparent", ProductTitle = " Elegant Flower Pot", Description = "Serene Garden",Price = "$799", BadgeClass = "bg-secondary-transparent", Category = "Ceramic", Stock = "98", Status = "Unpublished", Seller = "Andrew Garfield", Published = "18,Nov 2023 - 06:53AM", },
            new ProductList { ProductId = 3, Product = "../assets/images/ecommerce/png/31.png", SellerImg="../assets/images/faces/11.jpg", Statusbadge="bg-primary-transparent", ProductTitle = "Wireless Earbuds", Description = "AirPods Max", Price = "$2,499", BadgeClass = "bg-primary-transparent", Category = "Electronics", Stock = "194", Status = "Published", Seller = "Simon Cowel", Published = "12,Aug 2023 - 11:21AM", },
            new ProductList { ProductId = 4, Product = "../assets/images/ecommerce/png/12.png", SellerImg="../assets/images/faces/8.jpg", Statusbadge="bg-danger-transparent", ProductTitle = "Kids' Party Wear Frock", Description = "Twinkle Twirl", Price = "$899", BadgeClass = "bg-secondary-transparent", Category = "Fashion Wear", Stock = "267", Status = "Unpublished", Seller = "Mirinda Hers", Published = "05,Sep 2023 - 10:14AM", },
            new ProductList { ProductId = 5, Product = "../assets/images/ecommerce/png/32.png", SellerImg="../assets/images/faces/1.jpg", Statusbadge="bg-primary-transparent", ProductTitle = "Alarm Clock", Description = "Midest Brand", Price = "$499", BadgeClass = "bg-secondary-transparent", Category = "Home Needs", Stock = "143", Status = "Published", Seller = "Simon Cowel", Published = "18,Nov 2023 - 14:35PM", },
            new ProductList { ProductId = 6, Product = "../assets/images/ecommerce/png/23.png", SellerImg="../assets/images/faces/2.jpg", Statusbadge="bg-primary-transparent", ProductTitle = "Advanced Smartwatch", Description = "SmartSync 2024", Price = "$999", BadgeClass = "bg-primary-transparent", Category = "Watches", Stock = "365", Status = "Published", Seller = "Mirinda Hers", Published = "27,Nov 2023 - 05:12AM", },
            new ProductList { ProductId = 7, Product = "../assets/images/ecommerce/png/15.png", SellerImg="../assets/images/faces/9.jpg", Statusbadge="bg-danger-transparent", ProductTitle = "Sport shoe", Description = "Conit Brand", Price = "$1,499", BadgeClass = "bg-primary-transparent", Category = "Sports", Stock = "257", Status = "Unpublished", Seller = "Jhon Trendy", Published = "29,Nov 2023 - 16:32PM", },
        };
        public List<ProductList> GetProductLists() => ProductListData;
        
        public TableText[] ProductListHeaders = new TableText[]
        {
            new TableText { Title = "Product" },
            new TableText { Title = "Category" },
            new TableText { Title = "Price" },
            new TableText { Title = "Stock" },
            new TableText { Title = "Status" },
            new TableText { Title = "Seller" },
            new TableText { Title = "Published" },
            new TableText { Title = "Action" },
        };
        public TableText[] GetProductListHeadersData() => ProductListHeaders;
        private List<ProductCard> WishListsData = new List<ProductCard>()
        {
            new ProductCard {  Id = 1, Rating="(23)", OfferBadge="30% Off", DiscountPrice="$251", StockColor="text-success", Img = "../assets/images/ecommerce/png/29.png", Title = " Ladies' Slim Bag", ActualPrice = "$399", Stock = "In Stock",},
            new ProductCard {  Id = 2, Rating="(114)", OfferBadge="50% Off", DiscountPrice="$874", StockColor="text-danger", Img = "../assets/images/ecommerce/png/30.png", Title = " Wireless Headphones", ActualPrice = "$458", Stock = "Only 4 Left",},
            new ProductCard {  Id = 3, Rating="(15)", OfferBadge="10% Off", DiscountPrice="$48", StockColor="text-success", Img = "../assets/images/ecommerce/png/32.png", Title = "Voluptatem Alarm Clock", ActualPrice = "$57", Stock = "In Stock",},
            new ProductCard {  Id = 4, Rating="(15)", OfferBadge="25% Off", DiscountPrice="$1,578", StockColor="text-success", Img = "../assets/images/ecommerce/png/15.png", Title = "Sports Shoes", ActualPrice = "$1,077", Stock = "In Stock",},
            new ProductCard { CardClass="filter-bw", Id = 5, Rating="(15)", OfferBadge="25% Off", DiscountPrice="$1,578", StockColor="text-success", Img = "../assets/images/ecommerce/png/28.png", Title = "Lightweight Sneakers", ActualPrice = "$1,077", Stock = "Out of Stock",},
            new ProductCard { Id = 6, Rating="(27)", OfferBadge="14% Off", DiscountPrice="$687", StockColor="text-success", Img = "../assets/images/ecommerce/png/6.png", Title = "Chair with Cushion", ActualPrice = "$874", Stock = "In Stock",},
        };
        public List<ProductCard> GetWishLists() => WishListsData;

    }
}