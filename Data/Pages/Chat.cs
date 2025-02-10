
namespace ChatData
{
    public class ChatList
    {
        public int id { get; set; }
        public string? img { get; set; }
        public string? email { get; set; }
        public string? name { get; set; }
        public bool imgavatar {get;set;}
        public string? avatarname {get;set;}
        public string? avatarBackgroundColor {get;set;}
        public string? lastMsg { get; set; }
        public bool isOnline { get; set; }
        public bool isTyping { get; set; }
        public bool seen { get; set; }
        public string? unReadMessages { get; set; }
        public string? lastMessageTime { get; set; }
        public string? whoslastMsg { get; set; }
        public string? howisTyping { get; set; }
        public bool allSeen { get; set; }
        public bool active { get; set; } 
    } 
    public class GalleryList {
        public string? Img { get; set; }
    }
    public class ChatService {
        private List<ChatList> ActiveChats = new List<ChatList>()
        {  
            new ChatList {
                id= 1, img= "../assets/images/faces/5.jpg", email= "RashidKhan@mail.com", name= "Rashid Khan", lastMsg= "Hey!! you are there? &#128522;", active= false, isOnline= true, isTyping= false, seen= false, unReadMessages= "3", lastMessageTime= "11:12PM"
            },
            new ChatList {
                id= 2, img= "../assets/images/faces/2.jpg", email= "JamisonJen@mail.com", name= "Jamison Jen", lastMsg= "", active= false, isOnline= true, isTyping= true, seen= false, unReadMessages= "", lastMessageTime= "06:52AM"
            },
            new ChatList {
                id= 3, img= "../assets/images/faces/10.jpg", email= "AndyMax@mail.com", name= "Andy Max", lastMsg= "Great! I am happy to here this from you. &#9749;", active= false, isOnline= true, isTyping= false, seen= true, unReadMessages= "", lastMessageTime= "10:15AM"
            },
            new ChatList {
                id= 4, img= "../assets/images/faces/6.jpg", email= "KerinaCherish@mail.com", name= "Kerina Cherish", lastMsg= "Looking forward about the matter", active= false, isOnline= true, isTyping= false, seen= true, unReadMessages= "", lastMessageTime= "03:15PM"
            },
        };        
        public List<ChatList> GetActiveChatsData() => ActiveChats;
        private List<ChatList> AllChats = new List<ChatList>()
        {
            new ChatList {id= 5, img= "../assets/images/faces/11.jpg", email= "RonyErick@mail.com", name= "Rony Erick", lastMsg= "You should come definately&#127916;",lastMessageTime= "04:13PM"},
            new ChatList {id= 6, img= "../assets/images/faces/3.jpg", email= "Kenathkin@mail.com", name= "Kenath kin", lastMsg= "Did you remember the date",lastMessageTime= "12:46AM"},
            new ChatList {id= 7, img= "../assets/images/faces/13.jpg", email= "ThomasLie@mail.com", name= "Thomas Lie", lastMsg= "Hi, Thank you for everything",lastMessageTime= "07:30PM"},
            new ChatList {id= 8, img= "../assets/images/faces/4.jpg", email= "PeterStark@mail.com", name= "Peter Stark", lastMsg= "Going to Australia!",lastMessageTime= "01:18PM"},
            new ChatList {id= 9, img= "../assets/images/faces/13.jpg", email= "MonteChrist@mail.com", name= "Monte Christ", lastMsg= "Little Busy &#127829;",lastMessageTime= "08:07PM"},
            new ChatList {id= 10, img= "../assets/images/faces/15.jpg", email= "ReginaMos@mail.com", name= "Regina Mos", lastMsg= "Have a Question?",lastMessageTime= "09:19PM"},
        };
        public List<ChatList> GetAllChatsData() => AllChats;
        private List<ChatList> GroupData = new List<ChatList>()
        {
            new ChatList {
                id= 1, img= "../assets/images/faces/17.jpg", email= "chatMinglecollective &#128525; @mail.com", name= "ChatMingle Collective &#128525;", whoslastMsg= "", lastMsg= "", active= false, isOnline= true, isTyping= true, howisTyping= "Hira", allSeen= false, seen= true, unReadMessages= "2", lastMessageTime= "12:24PM"
            },
            new ChatList {
                id= 2, img= "../assets/images/faces/18.jpg", email= "connectHubcrew@mail.com", name= "ConnectHub Crew", whoslastMsg= "Rams:", lastMsg= "Happy to be part of this group", active= false, isOnline= true, isTyping= false, howisTyping= "", allSeen= true, seen= false, unReadMessages= "", lastMessageTime= "1:16PM"
            },
            new ChatList {
                id= 3, img= "../assets/images/faces/19.jpg", email= "talkTidetribe &#128526; @mail.com", name= "TalkTide Tribe &#128526;", whoslastMsg= "", lastMsg= "Simon, Melissa, Amanda, Patrick, Siddique", active= false, isOnline= false, isTyping= false, howisTyping= "", allSeen= false, seen= true, unReadMessages= "", lastMessageTime= "3 days ago"
            },
            new ChatList {
                id= 4, img= "../assets/images/faces/20.jpg", email= "dialogdynasty@mail.com", name= "DialogDynasty", whoslastMsg= "", lastMsg= "Kamalan, Subha, Ambrose, Kiara, Jackson", active= false, isOnline= false, isTyping= false, howisTyping= "", allSeen= false, seen= true, unReadMessages= "", lastMessageTime= "5 days ago"
            },
            new ChatList {
                id= 5, img= "../assets/images/faces/21.jpg", email= "nexusChatnexus@mail.com", name= "NexusChat Nexus", whoslastMsg= "", lastMsg= "Subman, Rajen, Kairo, Dibasha, Alexa", active= false, isOnline= false, isTyping= false, howisTyping= "", allSeen= false, seen= true, unReadMessages= "", lastMessageTime= "12 days ago"
            },
        }; 
        public List<ChatList> GetGroupData() => GroupData;
        private List<ChatList> Contacts = new List<ChatList>()
        {  
            new ChatList {id= 1, img= "../assets/images/faces/5.jpg", imgavatar = false,  name= "Ava Taylor"},
            new ChatList {id= 2, img= "../assets/images/faces/12.jpg", imgavatar = false,  name= "Benjamin Turner"},
            new ChatList {id= 3, img= "../assets/images/faces/14.jpg", imgavatar = false,  name= "Caleb Rodriguez"},
            new ChatList {id= 4, img= "", avatarBackgroundColor = "avatar avatar-rounded avatar-sm bg-primary", imgavatar = true, avatarname= "DS", name= "Daniel Sullivan"},
            new ChatList {id= 5, img= "../assets/images/faces/7.jpg", imgavatar = false,  name= "Emma Johnson"},
            new ChatList {id= 6, img= "../assets/images/faces/15.jpg", imgavatar = false,  name= "Jackson Rivera"},
            new ChatList {id= 7, img= "", avatarBackgroundColor = "avatar avatar-rounded avatar-sm bg-primary", imgavatar = true, avatarname= "LB",  name= "Lily Brown"},
            new ChatList {id= 8, img= "../assets/images/faces/10.jpg", imgavatar = false,  name= "Noah Russell"},
            new ChatList {id= 9, img= "../assets/images/faces/16.jpg", imgavatar = false,  name= "Wyatt Thompson"},
        };
        public List<ChatList> GetContactsData() => Contacts;
           
        private List<GalleryList> GalleryData = new List<GalleryList>()
        {
            new GalleryList { Img = "../assets/images/media/media-40.jpg",},
            new GalleryList { Img = "../assets/images/media/media-41.jpg",},
            new GalleryList { Img = "../assets/images/media/media-42.jpg",},
            new GalleryList { Img = "../assets/images/media/media-43.jpg",},
            new GalleryList { Img = "../assets/images/media/media-44.jpg",},
            new GalleryList { Img = "../assets/images/media/media-45.jpg",},
            new GalleryList { Img = "../assets/images/media/media-46.jpg",},
            new GalleryList { Img = "../assets/images/media/media-60.jpg",},
            new GalleryList { Img = "../assets/images/media/media-61.jpg",},
        };
        public List<GalleryList> GetGalleryData() => GalleryData;
    }
}