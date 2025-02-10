using Sandbox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardModel;

namespace Nft
{
    public class NftService
    {
        private List<NftMainCard> NftcardData = new List<NftMainCard>()
        {
            new NftMainCard{Duration="07hrs : 33m : 45s",NftImg="../assets/images/nft-images/10.jpg",Title="Vibrant Spec Cat NFT",Likes="1.43k",User="Kelinnies NFT",UserImg="../assets/images/faces/10.jpg",UserId="kelinnies05",BidAmount="0.045ETH" },
            new NftMainCard{Duration="07hrs : 33m : 45s",NftImg="../assets/images/nft-images/11.jpg",Title="Abstract Digital Art",Likes="1.43k",User="Manistics NFT",UserImg="../assets/images/faces/1.jpg",UserId="manistics454",BidAmount="0.015ETH" },
            new NftMainCard{Duration="07hrs : 33m : 45s",NftImg="../assets/images/nft-images/9.jpg",Title="Majestic Alpha Wolf",Likes="1.43k",User="Haridar NFT",UserImg="../assets/images/faces/11.jpg",UserId="haridar687",BidAmount="0.045ETH" },
            new NftMainCard{Duration="07hrs : 33m : 45s",NftImg="../assets/images/nft-images/4.jpg",Title="Radiant Blossom NFT",Likes="1.43k",User="Mostee NFT",UserImg="../assets/images/faces/12.jpg",UserId="mostee897",BidAmount=" 0.03ETH" },
            new NftMainCard{Duration="07hrs : 33m : 45s",NftImg="../assets/images/nft-images/5.jpg",Title="Vibrant Tropical Fishes",Likes="1.43k",User="Cheston NFT",UserImg="../assets/images/faces/4.jpg",UserId="cheston541",BidAmount="0.012ETH" },
            new NftMainCard{Duration="07hrs : 33m : 45s",NftImg="../assets/images/nft-images/6.jpg",Title="Ethereal Elegance NFT",Likes="1.43k",User="Cornaote NFT",UserImg="../assets/images/faces/6.jpg",UserId="Cornaote245",BidAmount="0.025ETH" },
        };
        public List<NftMainCard> GetNftcardData() => NftcardData;
        private List<FeaturedList> FeaturedcardData = new List<FeaturedList>()
        {
            new FeaturedList{UserImg="../assets/images/faces/1.jpg",User="Meesthi Si",UserId="@meesthi05",Followers="<div class='avatar-list-stacked'><span class='avatar avatar-sm bg-primary1-transparent border border-primary1 border-opacity-10 avatar-rounded'><img src='../assets/images/nft-images/3.jpg' alt='' class='p-1 rounded-circle'></span><span class='avatar avatar-sm bg-primary3 avatar-rounded border border-primary1 border-opacity-10'>+2</span></div>"},
            
            new FeaturedList{UserImg="../assets/images/faces/4.jpg",User="Oorichimaru lo",UserId="@ooro001",Followers="<span class='avatar avatar-sm bg-primary3-transparent border border-primary1 border-opacity-10 avatar-rounded'><img src='../assets/images/nft-images/11.jpg' alt='' class='p-1 rounded-circle'></span>"},

            new FeaturedList{UserImg="../assets/images/faces/2.jpg",User="Moniket Ms",UserId="@moniket98",Followers="<div class='avatar-list-stacked'><span class='avatar avatar-sm bg-primary1-transparent border border-primary1 border-opacity-10 avatar-rounded'><img src='../assets/images/nft-images/5.jpg' alt='' class='p-1 rounded-circle'></span><span class='avatar avatar-sm bg-primary1 avatar-rounded border border-primary1 border-opacity-10'>+1</span></div>"},

            new FeaturedList{UserImg="../assets/images/faces/12.jpg",User="SakuraYM",UserId="@sakura903",Followers="<span class='avatar avatar-sm bg-primary1-transparent border border-primary1 border-opacity-10 avatar-rounded'><img src='../assets/images/nft-images/8.jpg' alt='' class='p-1 rounded-circle'></span>"},

            new FeaturedList{UserImg="../assets/images/faces/2.jpg",User="Sasuke Uchiha",UserId="@sasuke777",Followers="<div class='avatar-list-stacked'><span class='avatar avatar-sm bg-primary1-transparent border border-primary1 border-opacity-10 avatar-rounded'><img src='../assets/images/nft-images/5.jpg' alt='' class='p-1 rounded-circle'></span><span class='avatar avatar-sm bg-primary2 avatar-rounded border border-primary1 border-opacity-10'>+3</span></div>"},

            new FeaturedList{UserImg="../assets/images/faces/15.jpg",User="Tomarko Ki",UserId="@tomarko98",Followers="<span class='avatar avatar-sm bg-primary1-transparent border border-primary1 border-opacity-10 avatar-rounded'><img src='../assets/images/nft-images/4.jpg' alt='' class='p-1 rounded-circle'></span>"},
        };
        public List<FeaturedList> GetFeaturedcardData() => FeaturedcardData;
        
