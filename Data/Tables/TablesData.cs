using CardModel;

namespace TablesData
{
    public class TableBodyData {
    
        public string? id { get; set; }
        public string? img { get; set; }
        public string? name { get; set; }
        public string? lastname { get; set; }
        public string? category { get; set; }
        public string? number { get; set; }
        public string? quantity { get; set; }
        public string? email { get; set; }
        public string? date { get; set; }
        public string? price { get; set; }
        public string? status { get; set; }
        public string? statusbg { get; set; } 
        public string? percentage { get; set; } 
        public string? trbg { get; set; }       
        public List<TeamList>? Team { get; set; }
    } ;    
    public class TeamList
    {
        public string? img { get; set; }
    }
     public class TablesService {
        private TableText[] BasicHeaderData = new TableText[]
        {
            new TableText { Title = "Name"},
            new TableText { Title = "Created On"},
            new TableText { Title = "Number"},
            new TableText { Title = "Status"},
        }; 
        public TableText[] GetBasicHeaderData() => BasicHeaderData;
        private TableText[] BorderedHeaderData = new TableText[]
        {
            new TableText { Title = "User"},
            new TableText { Title = "Status"},
            new TableText { Title = "Email"},
            new TableText { Title = "Action"},
        }; 
        public TableText[] GetBorderedHeaderData() => BorderedHeaderData;
        private TableText[] BorderedColorHeaderData = new TableText[]
        {
            new TableText { Title = "Order"},
            new TableText { Title = "Date"},
            new TableText { Title = "Customer"},
            new TableText { Title = "Action"},
        }; 
        public TableText[] GetBorderedColorHeaderData() => BorderedColorHeaderData;
        private TableText[] TWBHeaderData = new TableText[]
        {
            new TableText { Title = "User Name"},
            new TableText { Title = "Transaction Id"},
            new TableText { Title = "Created"},
            new TableText { Title = "Status"},
        }; 
        public TableText[] GetTWBHeaderData() => TWBHeaderData;
        private TableText[] TGDHeaderData = new TableText[]
        {
            new TableText { Title = "Product"},
            new TableText { Title = "Seller"},
            new TableText { Title = "Sale Percentage"},
            new TableText { Title = "Quantity Sold"},
        }; 
        public TableText[] GetTGDHeaderData() => TGDHeaderData;
        private TableText[] StripedrowsHeaderData = new TableText[]
        {
            new TableText { Title = "ID"},
            new TableText { Title = "Date"},
            new TableText { Title = "Customer"},
            new TableText { Title = "Action"},
        }; 
        public TableText[] GetStripedrowsHeaderData() => StripedrowsHeaderData;
        private TableText[] ColorHeaderData = new TableText[]
        {
            new TableText { Title = "#"},
            new TableText { Title = "First"},
            new TableText { Title = "Last"},
            new TableText { Title = "Handle"},
        }; 
        public TableText[] GetColorHeaderData() => ColorHeaderData;
        private TableText[] HoverableRowsHeaderData = new TableText[]
        {
            new TableText { Title = "Product Manager"},
            new TableText { Title = "Category"},
            new TableText { Title = "Team"},
            new TableText { Title = "Status"},
        }; 
        public TableText[] GetHoverableRowsHeaderData() => HoverableRowsHeaderData;
        private TableText[] HoverableRowswithStripsHeaderData = new TableText[]
        {
            new TableText { Title = "Invoice"},
            new TableText { Title = "Customer"},
            new TableText { Title = "Status"},
            new TableText { Title = "Date"},
        }; 
        public TableText[] GetHoverableRowswithStripsHeaderData() => HoverableRowswithStripsHeaderData;
        private TableText[] HeadColorHeaderData = new TableText[]
        {
            new TableText { Title = "User Name"},
            new TableText { Title = "Transaction Id"},
            new TableText { Title = "Created"},
            new TableText { Title = "Status"},
        }; 
        public TableText[] GetHeadColorHeaderData() => HeadColorHeaderData;
        private TableText[] TableFootHeaderData = new TableText[]
        {
            new TableText { Title = "S.No"},
            new TableText { Title = "Team"},
            new TableText { Title = "Matches Won"},
            new TableText { Title = "Win Ratio"},
        }; 
        public TableText[] GetTableFootHeaderData() => TableFootHeaderData;
        private TableText[] TableCaptionHeaderData = new TableText[]
        {
            new TableText { Title = "S.No"},
            new TableText { Title = "Country"},
            new TableText { Title = "Medals Won"},
            new TableText { Title = "No Of Athletes"},
        }; 
        public TableText[] GetTableCaptionHeaderData() => TableCaptionHeaderData;
        private TableText[] TableCaptionTopHeaderData = new TableText[]
        {
            new TableText { Title = "S.No"},
            new TableText { Title = "Name"},
            new TableText { Title = "Revenue"},
            new TableText { Title = "Country"},
        }; 
        public TableText[] GetTableCaptionTopHeaderData() => TableCaptionTopHeaderData;
        private TableText[] TableActiveHeaderData = new TableText[]
        {
            new TableText { Title = "Name"},
            new TableText { Title = "Created On"},
            new TableText { Title = "Number"},
            new TableText { Title = "Status"},
        }; 
        public TableText[] GetTableActiveHeaderData() => TableActiveHeaderData;
        private TableText[] TableSmallHeaderData = new TableText[]
        {
            new TableText { Title = "Invoice"},
            new TableText { Title = "Created Date"},
            new TableText { Title = "Status"},
            new TableText { Title = "Action"},
        }; 
        public TableText[] GetTableSmallHeaderData() => TableSmallHeaderData;
        private TableText[] ColorVariationHeaderData = new TableText[]
        {
            new TableText { Title = "Color"},
            new TableText { Title = "Client"},
            new TableText { Title = "State"},
            new TableText { Title = "Quantity"},
            new TableText { Title = "Total Price"},
        }; 
        public TableText[] GetColorVariationHeaderData() => ColorVariationHeaderData;
        private TableText[] ResponsiveHeaderData = new TableText[]
        {
            new TableText { Title = "Team Head"},
            new TableText { Title = "Category"},
            new TableText { Title = "Role"},
            new TableText { Title = "Gmail"},
            new TableText { Title = "Team"},
            new TableText { Title = "Work Progress"},
            new TableText { Title = "Revenue"},
            new TableText { Title = "Action"},
        }; 
        public TableText[] GetResponsiveHeaderData() => ResponsiveHeaderData;
        private TableText[] VerticalHeaderData = new TableText[]
        {
            new TableText { Title = "Heading 1"},
            new TableText { Title = "Heading 2"},
            new TableText { Title = "Heading 3"},
            new TableText { Title = "Heading 4"},
        }; 
        public TableText[] GetVerticalHeaderData() => VerticalHeaderData;

