using CardModel;
namespace CrmData
{
    public class CrmContacts
    {
        public string? ContactImg { get; set; }
        public string? ContactName { get; set; }
        public string? ContactDetails { get; set; }
        public string? ContactId { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Priority { get; set; }
        public string? Company { get; set; }
        public string? CompanyImg { get; set; }
        public string? Tag { get; set; }
        public string? LeadScore { get; set; }    
        public string? LeadSource { get; set; }    
        public bool Selected { get; set; } 
    }
    
    public class CrmCompanies
    {
        public string? CompaniesImg { get; set; }
        public string? CompaniesName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Industry { get; set; }
        public string? CompaniesSize { get; set; }
        public string? Contact { get; set; }
        public string? ContactImg { get; set; }
        public string? DealsId { get; set; }   
        public bool Selected { get; set; } 
    }

    public class DealCategory
    {
        public string? DealTitle { get; set; }
        public string? DealClass { get; set; }
        public string? DealcardClass { get; set; }
        public string?  Badge { get; set; }
        public string? DeaId { get; set; }
        public List<DealItem>? DealCard { get; set; }
    }
    public class DealItem
    {
        public string? Id { get; set; }
        public string? DealImg { get; set; }
        public string? Deal { get; set; }
        public string? Duration { get; set; }
        public string? Title { get; set; }
        public string? AmountType { get; set; }
        public string? Amount { get; set; }
        public string? Status { get; set; }
    }
    public class CrmLeads
    {
        public string? ContactImg { get; set; }
        public string? ContactName { get; set; }
        public string? CompanyImg { get; set; }
        public string? CompanyName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Status { get; set; }
        public string? LeadsSource { get; set; }
        public string? OwnerImg { get; set; }
        public string? OwnerName { get; set; }
        public string? LastContacted { get; set; }
        public bool Selected { get; set; } 
    }
   

