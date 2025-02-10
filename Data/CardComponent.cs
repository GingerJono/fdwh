 namespace CardModel
{
    public class CountryCardModel {
            public decimal id { get; set; }
            public string? img { get; set; }
            public string? title { get; set; }
            public string? value { get; set; }
            public string? color { get; set; }
            public string? percent { get; set; }
            public string? customclass { get; set; }
    }; 
    public class MainCard {
            public decimal id { get; set; }
            public string? title { get; set; }
            public bool IsRounded { get; set; }
            public bool MainBgImg { get; set; }
            public string? icon { get; set; }
            public string? svg { get; set; }
            public string? iconclass { get; set; }
            public string? price { get; set; }
            public string? status { get; set; }
            public string? statusclass { get; set; }
            public string? statusdata { get; set; }
            public string? statusicon { get; set; }
            public string? color { get; set; }
            public bool IsIncreased { get; set; }
            public string? percentage { get; set; }
            public string? Badge { get; set; }
            public string? BadgeValue { get; set; }
    }; 
    public class ActivityCard {
        public string? ActivityUser { get; set; }
        public string? ActivityTime { get; set; }
        public string? ActivityDesc { get; set; }
    }; 
    public class AnalyticMainChart {

        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Icon { get; set; }
        public string? IconClass { get; set; }
        public string? TotalValue { get; set; }
        public string? Percentage { get; set; }
        public bool? IsIncreased { get; set; }
    };
    public interface ILineGraph
    {
        decimal Series { get; set; }
        decimal Value { get; set; }
    }
    public class ProductList {
        public int Id { get; set; }
        public string? Product { get; set; }
        public string? Productsize { get; set; }
        public string? ProductTitle { get; set; }
        public string? Category { get; set; }
        public string? Amount { get; set; }
        public string? Sales { get; set; }
        public bool IsRounded { get; set; }
    }
    public class ProductActivity {
        public int Id { get; set; }
        public string? IconSize { get; set; }
        public string? Iconclass { get; set; }
        public string? Icon { get; set; }
        public string? Title { get; set; }
        public string? TitleClass { get; set; }
        public string? Desc { get; set; }
        public string? DescClass { get; set; }
        public string? Duration { get; set; }
        public bool Durationopacity { get; set; }
        public string? ChildContent { get; set; }
        public string? Activityclass { get; set; }
    }
    public class Crmprofit {
        public string? Icon { get; set; }
        public string? Cardclass { get; set; }
        public string? Title { get; set; }
        public string? Value { get; set; }
        public string? Badge { get; set; }
        public string? BadgeValue { get; set; }
        public bool IsIncreased { get; set; }
    };
    public class TableText
    {
        public string Title { get; set; } = string.Empty;
    }
    public class HrmMainCard {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? TotalValue { get; set; }
        public string? Percentage { get; set; }
        public bool IsIncreased { get; set; }
    };      
    public class NftMainCard {
        public string? NftImg { get; set; }
        public string? Duration { get; set; }
        public string? Likes { get; set; }
        public string? Title { get; set; }
        public string? UserImg { get; set; }
        public string? UserImgSize { get; set; }
        public string? User { get; set; }
        public string? UserId { get; set; }
        public string? BidAmount { get; set; }
    };
    public class CryptoMainChart {
        public string? CryptoImg { get; set; }
        public string? CryptoIcon { get; set; }
        public string? CryptoIconClass { get; set; }
        public string? CryptoTitle { get; set; }
        public string? CryptoSubTitle { get; set; }
        public string? CryptoValue { get; set; }
        public string? CryptoUsd { get; set; }
        public bool IsIncreased { get; set; }
        public string? Percentage { get; set; }
    };
    public class MedicalCard {
        public string? Medicalprice { get; set; }
        public string? Medicaltitle { get; set; }
        public string? Medicalpercent { get; set; }
        public string? MedicalsvgIcon { get; set; }
        public bool IsIncreased { get; set; }
    };
    public class Poscard {
        public string? imgSrc{ get; set; }
        public string? title{ get; set; }
        public string? item{ get; set; }
        public string? price{ get; set; }
        public string? Category{ get; set; }
        public bool InStock { get; set; }
    }
    public class Schoolcard {
        public string? Svg{ get; set; }
        public string? SvgClass{ get; set; }
        public string? title{ get; set; }
        public string? Value { get; set; }
    }
    public class Socialcard {
        public string? CardClass{ get; set; }
        public string? title{ get; set; }
        public string? titleClass{ get; set; }
        public string? Value { get; set; }
        public bool IsIncreased { get; set; }
        public string? Percentage { get; set; }
        public string? Duration { get; set; }
    }
    public class ProductCard {

        public int Id { get; set; }        
        public string? Img{ get; set; }
        public string? Title{ get; set; }
        public string? Trendingtitle { get; set; }
        public string? TrendingtitleClass{ get; set; }
        public string? OfferBadge { get; set; }
        public string? OfferBadgeClass { get; set; }
        public string? Rating { get; set; }
        public string? Subtitle { get; set; }
        public string? DiscountPrice { get; set; }
        public string? ActualPrice { get; set; }
        public string? Stock { get; set; }
        public string? StockColor { get; set; }
        public string? CardClass { get; set; }
    }
    public class Activity {
        public int Id { get; set; }
        public string? Avatarcolor { get; set; }
        public string? Img { get; set; }
        public string? Value { get; set; }
        public string? Title { get; set; }
        public string? Duration { get; set; }
        public string? Desc { get; set; }
        public List<Team>? AssignedTo { get; set; }
        public List<Media>? Media { get; set; }
        public List<Tags>? Tags { get; set; }
        public string? Comment { get; set; }
        public string? Like { get; set; }
        public string? Like1 { get; set; }
    }
    public class Team
    {
        public string? Img { get; set; }      
    }    
    public class Media
    {
        public string? Img { get; set; }
        public string? Desc { get; set; }
    }
    public class Tags
    {
        public string? Tag { get; set; }      
    }    
    public class MarketCap {
        public string? CryptoImg { get; set; }
        public string? CryptoTitle { get; set; }
        public string? CryptoSubTitle { get; set; }
        public string? CryptoValue { get; set; }
        public string? CryptoValue2 { get; set; }
        public string? CryptoValue2Sub { get; set; }
        public string? Volume { get; set; }
        public string? CryptoRatio { get; set; }
        public string? CryptoUsd { get; set; }
        public bool IsIncreased { get; set; }
        public string? Percentage { get; set; }
    };    
    public class Reviews {
        public decimal Id { get; set; }
        public string? UserImg { get; set; }
        public string? User { get; set; }
        public string? Email { get; set; }
        public string? Designation { get; set; }
        public double Rating { get; set; } 
        public double Rate { get; set; } 
        public string? RateColor { get; set; } 
        public decimal Views { get; set; }
        public string? Review { get; set; }
    };    
}
