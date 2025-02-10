using CardModel;
namespace ReviewsData
{
    public class ReviewsService {
        private List<Reviews> ReviewsData1 = new List<Reviews>()
        {
           new Reviews {
                Id =1,
                User="Hadley Kylin",
                Designation="UX Guru",
                UserImg="../../assets/images/faces/1.jpg",
                Review="This product is amazing! It has made my daily tasks so much easier and is very user-friendly.",
                Views=65,
                Rating=4.5,
            },
            new Reviews {
                Id =2,
                User="Spencer Robin",
                Designation="Support Engineer",
                UserImg="../../assets/images/faces/13.jpg",
                Review="Helping me plan for my future. Their expertise and personalized approach have given me great.",
                Views=87,
                Rating=4.5,
            },
            new Reviews {
                Id =3,
                User="Iliana Lilly",
                Designation="Optima Works",
                UserImg="../../assets/images/faces/3.jpg",
                Review="A game-changer for our business. Their insights and strategic advice helped us streamline.",
                Views=47,
                Rating=4.5,
            },
            new Reviews {
                Id =4,
                User="Tommy Rosen",
                Designation="Freelance Dev",
                UserImg="../../assets/images/faces/14.jpg",
                Review="Incredibly knowledgeable and supportive throughout the entire process. They provided clear.",
                Views=87,
                Rating=4.5,
            },
            new Reviews {
                Id =5,
                User="Jasmine Della",
                Designation="Web Oneness",
                UserImg="../../assets/images/faces/5.jpg",
                Review="This blender exceeded my expectations. It’s powerful, easy to clean, and makes perfect.",
                Views=87,
                Rating=4.5,
            },
            new Reviews {
                Id =6,
                User="Samson Thomas",
                Designation="Cloud Architect",
                UserImg="../../assets/images/faces/14.jpg",
                Review="Cloud architect designed a scalable and efficient cloud infrastructure for us perfect.",
                Views=87,
                Rating=4.5,
            }
        };
        public List<Reviews> GetReviewsData1() => ReviewsData1;
        private List<Reviews> ReviewsData2 = new List<Reviews>()
        {
            new Reviews {
                Id =1,
                User= "Flora Mary",
                Designation= "Systems Analyst",
                UserImg= "../../assets/images/faces/1.jpg",
                Review= "Technical issues quickly and efficiently resolved. Their expertise and prompt service have been critical in keeping our operations running smoothly.",
                Rate= 4.5,
                RateColor= "bg-secondary-transparent"
            },
            new Reviews {
                Id =2,
                User= "Maria Violet",
                Designation= "Web Developer",
                UserImg= "../../assets/images/faces/6.jpg",
                Review= "Web developer did an outstanding job creating our new website. It's user-friendly, visually appealing, and has all the functionality we need.",
                Rate= 4.5,
                RateColor= "bg-primary-transparent"
            },
            new Reviews {
                Id =3,
                User= "John Smith",
                Designation= "Systems Analyst",
                UserImg= "../../assets/images/faces/13.jpg",
                Review= "Freelance writer delivered high-quality Review that perfectly captured our brand voice. They were professional, met all deadlines.",
                Rate= 4.3,
                RateColor= "bg-primary1-transparent"
            },
            new Reviews {
                Id =4,
                User= "Uma Renata",
                Designation= "Systems Analyst",
                UserImg= "../../assets/images/faces/10.jpg",
                Review= "Template has an excellent theme and functionality. The quality is great, and I love that I can download Review to make customization!",
                Rate= 4.3,
                RateColor= "bg-primary3-transparent"
            },
            new Reviews {
                Id =5,
                User= "Arjun Richel",
                Designation= "Systems Analyst",
                UserImg= "../../assets/images/faces/15.jpg",
                Review= "This product is amazing! It has made my daily tasks so much easier and is very user-friendly. The product life is impressive too.",
                Rate= 4.1,
                RateColor= "bg-success-transparent"
            },
            new Reviews {
                Id =6,
                User= "Flora Mary",
                Designation= "Data Analyst",
                UserImg= "../../assets/images/faces/6.jpg",
                Review= "The checkout process was smooth, and my order arrived on time and well-packaged. Very satisfied with my purchase.",
                Rate= 3.8,
                RateColor= "bg-warning-transparent"
            }
        };
        public List<Reviews> GetReviewsData2() => ReviewsData2;
        private List<Reviews> ReviewsData3 = new List<Reviews>()
        {    
            new Reviews {
                Id =1,
                Review= "Customer service at this company is outstanding. They were quick to respond to my inquiry and resolved my issue within hours.",
                User= "Elsa Teresa",
                Email= "elsateresa@gmail.com",
                UserImg= "../../assets/images/faces/8.jpg",
                Rating= 4.3,
            },
            new Reviews {
                Id =2,
                Review= "Customer service at this company is outstanding. They were quick to respond to my inquiry and resolved my issue within hours.",
                User= "Henry Milo",
                Email= "henrymilo@gmail.com",
                UserImg= "../../assets/images/faces/9.jpg",
                Rating= 4.3,
            },
            new Reviews {
                Id =3,
                Review= "Customer service at this company is outstanding. They were quick to respond to my inquiry and resolved my issue within hours.",
                User= "Katherin Oslo",
                Email= "katherinoslo212@gmail.com",
                UserImg= "../../assets/images/faces/6.jpg",
                Rating= 4.3,
            },
            new Reviews {
                Id =4,
                Review= "Customer service at this company is outstanding. They were quick to respond to my inquiry and resolved my issue within hours.",
                User= "Jestin Calm",
                Email= "jestincalm1999@gmail.com",
                UserImg= "../../assets/images/faces/14.jpg",
                Rating= 4.3,
            },
            new Reviews {
                Id =5,
                Review= "Customer service at this company is outstanding. They were quick to respond to my inquiry and resolved my issue within hours.",
                User= "Harin Ford",
                Email= "harinford345@gmail.com",
                UserImg= "../../assets/images/faces/13.jpg",
                Rating= 4.3,
            },
            new Reviews {
                Id =6,
                Review= "Customer service at this company is outstanding. They were quick to respond to my inquiry and resolved my issue within hours.",
                User= "Phillip John",
                Email= "phillipjohn21@gmail.com",
                UserImg= "../../assets/images/faces/11.jpg",
                Rating= 4.3,
            },
        };
        public List<Reviews> GetReviewsData3() => ReviewsData3;
        private List<Reviews> ReviewsData4 = new List<Reviews>()
        {    
            new Reviews {
                Id =1,
                User= "Victoria Red",
                UserImg= "../../assets/images/faces/1.jpg",
                Review= "Project to success with excellent planning and coordination. Their leadership and communication kept everything on track and within budget.",
                Rating= 4.5
            },
            new Reviews {
                Id =2,
                User= "Nicolas Noor",
                UserImg= "../../assets/images/faces/12.jpg",
                Review= "Cybersecurity specialist has been crucial in protecting our data. Their proactive measures and quick response to threats give us great peace of mind.",
                Rating= 4.5
            },
            new Reviews {
                Id =3,
                User= "Remi Gloria",
                UserImg= "../../assets/images/faces/3.jpg",
                Review= "Marketing consultant provided us with a clear, actionable strategy that boosted our online presence and increased our customer engagement.",
                Rating= 4.5
            },
            new Reviews {
                Id =4,
                User= "Danny Raj",
                UserImg= "../../assets/images/faces/14.jpg",
                Review= "The cloud architect designed a scalable and efficient cloud infrastructure for us. Their expertise has greatly improved our data accessibility.",
                Rating= 4.5
            },
            new Reviews {
                Id =5,
                User= "Sissera William",
                UserImg= "../../assets/images/faces/5.jpg",
                Review= "Cybersecurity specialist has been crucial in protecting our data. Their proactive measures and quick response to threats give us great peace of mind.",
                Rating= 4.5
            },
            new Reviews {
                Id =6,
                User= "Audie Yose",
                UserImg= "../../assets/images/faces/6.jpg",
                Review= "Graphic designer created beautiful and impactful designs for our campaign. Their creativity and attention to detail were evident in every piece they delivered.",
                Rating= 4.5
            },
           
        };
        public List<Reviews> GetReviewsData4() => ReviewsData4;
        private List<Reviews> ReviewsData5 = new List<Reviews>()
        {    
            new Reviews {
                Id =1,
                User= "Vinny Rose",
                Designation= "Systems Analyst",
                UserImg= "../../assets/images/faces/1.jpg",
                Review= "The network administrator has ensured our systems run smoothly and securely, always quick to resolve any issues and keep our network optimized.",
                Rating= 4.5
            },
            new Reviews {
                Id =2,
                User= "Amaya Usha",
                Designation= "Web Developer",
                UserImg= "../../assets/images/faces/2.jpg",
                Review= "Always reliable and efficient. They resolve technical problems quickly and provide clear, helpful guidance to our staff.",
                Rating= 4.5
            },
            new Reviews {
                Id =3,
                User= "Sophia Ben",
                Designation= "Systems Analyst",
                UserImg= "../../assets/images/faces/3.jpg",
                Review= "Created a website that exceeded our expectations. It’s visually appealing, user-friendly, and has enhanced our online presence significantly.",
                Rating= 4.5
            },
            new Reviews {
                Id =4,
                User= "Sissera William",
                Designation= "Systems Analyst",
                UserImg= "../../assets/images/faces/4.jpg",
                Review= "The network administrator has ensured our systems run smoothly and securely, always quick to resolve any issues and keep our network optimized.",
                Rating= 4.5
            },
            new Reviews {
                Id =5,
                User= "Georgia Kate",
                Designation= "Systems Analyst",
                UserImg= "../../assets/images/faces/5.jpg",
                Review= "The network administrator has ensured our systems run smoothly and securely, always quick to resolve any issues and keep our network optimized.",
                Rating= 4.5
            },
        };
        public List<Reviews> GetReviewsData5() => ReviewsData5;
    }
}