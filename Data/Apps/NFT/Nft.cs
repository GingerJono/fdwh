using CardModel;
namespace NftData
{
     public class NftList
    {
        public string? Nft { get; set; }
        public string? Title { get; set; }
        public string? NftId { get; set; }
        public string? BidAmount { get; set; }
        public string? TotalNfts { get; set; }
    }
     public class NftTransaction
    {
        public string? Nft { get; set; }
        public string? Title { get; set; }
        public string? NftDesc { get; set; }
        public string? Duration { get; set; }
    }
    public class NftDataService {
        private List<NftMainCard> NftMainCardData = new List<NftMainCard>()
        {
             new NftMainCard { NftImg="../assets/images/nft-images/2.jpg",Title="Abstract Digital Art",Duration="04hrs : 24m : 38s",Likes="1.43k", UserImg="../assets/images/faces/14.jpg",UserImgSize="avatar-md",User="Manistics NFT",UserId="manistics454",BidAmount="0.015ETH"},

             new NftMainCard { NftImg="../assets/images/nft-images/3.jpg",Title="Abstract Digital Art",Duration="03hrs : 12m : 45s",Likes="1.43k", UserImg="../assets/images/faces/2.jpg",UserImgSize="avatar-md",User="Manistics NFT",UserId="manistics454",BidAmount="0.015ETH"},

             new NftMainCard { NftImg="../assets/images/nft-images/4.jpg",Title="Cyberpunk Creations",Duration="05hrs : 03m : 20s",Likes="1.43k", UserImg="../assets/images/faces/11.jpg",UserImgSize="avatar-md",User="CyberArt NFT",UserId="cyberartworks154",BidAmount="0.014ETH"},

             new NftMainCard { NftImg="../assets/images/nft-images/5.jpg",Title="Dreamscapes",Duration="02hrs : 50m : 55s",Likes="2.9k", UserImg="../assets/images/faces/12.jpg",UserImgSize="avatar-md",User="GeoNFT NFT",UserId="geonft_designs47",BidAmount="0.016ETH"},

             new NftMainCard { NftImg="../assets/images/nft-images/6.jpg",Title="Vibrant Pixel Art",Duration="06hrs : 15m : 10s",Likes="2.5k", UserImg="../assets/images/faces/3.jpg",UserImgSize="avatar-md",User="PixelPerfect",UserId="pixelperfectnft74",BidAmount="0.017ETH"},

             new NftMainCard { NftImg="../assets/images/nft-images/7.jpg",Title="Surreal Fantasy Art",Duration="01hrs : 58m : 23s",Likes="1.8k", UserImg="../assets/images/faces/14.jpg",UserImgSize="avatar-md",User="Fantasia NFT",UserId="fantasianft13",BidAmount="0.018ETH"},

             new NftMainCard { NftImg="../assets/images/nft-images/8.jpg",Title="Celestial Digital Art",Duration="03hrs : 45m : 50s",Likes="5.1k", UserImg="../assets/images/faces/6.jpg",UserImgSize="avatar-md",User="Celestial NFT",UserId="celestial_nft55",BidAmount="0.055ETH"},

             new NftMainCard { NftImg="../assets/images/nft-images/9.jpg",Title="Prismatic Universe",Duration="07hrs : 06m : 15s",Likes="1.64k", UserImg="../assets/images/faces/11.jpg",UserImgSize="avatar-md",User="Prisma NFT",UserId="prisma_universe77",BidAmount="0.035ETH"},

             
             new NftMainCard { NftImg="../assets/images/nft-images/10.jpg",Title="Prismatic Universe",Duration="02hrs : 50m : 55s",Likes="1.64k", UserImg="../assets/images/faces/12.jpg",UserImgSize="avatar-md",User="Prisma NFT",UserId="prisma_universe77",BidAmount="0.035ETH"},
             new NftMainCard { NftImg="../assets/images/nft-images/11.jpg",Title="Celestial Digital Art",Duration="02hrs : 50m : 55s",Likes="5.1k", UserImg="../assets/images/faces/15.jpg",UserImgSize="avatar-md",User="Prisma NFT",UserId="prisma_universe77",BidAmount="0.055ETH"},
             new NftMainCard { NftImg="../assets/images/nft-images/12.jpg",Title="Ethereal Dreams",Duration="01hrs : 58m : 23s",Likes="0.37k", UserImg="../assets/images/faces/13.jpg",UserImgSize="avatar-md",User="Ethereal NFT",UserId="ethereal_dreams",BidAmount="0.08ETH"},

             
             new NftMainCard { NftImg="../assets/images/nft-images/13.jpg",Title="Geometric Dreamscapes",Duration=" 03hrs : 12m : 45s ",Likes="2.9k", UserImg="../assets/images/faces/5.jpg",UserImgSize="avatar-md",User="GeoNFT NFT",UserId="geonft_designs47",BidAmount="0.016ETH"},
             new NftMainCard { NftImg="../assets/images/nft-images/14.jpg",Title="Celestial Digital Art",Duration=" 05hrs : 03m : 20s ",Likes="5.1k", UserImg="../assets/images/faces/8.jpg",UserImgSize="avatar-md",User="Celestial NFT ",UserId="celestial_nft55",BidAmount=" 0.055ETH"},

             
             new NftMainCard { NftImg="../assets/images/nft-images/15.jpg",Title="Surreal Fantasy Art",Duration=" 07hrs : 06m : 15s ",Likes="5.1k", UserImg="../assets/images/faces/6.jpg",UserImgSize="avatar-md",User="Fantasia NFT",UserId="fantasianft13",BidAmount="0.018ETH"},

             new NftMainCard { NftImg="../assets/images/nft-images/16.jpg",Title="Surreal Fantasy Art",Duration=" 07hrs : 06m : 15s ",Likes="5.1k", UserImg="../assets/images/faces/12.jpg",UserImgSize="avatar-md",User="PixelPerfect NFT",UserId="pixelperfectnft74",BidAmount= "0.017ETH"},

             new NftMainCard { NftImg="../assets/images/nft-images/17.jpg",Title="Geometric Dreamscapes",Duration=" 07hrs : 06m : 15s ",Likes="2.9k", UserImg="../assets/images/faces/15.jpg",UserImgSize="avatar-md",User="GeoNFT NFT ",UserId="geonft_designs47",BidAmount= "0.016ETH"},

             new NftMainCard { NftImg="../assets/images/nft-images/18.jpg",Title="Vibrant Pixel Art",Duration=" 07hrs : 06m : 15s ",Likes="2.9k", UserImg="../assets/images/faces/10.jpg",UserImgSize="avatar-md",User="PixelPerfect NFT",UserId="pixelperfectnft74",BidAmount= "0.017ETH"},

             new NftMainCard { NftImg="../assets/images/nft-images/5.jpg",Title="Geometric Dreamscapes",Duration=" 07hrs : 06m : 15s ",Likes="2.9k", UserImg="../assets/images/faces/11.jpg",UserImgSize="avatar-md",User="GeoNFT NFT",UserId="geonft_designs47",BidAmount= "0.016ETH "},

             new NftMainCard { NftImg="../assets/images/nft-images/7.jpg",Title="Vibrant Pixel Art",Duration=" 07hrs : 06m : 15s ",Likes="2.5k", UserImg="../assets/images/faces/16.jpg",UserImgSize="avatar-md",User="PixelPerfect NFT",UserId="pixelperfectnft74",BidAmount= "0.017ETH"},

             new NftMainCard { NftImg="../assets/images/nft-images/11.jpg",Title="Geometric Dreamscapes",Duration=" 07hrs : 06m : 15s ",Likes="2.9k", UserImg="../assets/images/faces/11.jpg",UserImgSize="avatar-md",User="GeoNFT NFT",UserId="geonft_designs47",BidAmount= "0.016ETH "},
        };
        public List<NftMainCard> GetNftMainCard() => NftMainCardData;
        