        public static List<Statistics> GetStatisticsData() {
            var statistics = new List<Statistics>();
            statistics.Add(new Statistics { Month = "Jan", LastYear = 47, ThisYear = 35, });
            statistics.Add(new Statistics { Month = "Feb", LastYear = 43, ThisYear = 60, });
            statistics.Add(new Statistics { Month = "Mar", LastYear = 55, ThisYear = 41, });
            statistics.Add(new Statistics { Month = "Apr", LastYear = 55, ThisYear = 57, });
            statistics.Add(new Statistics { Month = "May", LastYear = 41, ThisYear = 52, });
            statistics.Add(new Statistics { Month = "Jun", LastYear = 41, ThisYear = 63, });
            statistics.Add(new Statistics { Month = "Jul", LastYear = 53, ThisYear = 41, });
            statistics.Add(new Statistics { Month = "Aug", LastYear = 42, ThisYear = 41, });
            statistics.Add(new Statistics { Month = "Sep", LastYear = 47, ThisYear = 65, });
            statistics.Add(new Statistics { Month = "Oct", LastYear = 41, ThisYear = 65, });
            statistics.Add(new Statistics { Month = "Nov", LastYear = 50, ThisYear = 53, });
            statistics.Add(new Statistics { Month = "Dec", LastYear = 35, ThisYear = 57, });
            return statistics;
        }
        private List<NftActivities> NftActivitiesData = new List<NftActivities>()
        {
            new NftActivities{NftImg="../assets/images/nft-images/2.jpg",NftTitle="Auction started For <span class='text-primary'>Luminous Petal</span>",NftDesc="<span class='text-muted fs-12'>Monisteris (@monisteris547)</span>",NftDate="5 mins ago"},

            new NftActivities{NftImg="../assets/images/nft-images/3.jpg",NftTitle="Bid placed on <span class='text-primary'>Radium Radiance</span><span class='text-muted'> #isther457</span>",NftDesc="<span class='text-muted fs-12'>Isther (@isther457)</span>",NftDate="2 Days ago"},

            new NftActivities{NftImg="../assets/images/nft-images/4.jpg",NftTitle="Artwork sold to <span class='text-primary'>@Lanisis</span>",NftDesc="<span class='text-muted fs-12'>Rokonis (@rokonis658)</span>",NftDate="3 Days ago"},

            new NftActivities{NftImg="../assets/images/nft-images/7.jpg",NftTitle="New Arrivals form New one <span class='text-primary1'>@kanith</span>",NftDesc="<span class='text-muted fs-12'>Kanith (@kanith6589)</span>",NftDate="3 Days ago"},

            new NftActivities{NftImg="../assets/images/nft-images/5.jpg",NftTitle="New artwork uploaded <span class='text-primary'>@fister124</span>",NftDesc="<span class='text-muted fs-12'>Simon(@simon145)</span>",NftDate="5 Days ago"},

            new NftActivities{NftImg="../assets/images/nft-images/6.jpg",NftTitle="New collection created.",NftDesc="<div class='d-flex align-items-center gap-2'><span class='text-muted fs-12 align-middle'>Joviskin (@joviskin124)</span><span class='avatar avatar-xs bg-primary1-transparent border border-primary1 border-opacity-10'><img src='../assets/images/nft-images/11.jpg' alt=''></span></div>",NftDate="5 Days ago"},
        };
        public List<NftActivities> GetNftActivitiesData() => NftActivitiesData;
        public TableText[] CollectionsHeadersData = new TableText[]
        {
            new TableText { Title = "Rank" },
            new TableText { Title = "Collection" },
            new TableText { Title = "Volume" },
            new TableText { Title = "24h %" },
            new TableText { Title = "Owners" },
            new TableText { Title = "7d %" },
            new TableText { Title = "Floor Price" },
            new TableText { Title = "Items" },
        };        
        public TableText[] GetCollectionsHeadersData() => CollectionsHeadersData;
        
