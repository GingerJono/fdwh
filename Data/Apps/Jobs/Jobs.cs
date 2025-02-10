
using CardModel;
namespace JobData
{
    public class Jobs {
        public int Id { get; set; }
        public string? Icon { get; set; }
        public string? Iconcolor { get; set; }
        public string? Img { get; set; }
        public string? Title { get; set; }
        public string? Company { get; set; }
        public string? CompanyLogo { get; set; }
        public string? Department { get; set; }
        public string? Applications { get; set; }
        public string? PostedDate { get; set; }
        public string? PostedDateColor { get; set; }  
        public string? JobType { get; set; }
        public string? Date { get; set; }
        public string? Status { get; set; }    
        public bool Selected { get; set; } 
        public string? Location { get; set; }
        public string? Experience { get; set; }
        public string? Salary { get; set; }
        public string? EstablishmentYear { get; set; }
        public string? RatingCount { get; set; }
        public string? Employees { get; set; }
        public string? Vacancies { get; set; }
        public List<Ratings>? Ratings { get; set; }
        public List<JobBadge>? JobBadge { get; set; }
    }
    
    public class Candidate {
        public int Id { get; set; }
        public string? Img { get; set; }
        public string? JobTitle { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public List<Ratings>? Ratings { get; set; }
        public string? RatingCount { get; set; }
        public List<JobBadge>? JobBadge { get; set; }
        public string? AnnualPay { get; set; }
        public string? Languages { get; set; }
    }
    
    public class Ratings
    {
        public string? Rate { get; set; }
        public bool NotRated { get; set; }
    }
    public class JobBadge
    {
        public string? Icon { get; set; }
        public string? BadgeColor { get; set; }
        public string? Badge { get; set; }
    }
    public class JobService {
        
        private List<Jobs> JobsData = new List<Jobs>()
        {
            new Jobs {Id=1,Img="../assets/images/media/jobs/2.png",Title="Frontend Developer",Company="InnovateZ Solutions",Location="San Francisco, CA",Experience="2+ Yrs Exp.",Salary="$50k - $80k"},
            new Jobs {Id=2,Iconcolor="danger",Icon="bi bi-laptop",Title="Backend Developer",Company="Tech Solutions Inc.",Location="New York, NY",Experience="3+ Yrs Exp.",Salary="$60k - $90k"},
            new Jobs {Id=2,Iconcolor="warning",Icon="bi bi-laptop",Title="UI/UX Designer",Company="Creative Designs Co.",Location="Seattle, WA",Experience="3+ Yrs Exp.",Salary="$70k - $100k"},
            new Jobs {Id=2,Iconcolor="info",Icon="bi bi-laptop",Title="Full Stack Developer",Company="TechGurus Ltd.",Location="Los Angeles, CA",Experience="5+ Yrs Exp.",Salary="$70k - $100k"},
        };
        public List<Jobs> GetJobs() => JobsData;
        
        private List<Jobs> CompanyData = new List<Jobs>()
        {
            new Jobs {Id=1,Img="../assets/images/company-logos/1.png",Title="TechGurus Ltd.",Location="Los Angeles, CA",EstablishmentYear="2015",RatingCount="245",Employees="345",Vacancies="50",Ratings = new List<Ratings>
                {
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-half"},
                },
            },
            new Jobs {Id=2,Img="../assets/images/company-logos/2.png",Title="XYZ Solutions Ltd.",Location="New York, NY",EstablishmentYear="2010",RatingCount="318",Employees="146",Vacancies="40",Ratings = new List<Ratings>
                {
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-half"},
                },
            },
            new Jobs {Id=3,Img="../assets/images/company-logos/3.png",Title="Innovate Labs Inc.",Location="San Francisco, CA",EstablishmentYear="2013",RatingCount="198",Employees="56",Vacancies="35",Ratings = new List<Ratings>
                {
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-half"},
                },
            },
            new Jobs {Id=4,Img="../assets/images/company-logos/7.png",Title="GlobalTech Innovations.",Location="London, UK",EstablishmentYear="2011",RatingCount="367",Employees="120",Vacancies="10",Ratings = new List<Ratings>
                {
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-half"},
                },
            },
            new Jobs {Id=5,Img="../assets/images/company-logos/5.png",Title="Innovision Software Solutions",Location="Sydney, Australia",EstablishmentYear="2005",RatingCount="267",Employees="120",Vacancies="10",Ratings = new List<Ratings>
                {
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-half"},
                },
            },
            new Jobs {Id=6,Img="../assets/images/company-logos/6.png",Title="Digital Nexus Solutions",Location="Chicago, IL",EstablishmentYear="2012",RatingCount="389",Employees="120",Vacancies="10",Ratings = new List<Ratings>
                {
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-half"},
                },
            },
            new Jobs {Id=7,Img="../assets/images/company-logos/10.png",Title="Innovate IT Solutions",Location="Mumbai, India",EstablishmentYear="2009",RatingCount="312",Employees="345",Vacancies="50",Ratings = new List<Ratings>
                {
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-half"},
                },
            },
            new Jobs {Id=8,Img="../assets/images/company-logos/9.png",Title="CloudSoft Technologies",Location="Seattle, WA",EstablishmentYear="2014",RatingCount="424",Employees="146",Vacancies="40",Ratings = new List<Ratings>
                {
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-fill"},
                    new Ratings {Rate = "bi bi-star-half"},
                },
            },
        };
        public List<Jobs> GetCompanyData() => CompanyData;
        