    public class CrmDataService {
        public TableText[] ContactsTableHeaders = new TableText[]
        {
            new TableText { Title = "Contact Name" },
            new TableText { Title = "Email" },
            new TableText { Title = "Company" },
            new TableText { Title = "Lead Score" },
            new TableText { Title = "Priority" },
            new TableText { Title = "Phone" },
            new TableText { Title = "Tags" },
            new TableText { Title = "Lead Source" },
            new TableText { Title = "Actions" },
        };
        public TableText[] GetContactsHeadersData() => ContactsTableHeaders;
        private List<CrmContacts> CrmContactsLists = new List<CrmContacts>()
        {
            new CrmContacts { 
                ContactImg = "../assets/images/faces/4.jpg", 
                ContactName = "John Doe", 
                ContactDetails = "24, Jul 2023 - 4:45PM", 
                ContactId = "258",       
                Email="john.doe@example.com", 
                Phone = "123-456-7890",
                Company="Example Corp", 
                CompanyImg = "../assets/images/company-logos/2.png", 
                Priority = "High",
                LeadScore = "380", 
                Tag = "VIP Client", 
                LeadSource = "Referal", 
            },
            new CrmContacts { 
                ContactImg = "../assets/images/faces/12.jpg", 
                ContactName = "Alice Smith", 
                ContactDetails = "15, Jul 2023 - 11:45AM", 
                ContactId = "335",       
                Email="alice.smith@example.com", 
                Phone = "987-654-3210",
                Company="Smith & Co", 
                CompanyImg = "../assets/images/company-logos/3.png",
                Priority = "Medium",
                LeadScore = "425",  
                Tag = "Regular Client", 
                LeadSource = "LinkedIn", 
            },
            new CrmContacts { 
                ContactImg = "../assets/images/faces/14.jpg", 
                ContactName = "Michael Johnson", 
                ContactDetails = "10, Aug 2023 - 3:25PM", 
                ContactId = "685",       
                Email="michael.johnson@example.com", 
                Phone = "555-123-4567",
                Company="Johnson Enterprises", 
                CompanyImg = "../assets/images/company-logos/4.png", 
                Priority = "Low",
                LeadScore = "300",  
                Tag = "Potential Client", 
                LeadSource = "Website", 
            },
            new CrmContacts { 
                ContactImg = "../assets/images/faces/6.jpg", 
                ContactName = "Sophia Martinez", 
                ContactDetails = "18, Aug 2023 - 10:10AM", 
                ContactId = "425",       
                Email="sophia.martinez@example.com", 
                Phone = "234-567-8901",
                Company="Martinez Enterprises", 
                CompanyImg = "../assets/images/company-logos/5.png", 
                Priority = "Medium",
                LeadScore = "500",  
                Tag = "Potential Lead", 
                LeadSource = "Cold Call", 
            },
            new CrmContacts { 
                ContactImg = "../assets/images/faces/8.jpg", 
                ContactName = "David Wilson", 
                ContactDetails = "19, Jul 2023 - 12:41PM", 
                ContactId = "516",       
                Email="david.wilson@example.com", 
                Phone = "345-678-9012",
                Company="Wilson & Sons", 
                CompanyImg = "../assets/images/company-logos/6.png", 
                Priority = "Low",
                LeadScore = "320", 
                Tag = "Regular Client", 
                LeadSource = "Email Campaign", 
            },
            new CrmContacts { 
                ContactImg = "../assets/images/faces/9.jpg", 
                ContactName = "Emma Brown", 
                ContactDetails = "14, Aug 2023 - 5:18PM", 
                ContactId = "127",       
                Email="emma.brown@example.com", 
                Phone = "456-789-0123",
                Company="Brown Solutions", 
                CompanyImg = "../assets/images/company-logos/7.png", 
                Priority = "High",
                LeadScore = "280",  
                Tag = "VIP Client", 
                LeadSource = "Trade Show", 
            },
            new CrmContacts { 
                ContactImg = "../assets/images/faces/15.jpg", 
                ContactName = "Olivia Davis", 
                ContactDetails = "12, Jun 2023 - 11:38AM", 
                ContactId = "368",       
                Email="olivia.davis@example.com", 
                Phone = "567-890-1234",
                Company="Davis Consulting", 
                CompanyImg = "../assets/images/company-logos/8.png", 
                Priority = "Medium",
                LeadScore = "280",  
                Tag = "Regular Client", 
                LeadSource = "Webinar", 
            },
            new CrmContacts { 
                ContactImg = "../assets/images/faces/1.jpg", 
                ContactName = "William Clark", 
                ContactDetails = "19, May 2023 - 1:57PM", 
                ContactId = "563",       
                Email="william.clark@example.com", 
                Phone = "648-901-2345",
                Company="Clark Solutions", 
                CompanyImg = "../assets/images/company-logos/9.png", 
                Priority = "High",
                LeadScore = "350",  
                Tag = "VIP Client", 
                LeadSource = "Advertisement", 
            },
        };
        public List<CrmContacts> GetCrmContacts() => CrmContactsLists;
        public TableText[] CompaniesTableHeaders = new TableText[] {
            new TableText { Title = "Company Name" },
            new TableText { Title = "Email" },
            new TableText { Title = "Phone" },
            new TableText { Title = "Company Size" },
            new TableText { Title = "Industry" },
            new TableText { Title = "Key Contact" },
            new TableText { Title = "Total Deals" },
            new TableText { Title = "Actions" },
        };
        public TableText[] GetCompaniesHeadersData() => CompaniesTableHeaders;
        private List<CrmCompanies> CrmCompaniesLists = new List<CrmCompanies>()
        {
            new CrmCompanies { 
                CompaniesImg = "../assets/images/company-logos/2.png", 
                CompaniesName = "Alpha Solutions", 
                Email="alpha.solutions@example.com", 
                Phone = "1234-567-890",
                Industry = "Software Development",
                CompaniesSize="Enterprise", 
                Contact="Michael", 
                ContactImg = "../assets/images/faces/5.jpg", 
                DealsId = "350", 
            },
            new CrmCompanies { 
                CompaniesImg = "../assets/images/company-logos/3.png", 
                CompaniesName = "Beta Innovations", 
                Email="contact@betainnovations.com", 
                Phone = "9876-543-210",
                Industry = "Biotechnology",
                CompaniesSize="Startup", 
                Contact="Sophia", 
                ContactImg = "../assets/images/faces/6.jpg", 
                DealsId = "420", 
            },
            new CrmCompanies { 
                CompaniesImg = "../assets/images/company-logos/4.png", 
                CompaniesName = "Gamma Solutions", 
                Email="info@gammasolutions.com", 
                Phone = "555-123-4567",
                Industry = "Consulting Services",
                CompaniesSize="Enterprise", 
                Contact="Oliver", 
                ContactImg = "../assets/images/faces/7.jpg", 
                DealsId = "390", 
            },
            new CrmCompanies { 
                CompaniesImg = "../assets/images/company-logos/5.png", 
                CompaniesName = "Delta Tech Solutions", 
                Email="contact@deltatech.com", 
                Phone = "678-987-6543",
                Industry = "Technology Solutions",
                CompaniesSize="Startup", 
                Contact="Sophie", 
                ContactImg = "../assets/images/faces/8.jpg", 
                DealsId = "280", 
            },
            new CrmCompanies { 
                CompaniesImg = "../assets/images/company-logos/6.png", 
                CompaniesName = "Epsillon Innovations", 
                Email="info@epsiloninnovations.com", 
                Phone = "111-222-3333",
                Industry = "Innovation Services",
                CompaniesSize="Startup", 
                Contact="Emma", 
                ContactImg = "../assets/images/faces/9.jpg", 
                DealsId = "320", 
            },
            new CrmCompanies { 
                CompaniesImg = "../assets/images/company-logos/8.png", 
                CompaniesName = "Theta Systems", 
                Email="info@thetasystems.com", 
                Phone = "456-789-0123",
                Industry = "Software Solutions",
                CompaniesSize="Enterprise", 
                Contact="Liam", 
                ContactImg = "../assets/images/faces/10.jpg", 
                DealsId = "410", 
            },
            new CrmCompanies { 
                CompaniesImg = "../assets/images/company-logos/9.png", 
                CompaniesName = "Iota Innovations", 
                Email="contact@iotainnovations.com", 
                Phone = "333-444-5555",
                Industry = "Digital Marketing",
                CompaniesSize="Startup", 
                Contact="Ava", 
                ContactImg = "../assets/images/faces/11.jpg", 
                DealsId = "290", 
            },
            new CrmCompanies { 
                CompaniesImg = "../assets/images/company-logos/4.png", 
                CompaniesName = "Alpha Solutions", 
                Email="info@alphasolutions.com", 
                Phone = "1234-567-890",
                Industry = "Technology Services",
                CompaniesSize="Enterprise",  
                Contact="John", 
                ContactImg = "../assets/images/faces/7.jpg", 
                DealsId = "570", 
            },
            new CrmCompanies { 
                CompaniesImg = "../assets/images/company-logos/5.png", 
                CompaniesName = "Gamma Industries", 
                Email="contact@gammatech.com", 
                Phone = "8765-432-109",
                Industry = "Engineering",
                CompaniesSize="Startup", 
                Contact="Emily", 
                ContactImg = "../assets/images/faces/9.jpg", 
                DealsId = "320", 
            },
        };
        public List<CrmCompanies> GetCrmCompanies() => CrmCompaniesLists;
        private List<DealCategory> DealList = new List<DealCategory>
        {
            new DealCategory {
                DealTitle = "Leads Discovered",
                DealcardClass = "primary",
                DealClass = "lead-discovered",
                DeaId ="leads-discovered",
                Badge = "24",
                DealCard = new List<DealItem>
                {
                    new DealItem
                    {
                        Id = "01",
                        DealImg = "../assets/images/faces/11.jpg",
                        Deal = "John Doe",
                        Duration = "21,May 2024 - 10:25AM",
                        Title = "Beta Innovations",
                        AmountType = "Amount",
                        Amount = "$50,000",
                        Status = "Initech Info",
                    },
                    new DealItem
                    {
                        Id = "02",
                        DealImg = "../assets/images/faces/12.jpg",
                        Deal = "Jane Smith",
                        Duration = "15, April 2024 - 02:15PM",
                        Title = "Alpha Solutions",
                        AmountType = "Amount",
                        Amount = "$75,000",
                        Status = "TechCorp",
                    },
                    new DealItem
                    {
                        Id = "03",
                        DealImg = "../assets/images/faces/13.jpg",
                        Deal = "Michael Johnson",
                        Duration = "05, March 2024 - 11:30AM",
                        Title = "Gamma Enterprises",
                        AmountType = "Amount",
                        Amount = "$100,000",
                        Status = "NextGen Inc",
                    },
                    new DealItem
                    {
                        Id = "04",
                        DealImg = "../assets/images/faces/14.jpg",
                        Deal = "Emma Wilson",
                        Duration = "10, February 2024 - 09:45AM",
                        Title = "Delta Dynamics",
                        AmountType = "Amount",
                        Amount = "$120,000",
                        Status = "InnovateX",
                    },
                }
            },
            new DealCategory {
                DealTitle = "Qualified Leads",
                DealcardClass = "primary1",
                DealClass = "lead-qualified",
                DeaId ="leads-qualified",
                Badge = "17",
                DealCard = new List<DealItem>
                {
                    new DealItem
                    {
                        Id = "05",
                        DealImg = "../assets/images/faces/15.jpg",
                        Deal = "Daniel Brown",
                        Duration = "18, January 2024 - 03:20PM",
                        Title = "Omega Solutions",
                        Amount = "$95,000",
                        AmountType = "Amount",
                        Status = "SkyTech",
                    },
                    new DealItem
                    {
                        Id = "06",
                        DealImg = "../assets/images/faces/12.jpg",
                        Deal = "Emily Brown",
                        Duration = "18, June 2024 - 11:15AM",
                        Title = "Delta Innovations",
                        AmountType = "Amount",
                        Amount = "$65,000",
                        Status = "Tech Dynamics",
                    },
                    new DealItem
                    {
                        Id = "07",
                        DealImg = "../assets/images/faces/13.jpg",
                        Deal = "James Wilson",
                        Duration = "12, June 2024 - 09:30AM",
                        Title = "Gamma Enterprises",
                        AmountType = "Amount",
                        Amount = "$80,000",
                        Status = "Tech Solutions Inc.",
                    },
                    new DealItem
                    {
                        Id = "08",
                        DealImg = "../assets/images/faces/12.jpg",
                        Deal = "Liam Smith",
                        Duration = "30, June 2024 - 01:45PM",
                        Title = "Zeta Corporation",
                        AmountType = "Agreed Amount",
                        Amount = "$105,000",
                        Status = "TechVision Ltd.",
                    },
                }
            },
            new DealCategory {
                DealTitle = "Contact Initiated",
                DealcardClass = "primary2",
                DealClass = "contact-initiated",
                DeaId ="contact-initiated",
                Badge = "5",
                DealCard = new List<DealItem>
                {
                    new DealItem
                    {
                        Id = "09",
                        DealImg = "../assets/images/faces/14.jpg",
                        Deal = "Sarah Martinez",
                        Duration = "05, June 2024 - 10:45AM",
                        Title = "AlphaTech Solutions",
                        AmountType = "Amount",
                        Amount = "$75,000",
                        Status = "InnovateX",
                    },
                    new DealItem
                    {
                        Id = "10",
                        DealImg = "../assets/images/faces/15.jpg",
                        Deal = "Robert Lee",
                        Duration = "30, May 2024 - 02:00PM",
                        Title = "Omega Ventures",
                        AmountType = "Amount",
                        Amount = "$90,000",
                        Status = "NextGen Tech",
                    },
                }
            },
            new DealCategory {
                DealTitle = "Needs Identified",
                DealcardClass = "primary3",
                DealClass = "need-identified",
                DeaId ="needs-identified",
                Badge = "43",
                DealCard = new List<DealItem>
                {
                    new DealItem
                    {
                        Id = "11",
                        DealImg = "../assets/images/faces/11.jpg",
                        Deal = "David Wilson",
                        Duration = "08, June 2024 - 09:45AM",
                        Title = "Alpha Solutions",
                        AmountType = "Amount",
                        Amount = "$70,000",
                        Status = "Tech Innovations",
                    },
                    new DealItem
                    {
                        Id = "12",
                        DealImg = "../assets/images/faces/16.jpg",
                        Deal = "Emma Clark",
                        Duration = "20, May 2024 - 03:30PM",
                        Title = "Zeta Dynamics",
                        AmountType = "Amount",
                        Amount = "$85,000",
                        Status = "TechStar Solutions",
                    },
                    new DealItem
                    {
                        Id = "13",
                        DealImg = "../assets/images/faces/11.jpg",
                        Deal = "David Wilson",
                        Duration = "07, June 2024 - 09:45AM",
                        Title = "AlphaTech Solutions",
                        AmountType = "Budget",
                        Amount = "$100,000",
                        Status = "Tech Innovations",
                    },
                    new DealItem
                    {
                        Id = "14",
                        DealImg = "../assets/images/faces/15.jpg",
                        Deal = "Sophie Adams",
                        Duration = "14, June 2024 - 11:30AM",
                        Title = "GammaTech Solutions",
                        AmountType = "Estimated Revenue",
                        Amount = "$120,000",
                        Status = "InnovateX",
                    },
                }
            },
            new DealCategory {
                DealTitle = "Negotiation",
                DealcardClass = "secondary",
                DealClass = "negotiation",
                DeaId ="negotiation",
                Badge = "15",
                DealCard = new List<DealItem>
                {
                    new DealItem
                    {
                        Id = "15",
                        DealImg = "../assets/images/faces/9.jpg",
                        Deal = "Olivia Moore",
                        Duration = "25, May 2024 - 02:15PM",
                        Title = "Delta Dynamics",
                        AmountType = "Expected Investment",
                        Amount = "$90,000",
                        Status = "TechStar Solutions",
                    },
                    new DealItem
                    {
                        Id = "16",
                        DealImg = "../assets/images/faces/15.jpg",
                        Deal = "Michael Johnson",
                        Duration = "15, June 2024 - 11:00AM",
                        Title = "AlphaTech Solutions",
                        AmountType = "Proposed Amount",
                        Amount = "$120,000",
                        Status = "Tech Innovations",
                    },
                    new DealItem
                    {
                        Id = "17",
                        DealImg = "../assets/images/faces/16.jpg",
                        Deal = "Emily Davis",
                        Duration = "10, June 2024 - 09:30AM",
                        Title = "BetaTech Innovations",
                        AmountType = "Estimated Budget",
                        Amount = "$150,000",
                        Status = "Tech Solutions Ltd.",
                    },
                }
            },
            new DealCategory {
                DealTitle = "Deal Finalized",
                DealcardClass = "success",
                DealClass = "deal-finalized",
                DeaId ="deal-finalized",
                Badge = "127 Deals",
                DealCard = new List<DealItem>
                {
                    new DealItem
                    {
                        Id = "18",
                        DealImg = "../assets/images/faces/12.jpg",
                        Deal = "Emma Thompson",
                        Duration = "25, June 2024 - 03:45PM",
                        Title = "Delta Dynamics",
                        AmountType = "Amount",
                        Amount = "$120,000",
                        Status = "TechStar Innovations",
                    },
                    new DealItem
                    {
                        Id = "19",
                        DealImg = "../assets/images/faces/3.jpg",
                        Deal = "Sophia Garcia",
                        Duration = "18, June 2024 - 09:30AM",
                        Title = "Completed Gamma Technologies",
                        AmountType = "Investment",
                        Amount = "$85,000",
                        Status = "TechSolutions Inc.",
                    },
                }
            },
        };
        public List<DealCategory> GetDealList() => DealList;
        public TableText[] LeadsTableHeaders = new TableText[]
        {
            new TableText { Title = "Contact Name" },
            new TableText { Title = "Company" },
            new TableText { Title = "Email" },
            new TableText { Title = "Lead Status" },
            new TableText { Title = "Phone" },
            new TableText { Title = "Lead Source" },
            new TableText { Title = "Owner" },
            new TableText { Title = "Last Contracted" },
            new TableText { Title = "Actions" },
        };
        public TableText[] GetLeadsHeadersData() => LeadsTableHeaders;
        private List<CrmLeads> CrmLeadsLists = new List<CrmLeads>()
        {
            new CrmLeads { 
                ContactImg = "../assets/images/faces/4.jpg", 
                ContactName = "Catalina", 
                Email="Catalina2981@gmail.com", 
                Phone = "1678-28993-223",
                Status = "New Lead",
                CompanyName="Spruko Technologies", 
                CompanyImg = "../assets/images/company-logos/1.png", 
                LeadsSource = "Social Media", 
                OwnerImg = "../assets/images/faces/2.jpg", 
                OwnerName = "Jane Smith", 
                LastContacted = "2024-06-15", 
            },
            new CrmLeads { 
                ContactImg = "../assets/images/faces/5.jpg", 
                ContactName = "David Johnson", 
                Email="david.johnson@example.com", 
                Phone = "+1-987-654-3210",
                Status = "Prospect",
                CompanyName="Global Solutions Ltd.", 
                CompanyImg = "../assets/images/company-logos/2.png", 
                LeadsSource = "Email Campaign", 
                OwnerImg = "../assets/images/faces/3.jpg", 
                OwnerName = "Michael Brown", 
                LastContacted = "2024-06-14", 
            },
            new CrmLeads { 
                ContactImg = "../assets/images/faces/6.jpg", 
                ContactName = "Sophia Adams", 
                Email="sophia.adams@example.com", 
                Phone = "9876-543-210",
                Status = "Lead",
                CompanyName="Beta Innovations", 
                CompanyImg = "../assets/images/company-logos/3.png", 
                LeadsSource = "Web Site", 
                OwnerImg = "../assets/images/faces/7.jpg", 
                OwnerName = "Emma Wilson", 
                LastContacted = "2024-06-13",
            },
            new CrmLeads { 
                ContactImg = "../assets/images/faces/10.jpg", 
                ContactName = "Sophie Turner", 
                Email="sophie.turner@example.com", 
                Phone = "+61-9876-543-210",
                Status = "Prospect",
                CompanyName="Delta Enterprises", 
                CompanyImg = "../assets/images/company-logos/5.png", 
                LeadsSource = "Cold Call", 
                OwnerImg = "../assets/images/faces/11.jpg", 
                OwnerName = "Olivia Moore", 
                LastContacted = "2024-06-11", 
            },
            new CrmLeads { 
                ContactImg = "../assets/images/faces/12.jpg", 
                ContactName = "Emma Garcia", 
                Email="emma.garcia@example.com", 
                Phone = "+55-1234-5678",
                Status = "Lead",
                CompanyName="Gamma Solutions", 
                CompanyImg = "../assets/images/company-logos/6.png", 
                LeadsSource = "Referral", 
                OwnerImg = "../assets/images/faces/13.jpg", 
                OwnerName = "Daniel Harris", 
                LastContacted = "2024-06-10", 
            },
            new CrmLeads { 
                ContactImg = "../assets/images/faces/14.jpg", 
                ContactName = "Sophia Lee", 
                Email="sophia.lee@example.com", 
                Phone = "+91-987-654-3210",
                Status = "Lead",
                CompanyName="Omega Solutions", 
                CompanyImg = "../assets/images/company-logos/7.png", 
                LeadsSource = "Website", 
                OwnerImg = "../assets/images/faces/15.jpg", 
                OwnerName = "Sophie Turner", 
                LastContacted = "2024-06-09", 
            },
            new CrmLeads { 
                ContactImg = "../assets/images/faces/16.jpg", 
                ContactName = "Lucas Martin", 
                Email="lucas.martin@example.com", 
                Phone = "+1-234-567-8901",
                Status = "Prospect",
                CompanyName="Phoenix Innovations", 
                CompanyImg = "../assets/images/company-logos/8.png", 
                LeadsSource = "Cold Call", 
                OwnerImg = "../assets/images/faces/11.jpg", 
                OwnerName = "Olivia Moore", 
                LastContacted = "2024-06-08", 
            },
            new CrmLeads { 
                ContactImg = "../assets/images/faces/4.jpg", 
                ContactName = "Catalina", 
                Email="Catalina2981@gmail.com", 
                Phone = "1678-28993-223",
                Status = "New Lead",
                CompanyName="Spruko Technologies", 
                CompanyImg = "../assets/images/company-logos/1.png", 
                LeadsSource = "Social Media", 
                OwnerImg = "../assets/images/faces/2.jpg", 
                OwnerName = "Jane Smith", 
                LastContacted = "2024-06-15", 
            },
            new CrmLeads { 
                ContactImg = "../assets/images/faces/12.jpg", 
                ContactName = "Isabella Adams", 
                Email="isabella.adams@example.com", 
                Phone = "+7-987-654-3210",
                Status = "Lead",
                CompanyName="Gamma Technologies", 
                CompanyImg = "../assets/images/company-logos/9.png", 
                LeadsSource = "Advertisement", 
                OwnerImg = "../assets/images/faces/2.jpg", 
                OwnerName = "Sophia Lee", 
                LastContacted = "2024-06-07", 
            },
        };
        public List<CrmLeads> GetCrmLeads() => CrmLeadsLists;    


    }
}