        private List<NftCollections> NftCollectionsData = new List<NftCollections>()
        {
            new NftCollections{Rank="#1",CollectionImg="../assets/images/nft-images/9.jpg",Collection="Starter Sense NFT",CollectionId="@irukasensei229",Volume="2.56ETH",Hours=true,Hourspercentage="15.2%",Owners="99.4K",Days=true,Dayspercentage="3.1%",Price="2.31ETH",Items="	12.4K"},

            new NftCollections{Rank="#2",CollectionImg="../assets/images/nft-images/10.jpg",Collection="Lorem Kekkei",CollectionId="@clansound209",Volume="1.25ETH",Hours=true,Hourspercentage="3.7%",Owners="22.1K",Days=false,Dayspercentage="0.5%",Price="0.25ETH",Items="10.1K"},

            new NftCollections{Rank="#3",CollectionImg="../assets/images/nft-images/11.jpg",Collection="NFT Uchiha",CollectionId="@sasukeuhi990",Volume="2,092ETH",Hours=false,Hourspercentage="23.1%",Owners="55.3K",Days=true,Dayspercentage="9.12%",Price="2,000ETH",Items="52.7K"},

            new NftCollections{Rank="#4",CollectionImg="../assets/images/nft-images/12.jpg",Collection="Lorem Ipsum Uch",CollectionId="@kakashi092",Volume="36.25ETH",Hours=false,Hourspercentage="5.2%",Owners="66.3K",Days=false,Dayspercentage="4.1%",Price="30.12ETH",Items="31.4K"},
        };
        public List<NftCollections> GetNftCollectionsData() => NftCollectionsData;
        
        private List<NftSeller> NftSellerData = new List<NftSeller>()
        {
            new NftSeller{SellerImg="../assets/images/nft-images/14.jpg",Seller="Meesthi Si",SellerId="@meesthi03",Price="0.05ETH"},
            new NftSeller{SellerImg="../assets/images/nft-images/15.jpg",Seller="Tomarko Parizi",SellerId="@tomarko98",Price="0.05ETH"},
            new NftSeller{SellerImg="../assets/images/nft-images/16.jpg",Seller="Kazimo Aruke",SellerId="@kazimo900",Price="0.05ETH"},
            new NftSeller{SellerImg="../assets/images/nft-images/17.jpg",Seller="Oorichimaru lo",SellerId="@ooro001",Price="0.05ETH"},
            new NftSeller{SellerImg="../assets/images/nft-images/18.jpg",Seller="Sasuke Uchiha",SellerId="@sasuke777",Price="0.05ETH"},
            new NftSeller{SellerImg="../assets/images/nft-images/3.jpg",Seller="Nagiro Ohinavo",SellerId="@nagiro096",Price="0.05ETH"},
        };
        public List<NftSeller> GetNftSellerData() => NftSellerData;
    }
}