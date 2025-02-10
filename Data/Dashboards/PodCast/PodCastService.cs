using Sandbox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardModel;

namespace PodCast
{
    public class PodCastService{
        public List<Categories> Categoriesdata  = new List<Categories>{
            new Categories{id = 1, icon = "ri-macbook-line", color = "primary", data = "Technology", data1 = "250"},
            new Categories{id = 2, icon = "ri-briefcase-2-line", color = "primary1", data = "Business", data1 = "236"},
            new Categories{id = 3, icon = "ri-heart-pulse-line", color = "primary2", data = "Health", data1 = "236"},
            new Categories{id = 4, icon = "ri-football-line", color = "primary3", data = "Sports", data1 = "236"},
            new Categories{id = 5, icon = "ri-flask-line", color = "secondary", data = "Science", data1 = "236"},
            new Categories{id = 6, icon = "ri-book-line", color = "warning", data = "Education", data1 = "236"},
            new Categories{id = 7, icon = "ri-disc-line", color = "info", data = "Music", data1 = "236"},
            new Categories{id = 8, icon = "ri-tv-line", color = "danger", data = "Entertainment", data1 = "236"},
        };        
        public List<Categories> GetCategoriesdata () => Categoriesdata ;
        
        public List<PopularPodcastList> PopularPodcastdata  = new List<PopularPodcastList>{
            new PopularPodcastList{id = 1,title ="Foodie Adventures",author ="By Chef Mia Johnson",image ="../../assets/images/podcast/6.jpg",listeners ="75.3k",},
            new PopularPodcastList{id = 2,title ="Environmental Insights",author ="By Dr. David Green",image ="../../assets/images/podcast/7.jpg",listeners ="75.3k",},
            new PopularPodcastList{id = 3,title ="Travel Tales",author ="By Wanderlost Explorers",image ="../../assets/images/podcast/7.jpg",listeners ="75.3k",},
            new PopularPodcastList{id = 4,title ="True Crime Files",author ="By Detective John Smith",image ="../../assets/images/podcast/9.jpg",listeners ="75.3k",},
            new PopularPodcastList{id = 5,title ="Science Explained",author ="Dr. Michael Lee",image ="../../assets/images/podcast/8.jpg",listeners ="75.3k",},
            new PopularPodcastList{id = 6,title ="Business Buzz",author ="By Emily Davis",image ="../../assets/images/podcast/8.jpg",listeners ="75.3k",},
        };        
        public List<PopularPodcastList> GetPopularPodcastdata () => PopularPodcastdata ;
        
        public TableText[] PlayedListHeadersData = new TableText[]
        {
            new TableText { Title = "Podcast Name"},
            new TableText { Title = "Duration"},
            new TableText { Title = "Category"},
            new TableText { Title = "Latest Episode"},
            new TableText { Title = "Average Duration"},
            new TableText { Title = "Favourites"},
            new TableText { Title = "Action"},
        };        
        public TableText[] GetPlayedListHeadersData() => PlayedListHeadersData;   
        public List<PlayedList> PlayedListdata  = new List<PlayedList>{
            new PlayedList{id =1,podcastImg ="../assets/images/podcast/6.jpg",podcast ="Whimsical Wonders",Player ="Emily Watson",duration ="150s",category ="Comedy",color ="secondary",latest ="#156: Silly Stories",avg ="45 mins",favourite =true,},
            new PlayedList{id =2,podcastImg ="../assets/images/podcast/7.jpg",podcast ="Mindful Meditations",Player ="Sarah Johnson",duration ="1 min",category ="Culture",color ="success",latest ="#82: Deep Nonsense",avg ="30 mins",favourite =false,},
            new PlayedList{id =3,podcastImg ="../assets/images/podcast/8.jpg",podcast ="Deep Dive Dialogues",Player ="John Doe",duration ="2 min",category ="Personal Journal",color ="info",latest ="#30: Life's Random Moments",avg ="60 mins",favourite =true,},
            new PlayedList{id =4,podcastImg ="../assets/images/podcast/9.jpg",podcast ="Random Revelations",Player ="Sophia Brown",duration ="3 min",category ="News and Politics",color ="warning",latest ="#300: Current Affairs",avg ="20 mins",favourite =false,},
            new PlayedList{id =5,podcastImg ="../assets/images/media/media-60.jpg",podcast ="Bite-sized Banter",Player ="Michael Smith",duration ="4 min",category ="Food and Drink",color ="primary",latest ="#45: Culinary Capers",avg ="50 mins",favourite =true,},
        };        
        public List<PlayedList> GetPlayedListdata () => PlayedListdata ;
    }
}
