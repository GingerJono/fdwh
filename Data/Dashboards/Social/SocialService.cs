using Sandbox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardModel;

namespace Social
{
    public class SocialService
    {
        private List<Socialcard> SocialcardData = new List<Socialcard>()
        {
            new Socialcard {CardClass="insta",title="Instagram",titleClass="text-primary2",Value="457K",Duration="Followers ",IsIncreased=false,Percentage="1.5%"},
            new Socialcard {CardClass="linkedin",title="Linked In",titleClass="text-info",Value="457K",Duration="Followers ",IsIncreased=false,Percentage="1.5%"},
            new Socialcard {CardClass="fb",title="Facebook",titleClass="text-primary",Value="2.1K",Duration="1 hr ago",IsIncreased=false,Percentage="1.9%"},
            new Socialcard {CardClass="twit",title="Twitter",titleClass="text-dark",Value="2.1K",Duration="1 week ago",IsIncreased=true,Percentage="1.9%"},
            new Socialcard {CardClass="youtube",title="Youtube",titleClass="text-danger",Value="1.1M",Duration="1 day ago",IsIncreased=true,Percentage="1.9%"},
            new Socialcard {CardClass="msgr",title="Messenger",titleClass="text-secondary",Value="1.1M",Duration="1 day ago",IsIncreased=true,Percentage="1.9%"},
        };
        public List<Socialcard> GetSocialcardData() => SocialcardData;
        
        public static List<FollowOnDevice> GetFollowOnDevices()
        {
            var followondevice = new List<FollowOnDevice>();
               followondevice.Add(new FollowOnDevice { Device = "Mobile", DeviceValue = 1754 });
               followondevice.Add(new FollowOnDevice { Device = "Tablet", DeviceValue = 1234 });
               followondevice.Add(new FollowOnDevice { Device = "Desktop", DeviceValue = 878 });

            return followondevice;
        }
        
        public static List<Audience> GetAudience() {
            var audience = new List<Audience>();
            audience.Add(new Audience { Month = "Jan", Followers = 30, Views = 20, });
            audience.Add(new Audience { Month = "Feb", Followers = 58, Views = 38, });
            audience.Add(new Audience { Month = "Mar", Followers = 25, Views = 38, });
            audience.Add(new Audience { Month = "Apr", Followers = 42, Views = 72, });
            audience.Add(new Audience { Month = "May", Followers = 35, Views = 55, });
            audience.Add(new Audience { Month = "Jun", Followers = 33, Views = 73, });
            audience.Add(new Audience { Month = "Jul", Followers = 63, Views = 43, });
            audience.Add(new Audience { Month = "Aug", Followers = 25, Views = 55, });
            audience.Add(new Audience { Month = "Sep", Followers = 53, Views = 33, });
            audience.Add(new Audience { Month = "Oct", Followers = 57, Views = 45, });
            audience.Add(new Audience { Month = "Nov", Followers = 38, Views = 30, });
            audience.Add(new Audience { Month = "Dec", Followers = 40, Views = 60, });
            return audience;
        }
        private List<SocialTable> SocialTableData = new List<SocialTable>()
        {
            new SocialTable {Date="2024-02-15",PlatformImg="ri-youtube-fill",PlatformClass="bg-danger-transparent",Platform="Youtube",Likes="150",Comments="25",Shares="50",Impressions="10,000",ImpressionsClass="bg-primary-transparent",Engaged ="3.5%",Followers="458",Following="256",},

            new SocialTable {Date="2024-02-14",PlatformImg="ri-twitter-x-fill",PlatformClass="bg-dark-transparent",Platform="Twitter",Likes="200",Comments="30",Shares="70",Impressions="15,000",ImpressionsClass="bg-secondary-transparent",Engaged ="4.2%",Followers="565",Following="355",},

            new SocialTable {Date="2024-02-13",PlatformImg="ri-messenger-fill",PlatformClass="bg-info-transparent",Platform="Facebook",Likes="300",Comments="40",Shares="90",Impressions="20,000",ImpressionsClass="bg-success-transparent",Engaged ="5.0%",Followers="458",Following="956",},

            new SocialTable {Date="2024-02-12",PlatformImg="ri-instagram-fill",PlatformClass="bg-secondary-transparent",Platform="Instagram",Likes="100",Comments="20",Shares="30",Impressions="8,000",ImpressionsClass="bg-orange-transparent",Engaged ="2.1%",Followers="458",Following="256",},

            new SocialTable {Date="2024-02-11",PlatformImg="ri-twitter-x-fill",PlatformClass="bg-dark-transparent",Platform="Twitter",Likes="150",Comments="15",Shares="40",Impressions="12,000",ImpressionsClass="bg-info-transparent",Engaged ="3.0%",Followers="856",Following="295",},
        };
        public List<SocialTable> GetSocialTableData() => SocialTableData;
        public TableText[] SocialTableHeadersData = new TableText[] {
            new TableText { Title = "Date"},
            new TableText { Title = "Platform"},
            new TableText { Title = "Likes"},
            new TableText { Title = "Comments"},
            new TableText { Title = "Shares"},
            new TableText { Title = "Impressions"},
            new TableText { Title = "Engaged (%)"},
            new TableText { Title = "Followers"},
            new TableText { Title = "Following"},
        };        
        public TableText[] GetSocialTableHeadersData() => SocialTableHeadersData;
        private List<SocialList> SuggestionsData = new List<SocialList>()
        {
            new SocialList {UserImg ="../assets/images/faces/2.jpg",User ="Socrates Itumay",},
            new SocialList {UserImg ="../assets/images/faces/3.jpg",User ="Ryan Gercia",},
            new SocialList {UserImg ="../assets/images/faces/10.jpg",User ="Prax Bhav",},
            new SocialList {UserImg ="../assets/images/faces/12.jpg",User ="Jackie Chen",},
            new SocialList {UserImg ="../assets/images/faces/5.jpg",User ="Samantha Sam",},
            new SocialList {UserImg ="../assets/images/faces/15.jpg",User ="Robert Lewis",},
        };
        public List<SocialList> GetSuggestionsData() => SuggestionsData;
    }
}