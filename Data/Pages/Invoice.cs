using CardModel;
namespace InvoiceData
{
    public class CreateInvoiceList
    {
        public decimal ID { get; set; }
        public string? Unit { get; set; } 
        public string? Total { get; set; } 
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
    }    
    public class Invoicechart {
        public string? InvoiceValue { get; set; }
        public decimal InvoiceTotal { get; set; }
        public decimal InvoicePaid { get; set; }
        public decimal InvoicePending { get; set; }
        public decimal InvoiceOverdue { get; set; }
        
    } ;
    public class Invoice
    {   
        public decimal Id { get; set; }
        public string? ClientImg { get; set; }
        public string? ClientName { get; set; }
        public string? ClientEmail { get; set; }
        public string? InvoiceId { get; set; }
        public string? IssuedDate { get; set; }
        public string? Amount { get; set; }
        public string? Status { get; set; }
        public string? DueDate { get; set; }
    }

    public class InvoiceService {
        public TableText[] CreateInvoiceHeaders = new TableText[]
        {
            new TableText { Title = "ID" },
            new TableText { Title = "PRODUCT NAME" },
            new TableText { Title = "DESCRIPTION" },
            new TableText { Title = "QUANTITY" },
            new TableText { Title = "PRICE PER UNIT" },
            new TableText { Title = "TOTAL" },
            new TableText { Title = "ACTION" },
        };        
        public TableText[] GetCreateInvoiceHeadersData() => CreateInvoiceHeaders;
        private List<CreateInvoiceList>  CreateInvoiceListData  = new List<CreateInvoiceList>()
        {
            new CreateInvoiceList{ ID= 1,Unit= "84.00", Total= "251.00"},
            new CreateInvoiceList{ ID= 2,Unit= "84.00", Total= "251.00"},
        };       
        public List<CreateInvoiceList> GetCreateInvoiceListData() => CreateInvoiceListData;
        public TableText[] InvoiceDeatilsHeaders = new TableText[]
        {
            new TableText { Title = "BRAND NAME"},
            new TableText { Title = "DESCRIPTION"},
            new TableText { Title = "QUANTITY"},
            new TableText { Title = "PRICE PER UNIT"},
            new TableText { Title = "TOTAL"},
        };        
        public TableText[] GetInvoiceDeatilsHeadersData() => InvoiceDeatilsHeaders;
        private List<CreateInvoiceList>  InvoiceDeatilsListData  = new List<CreateInvoiceList>()
        {
            new CreateInvoiceList{ ID= 1, Name ="Cresta & Co (Headphones)",Description ="Noise-cancelling technology, Bluetooth connectivity",Quantity =3,Unit ="84", Total ="251"},
            new CreateInvoiceList{ ID= 2, Name ="Zephyr & Sons (Sneakers)",Description ="Lightweight mesh upper, durable rubber outsole.",Quantity =2,Unit ="503", Total ="503"},
            new CreateInvoiceList{ ID= 3, Name ="Nova & Nexus (Watch)",Description ="scratch-resistant sapphire crystal",Quantity =1,Unit ="689", Total ="689"},
            new CreateInvoiceList{ ID= 4, Name ="Everglow & Essentials (Skincare Set)",Description ="Complete daily regimen",Quantity =3,Unit ="486", Total ="939"},
            new CreateInvoiceList{ ID= 5, Name ="Azure & Attire (Dress)",Description ="Flowy chiffon fabric, adjustable",Quantity =2,Unit ="648", Total ="648"},
        };       
        public List<CreateInvoiceList> GetInvoiceDeatilsListData() => InvoiceDeatilsListData;
        public static List<Invoicechart> GetInvoicecharts()
        {
            var Invoicecharts = new List<Invoicechart> ();
            Invoicecharts.Add(new Invoicechart { InvoiceValue = "Jan", InvoiceTotal = 56, InvoicePaid = 56, InvoicePending = 75 , InvoiceOverdue = 89 });
            Invoicecharts.Add(new Invoicechart { InvoiceValue = "Feb", InvoiceTotal = 55, InvoicePaid = 89, InvoicePending = 86 , InvoiceOverdue = 44 });
            Invoicecharts.Add(new Invoicechart { InvoiceValue = "Mar", InvoiceTotal = 25, InvoicePaid = 45, InvoicePending = 35 , InvoiceOverdue = 62 });
            Invoicecharts.Add(new Invoicechart { InvoiceValue = "Apr", InvoiceTotal = 65, InvoicePaid = 48, InvoicePending =  24 , InvoiceOverdue = 77 });
            Invoicecharts.Add(new Invoicechart { InvoiceValue = "May", InvoiceTotal = 89, InvoicePaid = 44, InvoicePending = 68 , InvoiceOverdue = 24 });
            Invoicecharts.Add(new Invoicechart { InvoiceValue = "Jun", InvoiceTotal = 45, InvoicePaid = 35, InvoicePending = 57 , InvoiceOverdue = 65 });
            Invoicecharts.Add(new Invoicechart { InvoiceValue = "Jul", InvoiceTotal = 65, InvoicePaid = 48, InvoicePending = 94 , InvoiceOverdue = 48 });
            Invoicecharts.Add(new Invoicechart { InvoiceValue = "Aug", InvoiceTotal = 56, InvoicePaid = 56, InvoicePending = 95 , InvoiceOverdue = 39 });
            Invoicecharts.Add(new Invoicechart { InvoiceValue = "Sep", InvoiceTotal = 78, InvoicePaid = 89, InvoicePending = 78 , InvoiceOverdue = 47 });
            Invoicecharts.Add(new Invoicechart { InvoiceValue = "Oct", InvoiceTotal = 45, InvoicePaid = 46, InvoicePending = 48 , InvoiceOverdue = 46 });
            Invoicecharts.Add(new Invoicechart { InvoiceValue = "Nov", InvoiceTotal = 56, InvoicePaid = 75, InvoicePending = 68 , InvoiceOverdue = 57 });
            Invoicecharts.Add(new Invoicechart { InvoiceValue = "Dec", InvoiceTotal = 48, InvoicePaid = 42, InvoicePending = 99 , InvoiceOverdue = 88 });
            return Invoicecharts;
        }
        private List<Invoice> Invoices = new List<Invoice>()
        {
            new Invoice { 
                Id=1,
                ClientName = "Henry Milo",
                ClientEmail="henrymilo2416@gmail.com",
                ClientImg = "../assets/images/faces/11.jpg", 
                InvoiceId = " #SHG20241323 ", 
                IssuedDate = "13,Mar 2024", 
                Amount = "$898.12", 
                Status = "Paid",
                DueDate = "25,May 2024" 
            },
            new Invoice { 
                Id=2,
                ClientName = "Priya Riva",
                ClientEmail="priyariva3214@gmail.com", 
                ClientImg = "../assets/images/faces/7.jpg", 
                InvoiceId = " #SHG20244578 ", 
                IssuedDate = "	26,Apr 2024", 
                Amount = "$235.52", 
                Status = "Pending",
                DueDate = "13,May 2024" 
            },
            new Invoice { 
                Id=3,
                ClientName = "Calvin James",
                ClientEmail="calvinjames143@gmail.com", 
                ClientImg = "../assets/images/faces/15.jpg", 
                InvoiceId = " #SHG20240012 ", 
                IssuedDate = "30,Mar 2024", 
                Amount = "$4872.41", 
                Status = "Overdue",
                DueDate = "30,May 2024" 
            },
            new Invoice { 
                Id=4,
                ClientName = "Sebastian Leo",
                ClientEmail="sebastianleo@gmail.com", 
                ClientImg = "../assets/images/faces/12.jpg", 
                InvoiceId = " #SHG20246631 ", 
                IssuedDate = "18,Mar 2024", 
                Amount = "$457.56", 
                Status = "Paid",
                DueDate = "18,May 2024" 
            },
            new Invoice { 
                Id=5,
                ClientName = "Anna Angel",
                ClientEmail="annaangel4@gmail.com", 
                ClientImg = "../assets/images/faces/4.jpg", 
                InvoiceId = " #SHG20249897 ", 
                IssuedDate = "18,Mar 2024", 
                Amount = "$2,568.66", 
                Status = "Due By 1 Day",
                DueDate = "18,May 2024" 
            },
            new Invoice { 
                Id=6,
                ClientName = "Rani Advitha",
                ClientEmail="raniadvitha87@gmail.com", 
                ClientImg = "../assets/images/faces/7.jpg", 
                InvoiceId = " #SHG20245757", 
                IssuedDate = "02,Mar 2024", 
                Amount = "$7,896.36", 
                Status = "Paid",
                DueDate = "18,May 2024" 
            },
            new Invoice { 
                Id=7,
                ClientName = "Helma Finlee",
                ClientEmail="helmafinlee@gmail.com", 
                ClientImg = "../assets/images/faces/9.jpg", 
                InvoiceId = " #SHG20246301 ", 
                IssuedDate = "15,Mar 2024", 
                Amount = "$1,999.99", 
                Status = "Paid",
                DueDate = "15,May 2024" 
            },
            new Invoice { 
                Id=8,
                ClientName = "Robert Max",
                ClientEmail="robertmax@gmail.com", 
                ClientImg = "../assets/images/faces/13.jpg", 
                InvoiceId = " #SHG20241603 ", 
                IssuedDate = "21,Mar 2024", 
                Amount = "$2,985.33", 
                Status = "Pending",
                DueDate = "21,May 2024" 
            },
            new Invoice { 
                Id=9,
                ClientName = "Alisa Juliet",
                ClientEmail="alisajuliet555@gmail.com", 
                ClientImg = "../assets/images/faces/8.jpg", 
                InvoiceId = " #SHG20242434 ", 
                IssuedDate = "08,Jul 2024", 
                Amount = "$1,841.60", 
                Status = "Paid", 
                DueDate = "15,Mar 2024" 
            },
            
        };
        public List<Invoice> GetInvoices() => Invoices;
        