        public static List<TableBodyData> GetTable1()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { name = "Mark", date = "21,Dec 2021",number="+1234-12340" ,status="Completed",statusbg="bg-outline-primary"},
                new TableBodyData { name = "Monika", date = "29,April 2024",number="+1523-12459" ,status="Failed",statusbg="bg-outline-warning"},
                new TableBodyData { name = "Madina", date = "30,Mar 2024",number="+1982-16234" ,status="Successful",statusbg="bg-outline-success"},
                new TableBodyData { name = "Bhamako", date = "18,Mar 2024",number="+1526-10729" ,status="Pending",statusbg="bg-outline-secondary"},
            };
        }
        public static List<TableBodyData> GetTable2()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { img="../assets/images/faces/13.jpg",name = "Sukuro Kim", email = "kimosukuro@gmail.com" ,status="Active",statusbg="bg-success-transparent"},
                new TableBodyData { img="../assets/images/faces/6.jpg",name = "Hasimna", email = "hasimna2132@gmail.com" ,status="Inactive",statusbg="bg-light text-dark"},
                new TableBodyData { img="../assets/images/faces/15.jpg",name = "Azimo Khan", email = "azimokhan421@gmail.com" ,status="Active",statusbg="bg-success-transparent"},
                new TableBodyData { img="../assets/images/faces/5.jpg",name = "Samantha Julia", email = "julianasams143@gmail.com" ,status="Active",statusbg="bg-success-transparent"},
            };
        }
        public static List<TableBodyData> GetTable3()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { id="#0007",img="../assets/images/faces/3.jpg",name = "Violeta Tilly", date = "26-04-2022"},
                new TableBodyData { id="#0008",img="../assets/images/faces/6.jpg",name = "Wicky Kross", date = "15-02-2022"},
                new TableBodyData { id="#0009",img="../assets/images/faces/1.jpg",name = "Julia Cam", date = "23-05-2022"},
            };
        }
        public static List<TableBodyData> GetTable4()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { id="#0011",img="../assets/images/faces/10.jpg",name = "Helsenky", date = "07-01-2022"},
                new TableBodyData { id="#0012",img="../assets/images/faces/14.jpg",name = "Brodus", date = "18-05-2022"},
                new TableBodyData { id="#0013",img="../assets/images/faces/12.jpg",name = "Chikka Alen", date = "19-03-2022"},
            };
        }
        public static List<TableBodyData> GetTable5()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { id="#0014",img="../assets/images/faces/13.jpg",name = "Sukuro Kim", date = "21-02-2022"},
                new TableBodyData { id="#0018",img="../assets/images/faces/11.jpg",name = "Phillip John", date = "26-03-2022"},
                new TableBodyData { id="#0020",img="../assets/images/faces/2.jpg",name = "Pamila Anderson", date = "14-03-2022"},
            };
        }
        public static List<TableBodyData> GetTable6()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { id="#5182-3467",name = "Harshrath", date = "24 May 2024",status="Fixed",statusbg="bg-primary"},
                new TableBodyData { id="#5182-3412",name = "Zozo Hadid", date = "02 July 2024",status="In Progress",statusbg="bg-warning"},
                new TableBodyData { id="#5182-3423",name = "Martiana", date = "15 April 2024",status="Completed",statusbg="bg-success"},
                new TableBodyData { id="#5182-3456",name = "Phillip John", date = "17 March 2024",status="Pending",statusbg="bg-danger"},
            };
        }
        public static List<TableBodyData> GetTable7()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { id="Smart Watch",name = "Slowtrack.inc", quantity = "250/1786",status="24.23%",statusbg="text-success"},
                new TableBodyData { id="White Sneakers",name = "American & Co.inc", quantity = "123/985",status="12.45%",statusbg="text-danger"},
                new TableBodyData { id="Baseball Bat",name = "Sports Company", quantity = "124/232",status="06.64%",statusbg="text-success"},
                new TableBodyData { id="Black Hoodie",name = "Renonds Fabrics", quantity = "192/2456",status="14.42%",statusbg="text-success"},
            };
        }
        public static List<TableBodyData> GetTable8()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { id="2022R-01",name = "Moracco", date = "27-010-2022"},
                new TableBodyData { id="2022R-02",name = "Thornton", date = "28-10-2022"},
                new TableBodyData { id="2022R-03",name = "Larry Bird", date = "22-10-2022"},
                new TableBodyData { id="2022R-04",name = "Erica Sean", date = "29-09-2022"},
            };
        }
        public static List<TableBodyData> GetTable9()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { id="1",name = "Mark", lastname = "Otto",email="@mdo"},
                new TableBodyData { id="2",name = "Jacob", lastname = "Thornton",email="@fat"},
                new TableBodyData { id="3",name = "Larry the Bird", lastname = "Thornton",email="@twitter"},
            };
        }
        public static List<TableBodyData> GetTable10()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { img="../assets/images/faces/10.jpg",name = "Joanna Smith",email="joannasmith14@gmail.com",status="Fashion",statusbg="bg-primary-transparent",percentage="52", 
                    Team = new List<TeamList>{
                        new TeamList{img="../assets/images/faces/2.jpg",},
                        new TeamList{img="../assets/images/faces/8.jpg",},
                        new TeamList{img="../assets/images/faces/2.jpg",},
                        new TeamList{img="../assets/images/faces/4.jpg",},
                    }
                },
                new TableBodyData { img="../assets/images/faces/2.jpg",name = "Kara Kova",email="milesakara@gmail.com",status="Clothing",statusbg="bg-warning-transparent",percentage="40", 
                    Team = new List<TeamList>{
                        new TeamList{img="../assets/images/faces/4.jpg",},
                        new TeamList{img="../assets/images/faces/6.jpg",},
                    }
                },
                new TableBodyData { img="../assets/images/faces/16.jpg",name = "Donald Trimb",email="donaldo21@gmail.com",status="Electronics",statusbg="bg-dark-transparent",percentage="17", 
                    Team = new List<TeamList>{
                        new TeamList{img="../assets/images/faces/1.jpg",},
                        new TeamList{img="../assets/images/faces/11.jpg",},
                        new TeamList{img="../assets/images/faces/15.jpg",},
                        new TeamList{img="../assets/images/faces/15.jpg",},
                        new TeamList{img="../assets/images/faces/15.jpg",},
                    }
                },
                new TableBodyData { img="../assets/images/faces/13.jpg",name = "Justin Gaethje",email="justingae@gmail.com",status="Sports",statusbg="bg-danger-transparent",percentage="72", 
                    Team = new List<TeamList>{
                        new TeamList{img="../assets/images/faces/4.jpg",},
                        new TeamList{img="../assets/images/faces/6.jpg",},
                    }
                },
            };
        }
        public static List<TableBodyData> GetTable11()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { id="IN-2032",img="../assets/images/faces/15.jpg",name = "Mark Cruise",email="markcruise24@gmail.com",statusbg="bg-success-transparent",status="<i class='ri-check-fill align-middle me-1'></i>Paid",date="Jul 26,2022"},
                new TableBodyData { id="IN-2022",img="../assets/images/faces/12.jpg",name = "Charanjeep",email="charanjeep@gmail.in",statusbg="bg-success-transparent",status="<i class='ri-check-fill align-middle me-1'></i>Paid",date="Mar 14,2022"},
                new TableBodyData { id="IN-2014",img="../assets/images/faces/5.jpg",name = "Samantha Julie",email="julie453@gmail.com",statusbg="bg-danger-transparent",status="<i class='ri-close-fill align-middle me-1'></i>Cancelled",date="Feb 1,2022"},
                new TableBodyData { id="IN-2036",img="../assets/images/faces/11.jpg",name = "Simon Cohen",email="simon@gmail.com",statusbg="bg-light text-dark",status="<i class='ri-reply-line align-middle me-1'></i>Refunded",date="Apr 24,2022"},
            };
        }
        public static List<TableBodyData> GetTable12()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { id="#5182-3467",name = "Harshrath",statusbg="btn-primary-light",status="Pending",date="24 May 2024"},
                new TableBodyData { id="#5182-3412",name = "Zozo Hadid",statusbg="btn-primary-light",status="Pending",date="02 July 2024"},
                new TableBodyData { id="#5182-3423",name = "Martiana",statusbg="btn-danger-light",status="Rejected",date="15 April 2024"},
                new TableBodyData { id="#5182-3456",name = "Phillip John",statusbg="btn-success-light",status="Processed",date="17 March 2024"},
            };
        }
        public static List<TableBodyData> GetTable13()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { id="01",name = "Manchester",quantity="232",statusbg="bg-primary",status="42%"},
                new TableBodyData { id="02",name = "Barcelona",quantity="175",statusbg="bg-primary",status="58%"},
                new TableBodyData { id="03",name = "Portugal",quantity="126",statusbg="bg-primary",status="32%"},
            };
        }
        public static List<TableBodyData> GetTable14()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { id="01",name = "United States",quantity="1823",date="2012"},
                new TableBodyData { id="02",name = "United Kingdom",quantity="992",date="1012"},
                new TableBodyData { id="03",name = "Germany",quantity="875",date="914"},
            };
        }
        public static List<TableBodyData> GetTable15()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { id="1",name = "Microsoft",quantity="$170 billion"},
                new TableBodyData { id="2",name = "HP",quantity="$72 billion"},
                new TableBodyData { id="3",name = "IBM",quantity="$84 billion"},
            };
        }        
        public static List<TableBodyData> GetTable16()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { name = "Mark",date="21,Dec 2021",number="+1234-12340",status="Completed",statusbg="bg-primary"},
                new TableBodyData { name = "Monika",date="29,April 2024",number="+1523-12459",status="Failed",statusbg="bg-warning"},
                new TableBodyData { name = "Madina",date="30,Mar 2024",number="+1982-16234",status="Successful",statusbg="bg-success"},
                new TableBodyData { name = "Bhamako",date="18,Mar 2024",number="+1526-10729",status="Pending",statusbg="bg-secondary"},
            };
        }
        public static List<TableBodyData> GetTable17()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { name = "Zelensky",date="25-Apr-2021",status="Paid",statusbg="bg-success-transparent"},
                new TableBodyData { name = "Kim Jong",date="29-April-2022",status="Pending",statusbg="bg-danger-transparent"},
                new TableBodyData { name = "Obana",date="30-Nov-2022",status="Paid",statusbg="bg-success-transparent"},
                new TableBodyData { name = "Sean Paul",date="01-Jan-2022",status="Paid",statusbg="bg-success-transparent"},
                new TableBodyData { name = "Karizma",date="14-Feb-2022",status="Pending",statusbg="bg-danger-transparent"},
            };
        }        
        public static List<TableBodyData> GetTable18()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { trbg="",id="Default",name = "Rita Book",quantity="22",price="$2,012",status="Processed",statusbg="bg-primary-transparent"},
                new TableBodyData { trbg="table-primary",id="Primary",name = "Rhoda Report",quantity="22",price="$4,254",status="Processed",statusbg="bg-primary"},
                new TableBodyData { trbg="table-secondary",id="Secondary",name = "Rita Book",quantity="26",price="$1,234",status="Processed",statusbg="bg-secondary"},
                new TableBodyData { trbg="table-success",id="Success",name = "Anne Teak",quantity="42",price="$2,623",status="Processed",statusbg="bg-success"},
                new TableBodyData { trbg="table-danger",id="Danger",name = "Dee End",quantity="52",price="$32,132",status="Processed",statusbg="bg-danger"},
                new TableBodyData { trbg="table-warning",id="Warning",name = "Lee Nonmi",quantity="10",price="$1,434",status="Processed",statusbg="bg-warning"},
                new TableBodyData { trbg="table-info",id="Info",name = "Lynne Gwistic",quantity="63",price="$1,854",status="Processed",statusbg="bg-info"},
                new TableBodyData { trbg="table-light",id="Light",name = "Fran Tick",quantity="05",price="$823",status="Processed",statusbg="bg-light text-dark"},
                new TableBodyData { trbg="table-dark",id="Dark",name = "Polly Pipe",quantity="35",price="$1,832",status="Processed",statusbg="bg-dark text-white"},
            };
        }
        public static List<TableBodyData> GetTable19()
        {
            return new List<TableBodyData>
            {
                new TableBodyData { img="../assets/images/faces/3.jpg",name = "Violeta Tilly",category="Manufacturer",email="mayorkrlly@gmail.com",status="Team Lead",statusbg="bg-primary-transparent",percentage="52", price="$10,984.29",
                    Team = new List<TeamList>{
                        new TeamList{img="../assets/images/faces/2.jpg",},
                        new TeamList{img="../assets/images/faces/8.jpg",},
                        new TeamList{img="../assets/images/faces/2.jpg",},
                        new TeamList{img="../assets/images/faces/8.jpg",},
                        new TeamList{img="../assets/images/faces/8.jpg",},
                        new TeamList{img="../assets/images/faces/8.jpg",},
                        new TeamList{img="../assets/images/faces/8.jpg",},
                    }
                },
                new TableBodyData { img="../assets/images/faces/12.jpg",name = "Danny Raj",category="Managing Director",email="mayorkrlly@gmail.com",status="Director",statusbg="bg-warning-transparent",percentage="91", price="$1.4billion",
                    Team = new List<TeamList>{
                        new TeamList{img="../assets/images/faces/1.jpg",},
                        new TeamList{img="../assets/images/faces/5.jpg",},
                        new TeamList{img="../assets/images/faces/11.jpg",},
                        new TeamList{img="../assets/images/faces/15.jpg",},
                    }
                },
                new TableBodyData { img="../assets/images/faces/14.jpg",name = "Red Stark",category="Service Manager",email="simoncowel234@gmail.com",status="Manager",statusbg="bg-success-transparent",percentage="45", price="$7,123.21",
                    Team = new List<TeamList>{
                        new TeamList{img="../assets/images/faces/6.jpg",},
                        new TeamList{img="../assets/images/faces/16.jpg",},
                    }
                },
                new TableBodyData { img="../assets/images/faces/5.jpg",name = "Sissera William",category="Recruiter",email="mirindahers@gmail.com",status="Employee",statusbg="bg-danger-transparent",percentage="21", price="$2,325.45",
                    Team = new List<TeamList>{
                        new TeamList{img="../assets/images/faces/3.jpg",},
                        new TeamList{img="../assets/images/faces/10.jpg",},
                        new TeamList{img="../assets/images/faces/14.jpg",},
                    }
                },
            };
        }
    }
}