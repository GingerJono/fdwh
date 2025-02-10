
namespace MailData
{
    public class MailList
    {
        public int id { get; set; }
        public string? mailIcon { get; set; }
        public string? mailname { get; set; }
        public string? badgeValue { get; set; }
        public string? badgeColor { get; set; }
        public string? Userimg { get; set; }
        public string? UserName { get; set; }
        public string? UserMail { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Date { get; set; }
        public bool Starred { get; set; }
        public bool attachment { get; set; }
        public string? avatarname {get;set;}
        public string? userbgColor {get;set;}
        public bool Selected { get; set; }
        public bool IsOnline { get; set; }
    }
    public class MailService {
        
        private List<MailList> MailListNav = new List<MailList>()
        {  
            new MailList {id= 1, mailIcon= "ti ti-mail", mailname= "All Mails",badgeValue= "2,142", badgeColor= "primary1",},
            new MailList {id= 2, mailIcon= "ti ti-inbox", mailname= "Inbox",badgeValue= "12", badgeColor= "primary2",},
            new MailList {id= 3, mailIcon= "ti ti-send", mailname= "Sent"},
            new MailList {id= 4, mailIcon= "ti ti-notes", mailname= "Drafts"},
            new MailList {id= 5, mailIcon= "ti ti-alert-circle", mailname= "Spam",badgeValue= "6", badgeColor= "primary3",},
            new MailList {id= 6, mailIcon= "ti ti-archive", mailname= "Archive"},
            new MailList {id= 7, mailIcon= "ti ti-trash", mailname= "Important"},
            new MailList {id= 8, mailIcon= "ti ti-bookmark", mailname= "Trash"},
            new MailList {id= 9, mailIcon= "ti ti-star", mailname= "Starred", badgeValue= "05", badgeColor= "warning",},
        };
        public List<MailList> GetMailListNavData() => MailListNav;
        private List<MailList> TotalMailsList = new List<MailList>()
        {  
            new MailList {
                id= 1,
                Userimg= "../assets/images/faces/5.jpg",
                UserName= "Iliana Lilly", 
                UserMail= "IlianaLilly@gmail.com ", 
                Title= "Meeting Agenda", 
                Description= "Reviewing the agenda for tomorrow's meeting. We'll be discussing the project timeline and budget allocation.", 
                Date= "12:12AM", 
                Starred= true,
                attachment= true,
            },
            new MailList {
                id= 2,
                Userimg= "../assets/images/faces/12.jpg",
                UserName= "Priceton Gray", 
                UserMail= "PricetonGray@gmail.com ", 
                Title= "Exclusive Offers Inside!", 
                Description= "Unlock exclusive deals and discounts inside! Don't miss out on this limited-time opportunity to save big on your favorite products and services.", 
                Date= "03:18PM", 
                Starred= false,
                attachment= false,
                Selected=true
            },
            new MailList {
                id= 3,
                userbgColor = "bg-primary", 
                avatarname= "CH",
                UserName= "Charlie Edson", 
                UserMail= "CharlieEdson@gmail.com ", 
                Title= " Limited-Time Offer: Save on Your Next Trip!", 
                Description= "Unlock exclusive deals and discounts inside! Don't miss out on this limited-time opportunity to save big on your favorite products and services.", 
                Date= "Yesterday, 06:45AM", 
                Starred= false,
                attachment= false,
                badgeColor= "warning ms-2",
                badgeValue= "Promotion",
            },
            new MailList {
                id= 4,
                Userimg= "../assets/images/faces/7.jpg",
                UserName= "Isha Bella", 
                UserMail= "IshaBella@gmail.com ", 
                Title= " You Have New Notifications", 
                Description= "Stay connected with your friends and family. See who's commented on your latest post and catch up on messages from loved ones.", 
                Date= "May 15 2024, 08:16PM", 
                Starred= false,
                attachment= false,
                badgeColor= "primary1 ms-2",
                badgeValue= "Social",
                Selected=true
            },
            new MailList {
                id= 5,
                Userimg= "../assets/images/faces/15.jpg",
                UserName= "Danny Raj", 
                UserMail= "DannyRaj@gmail.com ", 
                Title= "New Connection Request", 
                Description= "Expand your professional network with a new connection. Accept the request to connect and start networking today to explore new opportunities.", 
                Date= "May 13 2024, 11:24AM", 
                Starred= true,
                attachment= false,
            },
            new MailList {
                id= 6,
                userbgColor = "bg-primary2", 
                avatarname= "SR",
                UserName= "Spencer Robin", 
                UserMail= "SpencerRobin@gmail.com ", 
                Title= "Invitation By Summer Soiree Under the Stars!", 
                Description= "Hello, You are cordially invited to join us for an unforgettable evening of summer magic at our Summer Soiree Under the Stars!", 
                Date= "May 18 2024, 11:15PM", 
                Starred= true,
                attachment= false,
                badgeColor= "primary3 ms-2",
                badgeValue= "Personal",
            },
            new MailList {
                id= 7,
                userbgColor = "bg-warning", 
                avatarname= "HJ",
                UserName= "Harry Justin", 
                UserMail= "HarryJustin@gmail.com ", 
                Title= "New Connection Request", 
                Description= "Expand your professional network with a new connection. Accept the request to connect and start networking today to explore new opportunities.", 
                Date= "April 05 2024, 08:12AM", 
                Starred= false,
                attachment= false,
            },
            new MailList {
                id= 8,
                Userimg= "../assets/images/faces/13.jpg",
                UserName= "Nicolas Noor", 
                UserMail= "NicolasNoor@gmail.com ", 
                Title= "Claim Your Prize Now!", 
                Description= "Congratulations! You've won a prize! Click here to claim your reward before it's too late and enjoy your well-deserved prize.", 
                Date= "March 20, 08:30PM", 
                Starred= false,
                attachment= false,
            },
        };
        public List<MailList> GetMailsData() => TotalMailsList;
        private List<MailList> RecepientsList = new List<MailList>()
        {  
            new MailList {id= 1,Userimg= "../assets/images/faces/11.jpg",UserName="Hadley Kylin",IsOnline=true},
            new MailList {id= 2,Userimg= "../assets/images/faces/7.jpg",UserName="Iliana Lilly",IsOnline=true},
            new MailList {id= 3,Userimg= "../assets/images/faces/4.jpg",UserName="Jasmine Della",IsOnline=false},
            new MailList {id= 4,Userimg= "../assets/images/faces/8.jpg",UserName="Emanuel Rush",IsOnline=false},
            new MailList {id= 5,Userimg= "../assets/images/faces/3.jpg",UserName="Nyra Tiyana",IsOnline=false},
            new MailList {id= 6,Userimg= "../assets/images/faces/11.jpg",UserName="Maria Violet",IsOnline=true},
            new MailList {id= 7,Userimg= "../assets/images/faces/16.jpg",UserName="Priceton Gray",IsOnline=true},
            new MailList {id= 8,Userimg= "../assets/images/faces/10.jpg",UserName="Charlie Edson",IsOnline=false},
            new MailList {id= 9,Userimg= "../assets/images/faces/15.jpg",UserName="Spencer Robin",IsOnline=false},
        };
        public List<MailList> GetRecepientsList() => RecepientsList;
    }
}