        private List<Jobs> JobsearchData = new List<Jobs>()
        {
            new Jobs {Id=1,Img="../assets/images//media/jobs/2.png",Title="Frontend Developer",Company="Tech Solutions Inc.",Salary="$45,000 - $60,000",JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-map-pin-line",BadgeColor="primary",Badge="San Francisco"},
                    new JobBadge {Icon="ri-briefcase-line",BadgeColor="primary1",Badge="5 Openings"},
                    new JobBadge {Icon="ri-graduation-cap-line",BadgeColor="info",Badge="Graduate"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="primary3",Badge="Min - 1 Year"},
                    new JobBadge {Icon="ri-sun-line",BadgeColor="secondary",Badge="Full-time"},
                },
            },
            new Jobs {Id=2,Img="../assets/images//media/jobs/1.png",Title="React Lead Developer",Company="Infratech PVT LTD",Salary="$18,000 - $43,000",JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-map-pin-line",BadgeColor="primary",Badge="San Francisco"},
                    new JobBadge {Icon="ri-briefcase-line",BadgeColor="primary1",Badge="5 Openings"},
                    new JobBadge {Icon="ri-graduation-cap-line",BadgeColor="info",Badge="Graduate"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="primary3",Badge="Min - 1 Year"},
                    new JobBadge {Icon="ri-sun-line",BadgeColor="secondary",Badge="Full-time"},
                },
            },
            new Jobs {Id=3,Img="../assets/images//media/jobs/3.png",Title="Vuejs Frontend Developer",Company="G Technical Solutions",Salary="$18,000 - $43,000",JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-map-pin-line",BadgeColor="primary",Badge="San Francisco"},
                    new JobBadge {Icon="ri-briefcase-line",BadgeColor="primary1",Badge="5 Openings"},
                    new JobBadge {Icon="ri-graduation-cap-line",BadgeColor="info",Badge="Graduate"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="primary3",Badge="Min - 1 Year"},
                    new JobBadge {Icon="ri-sun-line",BadgeColor="secondary",Badge="Full-time"},
                },
            },
            new Jobs {Id=4,Img="../assets/images//media/jobs/4.png",Title="Wordpress Developer",Company="Hardware Private Solutions",Salary="$18,000 - $43,000",JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-map-pin-line",BadgeColor="primary",Badge="San Francisco"},
                    new JobBadge {Icon="ri-briefcase-line",BadgeColor="primary1",Badge="5 Openings"},
                    new JobBadge {Icon="ri-graduation-cap-line",BadgeColor="info",Badge="Graduate"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="primary3",Badge="Min - 1 Year"},
                    new JobBadge {Icon="ri-sun-line",BadgeColor="secondary",Badge="Full-time"},
                },
            },
            new Jobs {Id=5,Img="../assets/images//media/jobs/2.png",Title="HTML Developer - Fresher",Company="InnovateZ Solutions",Salary="$18,000 - $43,000",JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-map-pin-line",BadgeColor="primary",Badge="San Francisco"},
                    new JobBadge {Icon="ri-briefcase-line",BadgeColor="primary1",Badge="5 Openings"},
                    new JobBadge {Icon="ri-graduation-cap-line",BadgeColor="info",Badge="Graduate"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="primary3",Badge="Min - 1 Year"},
                    new JobBadge {Icon="ri-sun-line",BadgeColor="secondary",Badge="Full-time"},
                },
            },
            new Jobs {Id=6,Img="../assets/images//media/jobs/1.png",Title="React Lead Developer",Company="Infratech PVT LTD",Salary="$18,000 - $43,000",JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-map-pin-line",BadgeColor="primary",Badge="San Francisco"},
                    new JobBadge {Icon="ri-briefcase-line",BadgeColor="primary1",Badge="5 Openings"},
                    new JobBadge {Icon="ri-graduation-cap-line",BadgeColor="info",Badge="Graduate"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="primary3",Badge="Min - 1 Year"},
                    new JobBadge {Icon="ri-sun-line",BadgeColor="secondary",Badge="Full-time"},
                },
            },
            new Jobs {Id=7,Img="../assets/images//media/jobs/3.png",Title="Vuejs Frontend Developer",Company="G Technical Solutions",Salary="$18,000 - $43,000",JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-map-pin-line",BadgeColor="primary",Badge="San Francisco"},
                    new JobBadge {Icon="ri-briefcase-line",BadgeColor="primary1",Badge="5 Openings"},
                    new JobBadge {Icon="ri-graduation-cap-line",BadgeColor="info",Badge="Graduate"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="primary3",Badge="Min - 1 Year"},
                    new JobBadge {Icon="ri-sun-line",BadgeColor="secondary",Badge="Full-time"},
                },
            },
            new Jobs {Id=8,Img="../assets/images//media/jobs/2.png",Title="HTML Developer - Remote",Company="InnovateZ Solutions",Salary="$18,000 - $43,000",JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-map-pin-line",BadgeColor="primary",Badge="San Francisco"},
                    new JobBadge {Icon="ri-briefcase-line",BadgeColor="primary1",Badge="5 Openings"},
                    new JobBadge {Icon="ri-graduation-cap-line",BadgeColor="info",Badge="Graduate"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="primary3",Badge="Min - 1 Year"},
                    new JobBadge {Icon="ri-sun-line",BadgeColor="secondary",Badge="Full-time"},
                },
            },
            new Jobs {Id=9,Img="../assets/images//media/jobs/1.png",Title="React Lead Developer",Company="Infratech PVT LTD",Salary="$18,000 - $43,000",JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-map-pin-line",BadgeColor="primary",Badge="San Francisco"},
                    new JobBadge {Icon="ri-briefcase-line",BadgeColor="primary1",Badge="5 Openings"},
                    new JobBadge {Icon="ri-graduation-cap-line",BadgeColor="info",Badge="Graduate"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="primary3",Badge="Min - 1 Year"},
                    new JobBadge {Icon="ri-sun-line",BadgeColor="secondary",Badge="Full-time"},
                },
            },
            new Jobs {Id=10,Img="../assets/images//media/jobs/3.png",Title="Vuejs Frontend Developer",Company="G Technical Solutions",Salary="$18,000 - $43,000",JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-map-pin-line",BadgeColor="primary",Badge="San Francisco"},
                    new JobBadge {Icon="ri-briefcase-line",BadgeColor="primary1",Badge="5 Openings"},
                    new JobBadge {Icon="ri-graduation-cap-line",BadgeColor="info",Badge="Graduate"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="primary3",Badge="Min - 1 Year"},
                    new JobBadge {Icon="ri-sun-line",BadgeColor="secondary",Badge="Full-time"},
                },
            },
        };
        public List<Jobs> GetJobsearchData() => JobsearchData;
        
        List<Jobs> JoblistData = new List<Jobs>()
        {
            new Jobs { 
                Id=1,
                Img = "../assets/images/media/jobs/2.png",
                Title = "HTML Developer - Fresher", 
                CompanyLogo = "../assets/images/company-logos/8.png", 
                Company = "HorizonTech Ventures", 
                Department = "Development",       
                Applications="18", 
                Vacancies = "36",
                PostedDate="Nov 12 2024", 
                PostedDateColor="primary", 
                JobType = "Full Time", 
                Date = "Oct 15 2024", 
                Status = "Approved",
                Selected=false 
            },
            new Jobs { 
                Id=2,
                Img = "../assets/images/media/jobs/1.png",
                Title = " React Lead Developer", 
                CompanyLogo = "../assets/images/company-logos/10.png", 
                Company = "FusionTech Industries", 
                Department = "Design",       
                Applications="31", 
                Vacancies = "50",
                PostedDate="Oct 15 2024", 
                PostedDateColor="danger", 
                JobType = "Full Time", 
                Date = "Sep 07 2024", 
                Status = "Rejected", 
                Selected=true 
            },
            new Jobs { 
                Id=3,
                Img = "../assets/images/media/jobs/3.png",
                Title = " Vuejs Frontend Developer", 
                CompanyLogo = "../assets/images/company-logos/1.png", 
                Company = "Optima Ventures Inc.", 
                Department = "Management",       
                Applications="36", 
                Vacancies = "35",
                PostedDate="May 15 2024", 
                PostedDateColor="warning", 
                JobType = "Part Time", 
                Date = "Dec 19 2024", 
                Status = "Pending", 
                Selected=true 
            },
            new Jobs { 
                Id=4,
                Img = "../assets/images/media/jobs/4.png",
                Title = "  Wordpress Developer - Remote", 
                CompanyLogo = "../assets/images/company-logos/2.png", 
                Company = "Tech Innovators Ltd.", 
                Department = "Marketing",       
                Applications="20", 
                Vacancies = "60",
                PostedDate="Feb 12 2024", 
                PostedDateColor="primary", 
                JobType = "Part Time", 
                Date = "Jan 12 2024", 
                Status = "Approved", 
                Selected=false 
            },
            new Jobs { 
                Id=5,
                Img = "../assets/images/media/jobs/2.png",
                Title = "HTML Developer - Fresher", 
                CompanyLogo = "../assets/images/company-logos/8.png", 
                Company = "HorizonTech Ventures", 
                Department = "Development",       
                Applications="18", 
                Vacancies = "36",
                PostedDate="Nov 12 2024", 
                PostedDateColor="primary", 
                JobType = "Full Time", 
                Date = "Oct 15 2024", 
                Status = "Approved", 
                Selected=false 
            },
            new Jobs { 
                Id=6,
                Img = "../assets/images/media/jobs/1.png",
                Title = " React Lead Developer", 
                CompanyLogo = "../assets/images/company-logos/10.png", 
                Company = "FusionTech Industries", 
                Department = "Design",       
                Applications="31", 
                Vacancies = "50",
                PostedDate="Oct 15 2024", 
                PostedDateColor="danger", 
                JobType = "Full Time", 
                Date = "Sep 27 2024", 
                Status = "Rejected", 
                Selected=true 
            },
            new Jobs { 
                Id=7,
                Img = "../assets/images/media/jobs/3.png",
                Title = " Vuejs Frontend Developer", 
                CompanyLogo = "../assets/images/company-logos/1.png", 
                Company = "Optima Ventures Inc.", 
                Department = "Management",       
                Applications="36", 
                Vacancies = "35",
                PostedDate="May 15 2024", 
                PostedDateColor="warning", 
                JobType = "Part Time", 
                Date = "Dec 19 2024", 
                Status = "Pending", 
                Selected=true 
            },
            new Jobs { 
                Id=8,
                Img = "../assets/images/media/jobs/4.png",
                Title = "  Wordpress Developer - Remote", 
                CompanyLogo = "../assets/images/company-logos/2.png", 
                Company = "Tech Innovators Ltd.", 
                Department = "Marketing",       
                Applications="20", 
                Vacancies = "60",
                PostedDate="Feb 12 2024", 
                PostedDateColor="primary", 
                JobType = "Part Time", 
                Date = "Jan 12 2024", 
                Status = "Approved", 
                Selected=false 
            },
        }; 
        public List<Jobs> GetJoblistData() => JoblistData;
        
        public TableText[] JobsListHeaders = new TableText[]
        {
            new TableText { Title = "Job Title" },
            new TableText { Title = "Company" },
            new TableText { Title = "Department" },
            new TableText { Title = "Applications" },
            new TableText { Title = "Posted Date" },
            new TableText { Title = "Vacancies" },
            new TableText { Title = "Job Type" },
            new TableText { Title = "Status" },
            new TableText { Title = "Expires on" },
            new TableText { Title = "Action" },
        };
        public TableText[] GetJobsListHeadersData() => JobsListHeaders;
           
        List<Candidate> CandidatelistData = new List<Candidate>()
        {
            new Candidate { Id=1,Img="../assets/images/faces/1.jpg",Name="Samantha",JobTitle="UI/UX Designer",Location="Silicon Valley, CA", RatingCount="245",AnnualPay="$55,000-$80,000",Languages="English, Spanish",
                Ratings = new List<Ratings>{
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-half",NotRated=false},
                },
                JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-file-text-line",BadgeColor="primary",Badge=" Master's Degree"},
                    new JobBadge {Icon="ri-remote-control-line",BadgeColor="primary1",Badge=" Remote Work"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="info",Badge=" UI Designer (2+ yrs)"},
                    new JobBadge {Icon="ri-time-fill",BadgeColor="primary2",Badge=" Full Time"},
                },
            },
            new Candidate { Id=2,Img="../assets/images/faces/2.jpg",Name="Michael",JobTitle="Frontend Developer",Location="New York City, NY", RatingCount="189",AnnualPay="$65,000-$90,000",Languages="English, French",
                Ratings = new List<Ratings>{
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-half",NotRated=false},
                },
                JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-file-text-line",BadgeColor="primary",Badge=" Master's Degree"},
                    new JobBadge {Icon="ri-remote-control-line",BadgeColor="primary1",Badge=" Remote Work"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="info",Badge=" Frontend Developer  (3+ yrs)"},
                    new JobBadge {Icon="ri-time-fill",BadgeColor="primary2",Badge=" Full Time"},
                },
            },
            new Candidate { Id=3,Img="../assets/images/faces/3.jpg",Name="Emily",JobTitle="Graphic Designer",Location="Los Angeles, CA", RatingCount="189",AnnualPay="$50,000-$70,000",Languages="English, German",
                Ratings = new List<Ratings>{
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-half",NotRated=false},
                },
                JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-file-text-line",BadgeColor="primary",Badge=" Master's Degree"},
                    new JobBadge {Icon="ri-remote-control-line",BadgeColor="primary1",Badge=" Remote Work"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="info",Badge="Graphic Designer  (3+ yrs)"},
                    new JobBadge {Icon="ri-time-fill",BadgeColor="primary2",Badge=" Full Time"},
                },
            },
            new Candidate { Id=4,Img="../assets/images/faces/4.jpg",Name="James",JobTitle="Software Engineer",Location="Seattle, WA", RatingCount="172",AnnualPay="$80,000-$110,000",Languages="English, Mandarin",
                Ratings = new List<Ratings>{
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-half",NotRated=false},
                },
                JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-file-text-line",BadgeColor="primary",Badge=" Master's Degree"},
                    new JobBadge {Icon="ri-remote-control-line",BadgeColor="primary1",Badge="On-site Work"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="info",Badge="Software Engineer (5+ yrs)"},
                    new JobBadge {Icon="ri-time-fill",BadgeColor="primary2",Badge=" Contract"},
                },
            },
            new Candidate { Id=5,Img="../assets/images/faces/5.jpg",Name="Alexander",JobTitle="Digital Marketing Specialist",Location="Toronto, Canada", RatingCount="156",AnnualPay="$60,000-$85,000",Languages="English, French",
                Ratings = new List<Ratings>{
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star",NotRated=true},
                },
                JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-file-text-line",BadgeColor="primary",Badge=" Master's Degree"},
                    new JobBadge {Icon="ri-remote-control-line",BadgeColor="primary1",Badge="On-site Work"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="info",Badge="Digital Marketing (3+ yrs)"},
                    new JobBadge {Icon="ri-time-fill",BadgeColor="primary2",Badge=" Full Time"},
                },
            },
            new Candidate { Id=6,Img="../assets/images/faces/6.jpg",Name="Sophia",JobTitle="Data Analyst",Location="London, UK", RatingCount="178",AnnualPay="$70,000-$95,000",Languages="English, Spanish",
                Ratings = new List<Ratings>{
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star",NotRated=true},
                },
                JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-file-text-line",BadgeColor="primary",Badge=" Master's Degree"},
                    new JobBadge {Icon="ri-remote-control-line",BadgeColor="primary1",Badge="Remote Work"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="info",Badge="Data Analyst (4+ yrs)"},
                    new JobBadge {Icon="ri-time-fill",BadgeColor="primary2",Badge=" Part Time"},
                },
            },
            new Candidate { Id=7,Img="../assets/images/faces/7.jpg",Name="Marcus",JobTitle="Software Engineer",Location="New York City, NY", RatingCount="120",AnnualPay="$85,000-$110,000",Languages="English",
                Ratings = new List<Ratings>{
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star",NotRated=true},
                    new Ratings {Rate = "bi bi-star",NotRated=true},
                },
                JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-file-text-line",BadgeColor="primary",Badge=" Bachelor's Degree"},
                    new JobBadge {Icon="ri-remote-control-line",BadgeColor="primary1",Badge="On-site Work"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="info",Badge="Software Engineer (5+ yrs)"},
                    new JobBadge {Icon="ri-time-fill",BadgeColor="primary2",Badge=" Full Time"},
                },
            },
            new Candidate { Id=8,Img="../assets/images/faces/8.jpg",Name="Emily",JobTitle="Graphic Designer",Location="Los Angeles, CA", RatingCount="90",AnnualPay="$70,000 -$90,000",Languages="English",
                Ratings = new List<Ratings>{
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star",NotRated=true},
                    new Ratings {Rate = "bi bi-star",NotRated=true},
                    new Ratings {Rate = "bi bi-star",NotRated=true},
                },
                JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-file-text-line",BadgeColor="primary",Badge=" Bachelor's Degree"},
                    new JobBadge {Icon="ri-remote-control-line",BadgeColor="primary1",Badge="Remote Work"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="info",Badge=" Graphic Designer (3+ yrs)"},
                    new JobBadge {Icon="ri-time-fill",BadgeColor="primary2",Badge=" Part Time"},
                },
            },
            new Candidate { Id=9,Img="../assets/images/faces/9.jpg",Name=" Sophia ",JobTitle="Digital Marketer",Location=" London, UK", RatingCount="180",AnnualPay="£45,000 - £65,000",Languages=" English, French",
                Ratings = new List<Ratings>{
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star",NotRated=true},
                    new Ratings {Rate = "bi bi-star",NotRated=true},
                },
                JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-file-text-line",BadgeColor="primary",Badge=" Bachelor's Degree"},
                    new JobBadge {Icon="ri-remote-control-line",BadgeColor="primary1",Badge="Remote Work"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="info",Badge="  Digital Marketer (4+ yrs)"},
                    new JobBadge {Icon="ri-time-fill",BadgeColor="primary2",Badge=" Full Time"},
                },
            },
            new Candidate { Id=10,Img="../assets/images/faces/10.jpg",Name="Lucas",JobTitle="Data Analyst",Location="Toronto, Canada", RatingCount="110",AnnualPay=" CAD 65,000 - CAD 85,000",Languages=" English",
                Ratings = new List<Ratings>{
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star-fill",NotRated=false},
                    new Ratings {Rate = "bi bi-star",NotRated=true},
                    new Ratings {Rate = "bi bi-star",NotRated=true},
                    new Ratings {Rate = "bi bi-star",NotRated=true},
                },
                JobBadge = new List<JobBadge>
                {
                    new JobBadge {Icon="ri-file-text-line",BadgeColor="primary",Badge="Master's Degree"},
                    new JobBadge {Icon="ri-remote-control-line",BadgeColor="primary1",Badge=" On-site Work"},
                    new JobBadge {Icon="ri-time-line",BadgeColor="info",Badge="  Data Analyst (3+ yrs)"},
                    new JobBadge {Icon="ri-time-fill",BadgeColor="primary2",Badge=" Part Time"},
                },
            },
        }; 
        public List<Candidate> GetCandidatelistData() => CandidatelistData;

    }
}