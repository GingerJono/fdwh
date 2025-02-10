using System.Reflection;
using CardModel;
namespace ProfileData
{
    public class Info {
        public decimal Id { get; set; }
        public string? Img { get; set; }
        public string? Icon { get; set; }
        public string? IconClass { get; set; }
        public string? Title { get; set; }
        public string? Details { get; set; }
    }

    public class Profile {
        public decimal Id { get; set; }
        public string? UserImg { get; set; }
        public string? User { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }

    };
    public class ProfileService {
        private List<Info> BasicData = new List<Info>()
        {
            new Info { Id = 1, Title = "Name",Details="Spencer Robin"},
            new Info { Id = 2, Title = "Designation",Details="Software Development Manager"},
            new Info { Id = 3, Title = "Email",Details="spencer.robin22@example.com"},
            new Info { Id = 4, Title = "Phone",Details="+1 (222) 111 - 57840"},
            new Info { Id = 5, Title = "Experience",Details="10 Years"},
            new Info { Id = 6, Title = "Age",Details="28"}
        };
        public List<Info> GetBasicData() => BasicData;
        private List<Info> FollowersData = new List<Info>()
        {
            new Info { Id = 1, Img="../assets/images/faces/1.jpg",Title = "Iliana Lilly"},
            new Info { Id = 2, Img="../assets/images/faces/14.jpg",Title = "Charlie Edson"},
            new Info { Id = 3, Img="../assets/images/faces/3.jpg",Title = "Aurora Reed"},
            new Info { Id = 4, Img="../assets/images/faces/10.jpg",Title = "Spencer Robin"},
        };
        public List<Info> GetFollowersData() => FollowersData;
        private List<Info> ContactInfoData = new List<Info>()
        {
            new Info { Id = 1, Icon="ri-mail-line",IconClass="primary",Title = "Email",Details="spencer.robin22@example.com"},
            new Info { Id = 2, Icon="ri-map-pin-line",IconClass="primary1",Title = "Website",Details="www.robin22.com"},
            new Info { Id = 3, Icon="ri-building-line",IconClass="primary2",Title = "Location",Details="Hamburg,Germany"},
            new Info { Id = 4, Icon="ri-phone-line",IconClass="primary3",Title = "Phone",Details="+1 (222) 111 - 57840"},
        };
        public List<Info> GetContactInfoData() => ContactInfoData; 
        private List<Info> SkillsData = new List<Info>()
        {
            new Info { Id = 1,Title = "Leadership"},
            new Info { Id = 2,Title = "Project Management"},
            new Info { Id = 3,Title = "Technical Proficiency"},
            new Info { Id = 4,Title = "Communication"},
            new Info { Id = 5,Title = "Team Building"},
            new Info { Id = 6,Title = "Problem-Solving"},
            new Info { Id = 7,Title = "Strategic Thinking"},
            new Info { Id = 8,Title = "Decision Making"},
            new Info { Id = 9,Title = "Adaptability"},
            new Info { Id = 10,Title = "Stakeholder Management"},
            new Info { Id = 11,Title = "Conflict Resolution"},
            new Info { Id = 12,Title = "Continuous Improvement"},
        };
        public List<Info> GetSkillsData() => SkillsData;
        private List<Info> SocialInfoData = new List<Info>()
        {
            new Info { Id = 1, Icon="ri-github-line",IconClass="primary",Title = "Github",Details="github.com/spruko"},
            new Info { Id = 1, Icon="ri-twitter-x-line",IconClass="primary1",Title = "Twitter",Details="twitter.com/spruko.me"},
            new Info { Id = 1, Icon="ri-linkedin-line",IconClass="primary2",Title = "Linkedin",Details="linkedin.com/in/spruko"},
            new Info { Id = 1, Icon="ri-briefcase-line",IconClass="primary3",Title = "My Portfolio",Details="spruko.com/"},
        };
        public List<Info> GetSocialInfoData() => SocialInfoData;
        private List<Activity> ActivityData = new List<Activity>()
        {
            new Activity {Id=1,Img="../assets/images/faces/3.jpg",Title="<span class='fw-semibold'>Photos </span>from their recent vacation and writes a caption describing their experience..",Duration="15,May 2024 - 18:47", Comment="4",Like="2",Like1="3",
                Media = new List<Media>{
                    new Media { Img = "../assets/images/media/media-17.jpg",},
                    new Media { Img = "../assets/images/media/media-18.jpg",},
                    new Media { Img = "../assets/images/media/media-19.jpg",},
                },
                Tags = new List<Tags>{
                    new Tags { Tag = "#Leadership",},
                    new Tags { Tag = "#Solving",},
                }
            },
            new Activity {Id=2,Img="../assets/images/faces/11.jpg",Title="Friend comments on the post, expressing admiration for the picturesque location a. <span class='text-primary fw-medium text-decoration-underline'>#Trip-photos</span>",Duration="18,Dec 2024 - 12:16", Desc="Asking about the user's favorite part of the trip. emporibus inventore ullam tempora eligendi libero sequi dignissimos cumque, et a sint tenetur consequatur omnis!", Comment="4",Like="2",Like1="3",
                Tags = new List<Tags>{
                    new Tags { Tag = "#Leadership",},
                    new Tags { Tag = "#Solving",},
                }
            },
            new Activity {Id=3,Img="../assets/images/faces/4.jpg",Title="<span class='text-default'><span class='text-primary1 fw-medium'>Varun Sonu </span> asking for recommendations on places to visit in the vacation destination</span>.",Duration="26,May 2024 - 12:45", Comment="4",Like="2",Like1="3",
                Media = new List<Media>{
                    new Media { Img = "../assets/images/media/file-manager/3.png", Desc="432.87KB"},
                },
                Tags = new List<Tags>{
                    new Tags { Tag = "#Leadership",},
                    new Tags { Tag = "#Solving",},
                }
            },
            new Activity {Id=4,Value="k", Avatarcolor="bg-success",Title="<span class='text-default'>On a trending news topic, offering their perspective and engaging with other group members' <span class='text-primary2 fw-medium text-decoration-underline'>#viewpoints</span></span>.",Duration="28,May 2024 - 22:09", Comment="4",Like="2",Like1="3",
                Media = new List<Media>{
                    new Media { Img ="../assets/images/media/media-75.jpg"},
                },
                Tags = new List<Tags>{
                    new Tags { Tag = "#Leadership",},
                    new Tags { Tag = "#Solving",},
                }
            },
            new Activity {Id=5,Img="../assets/images/faces/5.jpg",Title=" <span class='text-default'>Reminiscing about a memorable trip they took together and suggesting planning another adventure soon. <span class='fw-semibold text-primary3 text-decoration-underline'>#Europe</span> trip was a landmark in our lifes!</span>.",Duration="29,May 2024 - 16:42", Comment="4",Like="2",Like1="3", Desc="'Every time, our Europe trip still lies vividly before our eyes.'",
                Media = new List<Media>{
                    new Media { Img = "../assets/images/media/media-59.jpg"},
                    new Media { Img = "../assets/images/media/media-60.jpg"},
                    new Media { Img = "../assets/images/media/media-61.jpg"},
                },
                Tags = new List<Tags>{
                    new Tags { Tag = "#Leadership",},
                    new Tags { Tag = "#Solving",},
                }
            },
            new Activity {Id=6,Img="../assets/images/media/media-39.jpg",Title="<span class='fw-semibold text-primary2'>Invitation</span> to a virtual networking event from a professional connection, expressing interest and RSVPing for attendance.",Duration="06,Jun 2024 - 08:40", Comment="4",Like="2",Like1="3", 
                Media = new List<Media>{
                    new Media { Img = "../assets/images/media/media-26.jpg"},
                    new Media { Img = "../assets/images/media/media-29.jpg"},
                },
                Tags = new List<Tags>{
                    new Tags { Tag = "#Leadership",},
                    new Tags { Tag = "#Solving",},
                }
            },
        };
        public List<Activity> GetActivityData() => ActivityData;
        private List<Info> GalleryData = new List<Info>()
        {
            new Info { Img = "../assets/images/media/media-40.jpg",},
            new Info { Img = "../assets/images/media/media-41.jpg",},
            new Info { Img = "../assets/images/media/media-42.jpg",},
            new Info { Img = "../assets/images/media/media-43.jpg",},
            new Info { Img = "../assets/images/media/media-44.jpg",},
            new Info { Img = "../assets/images/media/media-45.jpg",},
            new Info { Img = "../assets/images/media/media-46.jpg",},
            new Info { Img = "../assets/images/media/media-60.jpg",},
            new Info { Img = "../assets/images/media/media-26.jpg",},
            new Info { Img = "../assets/images/media/media-32.jpg",},
            new Info { Img = "../assets/images/media/media-30.jpg",},
            new Info { Img = "../assets/images/media/media-31.jpg",},
            new Info { Img = "../assets/images/media/media-46.jpg",},
            new Info { Img = "../assets/images/media/media-59.jpg",},
            new Info { Img = "../assets/images/media/media-61.jpg",},
            new Info { Img = "../assets/images/media/media-42.jpg",},
        };
        public List<Info> GetGalleryData() => GalleryData;
        private List<Profile> FriendsData = new List<Profile>()
        {    
            new Profile { Id=1, UserImg="../../assets/images/faces/2.jpg", User="Della Jasmine", Email="dellajasmine117@gmail.com", Role="Product Designer" },
            new Profile { Id=2, UserImg="../../assets/images/faces/15.jpg", User="Danny Raj", Email="dannyraj658@gmail.com", Role="UI Designer" },
            new Profile { Id=3, UserImg="../../assets/images/faces/5.jpg", User="Catalina Keira", Email="catalinakeira023@gmail.com", Role="Product Designer" },
            new Profile { Id=4, UserImg="../../assets/images/faces/11.jpg", User="Priceton Gray", Email="pricetongray451@gmail.com", Role="Team Manager" },
            new Profile { Id=5, UserImg="../../assets/images/faces/7.jpg", User="Sarah Ruth", Email="sarahruth45@gmail.com", Role="Product Designer" },
            new Profile { Id=6, UserImg="../../assets/images/faces/12.jpg", User="Mahira Hose", Email="mahirahose9456@gmail.com", Role="Product Designer" },
            new Profile { Id=7, UserImg="../../assets/images/faces/1.jpg", User="Victoria Gracie", Email="victoriagracie@gmail.com", Role="Product Designer" },
            new Profile { Id=8, UserImg="../../assets/images/faces/13.jpg", User="Amith Gray", Email="amithgray132@gmail.com", Role="Product Designer"},     
            new Profile { Id=9, UserImg="../../assets/images/faces/6.jpg", User="Isha Bella", Email="ishabella255@gmail.com", Role="Product Designer "}
        };
        public List<Profile> GetFriendsData() => FriendsData;

    }
}