        private List<NftList> NftListData = new List<NftList>()
        {
             new NftList {Nft="../assets/images/nft-images/2.jpg",Title="Emily Watson",NftId="@emilywatson",BidAmount="+21.10ETH",TotalNfts="25"},
             new NftList {Nft="../assets/images/nft-images/18.jpg",Title="Daniel Green",NftId="@danielgreen",BidAmount="+18.75ETH",TotalNfts="20"},
             new NftList {Nft="../assets/images/nft-images/8.jpg",Title="Sophia Cruz",NftId="@sophiacruz",BidAmount="+15.90ETH",TotalNfts="18"},
             new NftList {Nft="../assets/images/nft-images/11.jpg",Title="Oliver Bennett",NftId="@oliverbennett",BidAmount="+14.25ETH",TotalNfts="16"},
             new NftList {Nft="../assets/images/nft-images/17.jpg",Title="Isabella Par",NftId="@isabella",BidAmount="+12.80ETH",TotalNfts="14"},
             new NftList {Nft="../assets/images/nft-images/31.png",Title="Liam Cooper",NftId="@liamcooper",BidAmount="+10.55ETH",TotalNfts="12"},
        };
        public List<NftList> GetNftListData() => NftListData;
        
        private List<NftTransaction> NftTransactionData = new List<NftTransaction>()
        {
             new NftTransaction {Nft="../assets/images/nft-images/31.png",Title="Galactic Treasures",NftDesc="Sold to <a class='text-decoration-underline' href='javascript:void(0);'>Mitchell</a> for <span class='text-success fw-medium fs-12'>0.57ETH</span>.",Duration="24 mins ago"},
             new NftTransaction {Nft="../assets/images/nft-images/25.png",Title="Galactic Treasures",NftDesc="Started following <span class='fw-medium'>Mark Zuckerberg</span>.",Duration="16 mins ago"},
             new NftTransaction {Nft="../assets/images/nft-images/21.png",Title="Digital Cosmos",NftDesc="Showed interest in purchasing <a href='javascript:void(0);' class='fs-12 text-warning fw-medium'>Digital Cosmos</a>.",Duration="5 mins ago"},
             new NftTransaction {Nft="../assets/images/nft-images/26.png",Title="Digital Cosmos",NftDesc="Purchased from <a href='javascript:void(0);' class='text-decoration-underline'>CyberCanvas</a> for <span class='fw-medium fs-12 text-pink'>1.345ETH</span>.",Duration="16 mins ago"},
             new NftTransaction {Nft="../assets/images/nft-images/21.png",Title="Cosmic Odyssey",NftDesc="Listed <span class='fw-medium'>Cosmic Odyssey</span> for auction.",Duration="30 mins ago"},
             new NftTransaction {Nft="../assets/images/nft-images/31.png",Title="Galactic Treasures",NftDesc="Gifted to <a href='javascript:void(0);' class='text-decoration-underline'>Alice</a> as a token of appreciation.",Duration="1 hour ago"},
        };
        public List<NftTransaction> GetNftTransactionData() => NftTransactionData;
    }
}