        public TableText[] InvoiceHeaders = new TableText[]
        {
            new TableText { Title = "Client"},
            new TableText { Title = "Invoice ID"},
            new TableText { Title = "Issued Date"},
            new TableText { Title = "Amount"},
            new TableText { Title = "Status"},
            new TableText { Title = "Due Date"},
            new TableText { Title = "Action"},
        };        
        public TableText[] GetInvoiceHeadersData() => InvoiceHeaders;
        
        private List<MainCard>  InvoiceCardData  = new List<MainCard>()
        {
            new MainCard {
                id = 1,
                title = "Total Amount",
                svg = "<svg xmlns='http://www.w3.org/2000/svg' width='44' height='44' viewBox='0 0 24 24' stroke-width='1.5' stroke='var(--primary-color)' fill='none' stroke-linecap='round' stroke-linejoin='round'> <path stroke='none' d='M0 0h24v24H0z' fill='none'></path> <path d='M5 21v-16a2 2 0 0 1 2 -2h10a2 2 0 0 1 2 2v16l-3 -2l-2 2l-2 -2l-2 2l-2 -2l-3 2m4 -14h6m-6 4h6m-2 4h2'></path> </svg>",
                iconclass ="primary",
                price = "$386k" ,
                status ="Increased",
                statusclass ="text-success",
                statusdata ="2.13%",
                statusicon ="ti ti-arrow-narrow-up",
                IsRounded=true,
                MainBgImg=true,
                Badge="bg-primary",
                BadgeValue="12,895"
            },
            new MainCard {
                id = 2,
                title = "Total Paid",
                svg = "<svg xmlns='http://www.w3.org/2000/svg' class='icon icon-tabler icon-tabler-discount-check' width='44' height='44' viewBox='0 0 24 24' stroke-width='1.5' stroke='var(--primary-tint1-color)' fill='none' stroke-linecap='round' stroke-linejoin='round'> <path stroke='none' d='M0 0h24v24H0z' fill='none'></path> <path d='M5 7.2a2.2 2.2 0 0 1 2.2 -2.2h1a2.2 2.2 0 0 0 1.55 -.64l.7 -.7a2.2 2.2 0 0 1 3.12 0l.7 .7c.412 .41 .97 .64 1.55 .64h1a2.2 2.2 0 0 1 2.2 2.2v1c0 .58 .23 1.138 .64 1.55l.7 .7a2.2 2.2 0 0 1 0 3.12l-.7 .7a2.2 2.2 0 0 0 -.64 1.55v1a2.2 2.2 0 0 1 -2.2 2.2h-1a2.2 2.2 0 0 0 -1.55 .64l-.7 .7a2.2 2.2 0 0 1 -3.12 0l-.7 -.7a2.2 2.2 0 0 0 -1.55 -.64h-1a2.2 2.2 0 0 1 -2.2 -2.2v-1a2.2 2.2 0 0 0 -.64 -1.55l-.7 -.7a2.2 2.2 0 0 1 0 -3.12l.7 -.7a2.2 2.2 0 0 0 .64 -1.55v-1'></path> <path d='M9 12l2 2l4 -4'></path> </svg>",
                iconclass ="primary1",
                price = "$127k" ,
                status ="Decreased",
                statusclass ="text-danger",
                statusdata ="1.05%",
                statusicon ="ti ti-arrow-narrow-down",
                IsRounded=true,
                MainBgImg=true,
                Badge="bg-primary1",
                BadgeValue="3,457"
            },
            new MainCard {
                id = 3,
                title = "Pending Invoices",
                svg = "<svg xmlns='http://www.w3.org/2000/svg' class='icon icon-tabler icon-tabler-help-octagon' width='44' height='44' viewBox='0 0 24 24' stroke-width='1.5' stroke='var(--primary-tint2-color)' fill='none' stroke-linecap='round' stroke-linejoin='round'> <path stroke='none' d='M0 0h24v24H0z' fill='none'></path> <path d='M12.802 2.165l5.575 2.389c.48 .206 .863 .589 1.07 1.07l2.388 5.574c.22 .512 .22 1.092 0 1.604l-2.389 5.575c-.206 .48 -.589 .863 -1.07 1.07l-5.574 2.388c-.512 .22 -1.092 .22 -1.604 0l-5.575 -2.389a2.036 2.036 0 0 1 -1.07 -1.07l-2.388 -5.574a2.036 2.036 0 0 1 0 -1.604l2.389 -5.575c.206 -.48 .589 -.863 1.07 -1.07l5.574 -2.388a2.036 2.036 0 0 1 1.604 0z'></path> <path d='M12 16v.01'></path> <path d='M12 13a2 2 0 0 0 .914 -3.782a1.98 1.98 0 0 0 -2.414 .483'></path> </svg>",
                iconclass ="primary2",
                price = "57" ,
                status ="Decreased",
                statusclass ="text-danger",
                statusdata ="2.06%",
                statusicon ="ti ti-arrow-narrow-down",
                IsRounded=true,
                MainBgImg=true,
                Badge="bg-success",
                BadgeValue="5,447"
            },
            new MainCard {
                id = 4,
                title = "Overdue Invoices",
                svg = "<svg xmlns='http://www.w3.org/2000/svg' class='icon icon-tabler icon-tabler-hourglass' width='44' height='44' viewBox='0 0 24 24' stroke-width='1.5' stroke='var(--primary-tint3-color)' fill='none' stroke-linecap='round' stroke-linejoin='round'> <path stroke='none' d='M0 0h24v24H0z' fill='none'></path> <path d='M6.5 7h11'></path> <path d='M6.5 17h11'></path> <path d='M6 20v-2a6 6 0 1 1 12 0v2a1 1 0 0 1 -1 1h-10a1 1 0 0 1 -1 -1z'></path> <path d='M6 4v2a6 6 0 1 0 12 0v-2a1 1 0 0 0 -1 -1h-10a1 1 0 0 0 -1 1z'></path> </svg>",
                iconclass ="primary3",
                price = "45K" ,
                status ="Increased",
                statusclass ="text-success",
                statusdata ="1.3%",
                statusicon ="ti ti-arrow-narrow-up",
                IsRounded=true,
                MainBgImg=true,
                Badge="bg-primary3",
                BadgeValue="2,145"
            },
        };       
        public List<MainCard> GetInvoiceCardData() => InvoiceCardData;
    }
}