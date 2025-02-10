using CardModel;
namespace Nft
{ 
    public class FeaturedList {
        public string? UserImg { get; set; }
        public string? User { get; set;}
        public string? UserId { get; set;}
        public string? Followers { get; set;}
        
    }
    public class Statistics {
        public string? Month { get; set; }
        public decimal LastYear { get; set; }
        public decimal ThisYear { get; set; }
    } 
    public class NftActivities {
        public string? NftImg { get; set; }
        public string? NftTitle { get; set; }
        public string? NftDesc { get; set; }
        public string? NftDate { get; set; }
    } 
    public class NftCollections {
        public string? Rank { get; set; }
        public string? CollectionImg { get; set; }
        public string? Collection { get; set; }
        public string? CollectionId { get; set; }
        public string? Volume { get; set; }
        public bool Hours { get; set; }
        public bool Days { get; set; }
        public string? Hourspercentage { get; set; }
        public string? Dayspercentage { get; set; }
        public string? Owners { get; set; }
        public string? Price { get; set; }
        public string? Items { get; set; }
    } 
    public class NftSeller {
        public string? SellerImg { get; set; }
        public string? Seller { get; set; }
        public string? SellerId { get; set; }
        public string? Price { get; set; }
    } 
}

