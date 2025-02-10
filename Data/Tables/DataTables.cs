using CardModel;

namespace DataTablesData
{
    public class DataTableData {
        public string? id { get; set; }
        public string? name { get; set; }
        public string? lastname { get; set; }
        public string? email { get; set; }
        public string? position { get; set; }
        public string? office { get; set; }
        public string? age { get; set; }
        public string? startdate { get; set; }
        public string? salary { get; set; }
    } ;    
     public class DataTablesService {
        private TableText[] BasicHeaderData = new TableText[]
        {
            new TableText { Title = "Name"},
            new TableText { Title = "Position"},
            new TableText { Title = "Office"},
            new TableText { Title = "Age"},
            new TableText { Title = "Start date"},
            new TableText { Title = "Salary"},
        }; 
        public TableText[] GetBasicHeaderData() => BasicHeaderData;
        private TableText[] Header2Data = new TableText[]
        {
            new TableText { Title = "Name"},
            new TableText { Title = "Position"},
            new TableText { Title = "Office"},
            new TableText { Title = "Age"},
            new TableText { Title = "Start date"},
            new TableText { Title = "Salary"},
        }; 
        public TableText[] GetHeader2Data() => Header2Data;
        private TableText[] Header3Data = new TableText[]
        {
            new TableText { Title = "Column 1"},
            new TableText { Title = "Column 2"},
            new TableText { Title = "Column 3"},
            new TableText { Title = "Column 4"},
            new TableText { Title = "Column 5"},
        }; 
        public TableText[] GetHeader3Data() => Header3Data;
       
        public static List<DataTableData> GetDataTable1()
        {
            return new List<DataTableData>
            {
                new DataTableData {name="Tiger Nixon",position="System Architect",office="Edinburgh",age="61",startdate="2011-04-25",salary="$320,800"},
                new DataTableData {name="Garrett Winters",position="Accountant",office="Tokyo",age="63",startdate="2011-07-25",salary="$170,750"},
                new DataTableData {name="Ashton Cox",position="Junior Technical Author",office="San Francisco",age="66",startdate="2009-01-12",salary="$86,000"},
                new DataTableData {name="Cedric Kelly",position="Senior Javascript Developer",office="Edinburgh",age="22",startdate="2012-03-29",salary="$433,060"},
                new DataTableData {name="Airi Satou",position="Accountant",office="Tokyo",age="33",startdate="2008-11-28",salary="$162,700"},
                new DataTableData {name="Brielle Williamson",position="Integration Specialist",office="New York",age="61",startdate="2012-12-02",salary="$372,000"},
                new DataTableData {name="Herrod Chandler",position="Sales Assistant",office="San Francisco",age="59",startdate="2012-08-06",salary="$137,500"},
                new DataTableData {name="Rhona Davidson",position="Integration Specialist",office="Tokyo",age="55",startdate="2010-10-14",salary="$327,900"},
                new DataTableData {name="Colleen Hurst",position="Javascript Developer",office="San Francisco",age="39",startdate="2009-09-15",salary="$205,500"},
                new DataTableData {name="Sonya Frost",position="Software Engineer",office="Edinburgh",age="23",startdate="2008-12-13",salary="$103,600"},
                new DataTableData {name="Jena Gaines",position="Office Manager",office="London",age="30",startdate="2008-12-19",salary="$90,560"},
                new DataTableData {name="Quinn Flynn",position="Support Lead",office="Edinburgh",age="22",startdate="2013-03-03",salary="$342,000"},
                new DataTableData {name="Charde Marshall",position="Regional Director",office="San Francisco",age="36",startdate="2008-10-16",salary="$470,600"},
                new DataTableData {name="Haley Kennedy",position="Senior Marketing Designer",office="London",age="43",startdate="2012-12-18",salary="$313,500"},
                new DataTableData {name="Tatyana Fitzpatrick",position="Regional Director",office="London",age="19",startdate="2010-03-17",salary="$385,750"},
                new DataTableData {name="Michael Silva",position="Marketing Designer",office="London",age="66",startdate="2012-11-27",salary="$198,500"},
                new DataTableData {name="Paul Byrd",position="Chief Financial Officer (CFO)",office="New York",age="64",startdate="2010-06-09",salary="$725,000"},
                new DataTableData {name="Gloria Little",position="Systems Administrator",office="New York",age="59",startdate="2009-04-10",salary="$237,500"},
                new DataTableData {name="Bradley Greer",position="Software Engineer",office="London",age="41",startdate="2012-10-13",salary="$132,000"},
                new DataTableData {name="Dai Rios",position="Personnel Lead",office="Edinburgh",age="35",startdate="2012-09-26",salary="$217,500"},
                new DataTableData {name="Jenette Caldwell",position="Development Lead",office="New York",age="30",startdate="2011-09-03",salary="$345,000"},
                new DataTableData {name="Yuri Berry",position="Chief Marketing Officer (CMO)",office="New York",age="40",startdate="2009-06-25",salary="$675,000"},
                new DataTableData {name="Caesar Vance",position="Pre-Sales Support",office="New York",age="21",startdate="2011-12-12",salary="$106,450"},
                new DataTableData {name="Doris Wilder",position="Sales Assistant",office="Sydney",age="23",startdate="2010-09-20",salary="$85,600"},
                new DataTableData {name="Angelica Ramos",position="Chief Executive Officer (CEO)",office="London",age="47",startdate="2009-10-09",salary="$1,200,000"},
                new DataTableData {name="Gavin Joyce",position="Developer",office="Edinburgh",age="42",startdate="2010-12-22",salary="$92,575"},
                new DataTableData {name="Jennifer Chang",position="Regional Director",office="Singapore",age="28",startdate="2010-11-14",salary="$357,650"},
                new DataTableData {name="Brenden Wagner",position="Software Engineer",office="San Francisco",age="28",startdate="2011-06-07",salary="$206,850"},
                new DataTableData {name="Fiona Green",position="Chief Operating Officer(COO)",office="San Francisco",age="48",startdate="2010-03-11",salary="$850,000"},
                new DataTableData {name="Shou Itou",position="Regional Marketing",office="Tokyo",age="20",startdate="2011-08-14",salary="$163,000"},
                new DataTableData {name="Michelle House",position="Integration Specialist",office="Sydney",age="37",startdate="2011-06-02",salary="$95,400"},
                new DataTableData {name="Suki Burks",position="Developer",office="London",age="53",startdate="2009-10-22",salary="$114,500"},
                new DataTableData {name="Prescott Bartlett",position="Technical Author",office="London",age="27",startdate="2011-05-07",salary="$145,000"},
                new DataTableData {name="Gavin Cortez",position="Team Leader",office="San Francisco",age="22",startdate="2008-10-26",salary="$235,500"},
                new DataTableData {name="Martena Mccray",position="Post-Sales support",office="Edinburgh",age="46",startdate="2011-03-09",salary="$324,050"},
                new DataTableData {name="Unity Butler",position="Marketing Designer",office="San Francisco",age="47",startdate="2009-12-09",salary="$85,675"},
                new DataTableData {name="Howard Hatfield",position="Office Manager",office="San Francisco",age="51",startdate="2008-12-16",salary="$164,500"},
                new DataTableData {name="Hope Fuentes",position="Secretary",office="San Francisco",age="41",startdate="2010-02-12",salary="$109,850"},
                new DataTableData {name="Vivian Harrell",position="Financial Controller",office="San Francisco",age="62",startdate="2009-02-14",salary="$452,500"},
                new DataTableData {name="Timothy Mooney",position="Office Manager",office="London",age="37",startdate="2008-12-11",salary="$136,200"},
                new DataTableData {name="Jackson Bradshaw",position="Director",office="New York",age="65",startdate="2008-09-26",salary="$645,750"},
                new DataTableData {name="Olivia Liang",position="Support Engineer",office="Singapore",age="64",startdate="2011-02-03",salary="$234,500"},
                new DataTableData {name="Bruno Nash",position="Software Engineer",office="London",age="38",startdate="2011-05-03",salary="$163,500"},
                new DataTableData {name="Sakura Yamamoto",position="Support Engineer",office="Tokyo",age="37",startdate="2009-08-19",salary="$139,575"},
                new DataTableData {name="Thor Walton",position="Developer",office="New York",age="61",startdate="2013-08-11",salary="$98,540"},
                new DataTableData {name="Finn Camacho",position="Support Engineer",office="San Francisco",age="47",startdate="2009-07-07",salary="$87,500"},
                new DataTableData {name="Serge Baldwin",position="Data Coordinator",office="Singapore",age="64",startdate="2012-04-09",salary="$138,575"},
                new DataTableData {name="Zenaida Frank",position="Software Engineer",office="New York",age="63",startdate="2010-01-04",salary="$125,250"},
                new DataTableData {name="Zorita Serrano",position="Software Engineer",office="San Francisco",age="56",startdate="2012-06-01",salary="$115,000"},
                new DataTableData {name="Jennifer Acosta",position="Junior Javascript Developer",office="Edinburgh",age="43",startdate="2013-02-01",salary="$75,650"},
                new DataTableData {name="Cara Stevens",position="Sales Assistant",office="New York",age="46",startdate="2011-12-06",salary="$145,600"},
                new DataTableData {name="Hermione Butler",position="Regional Director",office="London",age="47",startdate="2011-03-21",salary="$356,250"},
                new DataTableData {name="Lael Greer",position="Systems Administrator",office="London",age="21",startdate="2009-02-27",salary="$103,500"},
                new DataTableData {name="Jonas Alexander",position="Developer",office="San Francisco",age="30",startdate="2010-07-14",salary="$86,500"},
                new DataTableData {name="Shad Decker",position="Regional Director",office="Edinburgh",age="51",startdate="2008-11-13",salary="$183,000"},
                new DataTableData {name="Michael Bruce",position="Javascript Developer",office="Singapore",age="29",startdate="2011-06-27",salary="$183,000"},
                new DataTableData {name="Donna Snider",position="Customer Support",office="New York",age="27",startdate="2011-01-25",salary="$112,000"},
            };
        }
         public static List<DataTableData> GetDataTable2()
        {
            return new List<DataTableData>
            {
                new DataTableData {name="Bella",lastname="Chloe",position="System Developer",startdate="2018/03/12",salary="$654,765",email="b.Chloe@datatables.net"},
                new DataTableData {name="Donna",lastname="Bond",position="Account Manager",startdate="2012/02/21",salary="$543,654",email="d.bond@datatables.net"},
                new DataTableData {name="Harry",lastname="Carr",position="Technical Manager",startdate="20011/02/87",salary="$86,000",email="h.carr@datatables.net"},
                new DataTableData {name="Lucas",lastname="Dyer",position="Javascript Developer",startdate="2014/08/23",salary="$456,123",email="l.dyer@datatables.net"},
                new DataTableData {name="Karen",lastname="Hill",position="Sales Manager",startdate="2010/7/14",salary="$432,230",email="k.hill@datatables.net"},
                new DataTableData {name="Dominic",lastname="Hudson",position="Sales Assistant",startdate="2015/10/16",salary="$654,300",email="d.hudson@datatables.net"},
                new DataTableData {name="Herrod",lastname="Chandler",position="Integration Specialist",startdate="2012/08/06",salary="$137,500",email="h.chandler@datatables.net"},
                new DataTableData {name="Jonathan",lastname="Ince",position="junior Manager",startdate="2012/11/23",salary="$345,789",email="j.ince@datatables.net"},
                new DataTableData {name="Leonard",lastname="Ellison",position="Junior Javascript Developer",startdate="2010/03/19",salary="$205,500",email="l.ellison@datatables.net"},
                new DataTableData {name="Madeleine",lastname="Lee",position="Software Developer",startdate="20015/8/23",salary="$456,890",email="m.lee@datatables.net"},
                new DataTableData {name="Karen",lastname="Miller",position="Office Director",startdate="2012/9/25",salary="$87,654",email="k.miller@datatables.net"},
                new DataTableData {name="Lisa",lastname="Smith",position="Support Lead",startdate="2011/05/21",salary="$342,000",email="l.simth@datatables.net"},
                new DataTableData {name="Morgan",lastname="Keith",position="Accountant",startdate="2012/11/27",salary="$675,245",email="m.keith@datatables.net"},
                new DataTableData {name="Nathan",lastname="Mills",position="Senior Marketing Designer",startdate="2014/10/8",salary="$765,980",email="n.mills@datatables.net"},
                new DataTableData {name="Ruth",lastname="May",position="office Manager",startdate="2010/03/17",salary="$654,765",email="r.may@datatables.net"},
                new DataTableData {name="Penelope",lastname="Ogden",position="Marketing Manager",startdate="2013/5/22",salary="$345,510",email="p.ogden@datatables.net"},
                new DataTableData {name="Sean",lastname="Piper",position="Financial Officer",startdate="2014/06/11",salary="$725,000",email="s.piper@datatables.net"},
                new DataTableData {name="Trevor",lastname="Ross",position="Systems Administrator",startdate="2011/05/23",salary="$237,500",email="t.ross@datatables.net"},
                new DataTableData {name="Vanessa",lastname="Robertson",position="Software Designer",startdate="2014/6/23",salary="$765,654",email="v.robertson@datatables.net"},
                new DataTableData {name="Una",lastname="Richard",position="Personnel Manager",startdate="2014/5/22",salary="$765,290",email="u.richard@datatables.net"},
                new DataTableData {name="Justin",lastname="Peters",position="Development lead",startdate="2013/10/23",salary="$765,654",email="j.peters@datatables.net"},
                new DataTableData {name="Adrian",lastname="Terry",position="Marketing Officer",startdate="2013/04/21",salary="$543,769",email="a.terry@datatables.net"},
                new DataTableData {name="Cameron",lastname="Watson",position="Sales Support",startdate="2013/9/7",salary="$675,876",email="c.watson@datatables.net"},
                new DataTableData {name="Evan",lastname="Terry",position="Sales Manager",startdate="2013/10/26",salary="$66,340",email="d.terry@datatables.net"},
                new DataTableData {name="Angelica",lastname="Ramos",position="Chief Executive Officer",startdate="20017/10/15",salary="$6,234,000",email="a.ramos@datatables.net"},
                new DataTableData {name="Connor",lastname="Johne",position="Web Developer",startdate="2011/1/25",salary="$92,575",email="C.johne@datatables.net"},
                new DataTableData {name="Jennifer",lastname="Chang",position="Regional Director",startdate="2012/17/11",salary="$546,890",email="j.chang@datatables.net"},
                new DataTableData {name="Brenden",lastname="Wagner",position="Software Engineer",startdate="2013/07/14",salary="$206,850",email="b.wagner@datatables.net"},
                new DataTableData {name="Fiona",lastname="Green",position="Chief Operating Officer",startdate="2015/06/23",salary="$345,789",email="f.green@datatables.net"},
                new DataTableData {name="Shou",lastname="Itou",position="Regional Marketing",startdate="2013/07/19",salary="$335,300",email="s.itou@datatables.net"},
                new DataTableData {name="Michelle",lastname="House",position="Integration Specialist",startdate="2016/07/18",salary="$76,890",email="m.house@datatables.net"},
                new DataTableData {name="Suki",lastname="Burks",position="Developer",startdate="2010/11/45",salary="$678,890",email="s.burks@datatables.net"},
                new DataTableData {name="Prescott",lastname="Bartlett",position="Technical Author",startdate="2014/12/25",salary="$789,100",email="p.bartlett@datatables.net"},
                new DataTableData {name="Gavin",lastname="Cortez",position="Team Leader",startdate="2015/1/19",salary="$345,890",email="g.cortez@datatables.net"},
                new DataTableData {name="Martena",lastname="Mccray",position="Post-Sales support",startdate="2011/03/09",salary="$324,050",email="m.mccray@datatables.net"},
                new DataTableData {name="Unity",lastname="Butler",position="Marketing Designer",startdate="2014/7/28",salary="$34,983",email="u.butler@datatables.net"},
                new DataTableData {name="Howard",lastname="Hatfield",position="Office Manager",startdate="2013/8/19",salary="$98,000",email="h.hatfield@datatables.net"},
                new DataTableData {name="Hope",lastname="Fuentes",position="Secretary",startdate="2015/07/28",salary="$78,879",email="h.fuentes@datatables.net"},
                new DataTableData {name="Vivian",lastname="Harrell",position="Financial Controller",startdate="2010/02/14",salary="$452,500",email="v.harrell@datatables.net"},
                new DataTableData {name="Timothy",lastname="Mooney",position="Office Manager",startdate="20016/12/11",salary="$136,200",email="t.mooney@datatables.net"},
                new DataTableData {name="Jackson",lastname="Bradshaw",position="Director",startdate="2011/09/26",salary="$645,750",email="j.bradshaw@datatables.net"},
                new DataTableData {name="Olivia",lastname="Liang",position="Support Engineer",startdate="2014/02/03",salary="$234,500",email="o.liang@datatables.net"},
                new DataTableData {name="Bruno",lastname="Nash",position="Software Engineer",startdate="2015/05/03",salary="$163,500",email="b.nash@datatables.net"},
                new DataTableData {name="Sakura",lastname="Yamamoto",position="Support Engineer",startdate="2010/08/19",salary="$139,575",email="s.yamamoto@datatables.net"},
                new DataTableData {name="Thor",lastname="Walton",position="Developer",startdate="2012/08/11",salary="$98,540",email="t.walton@datatables.net"},
                new DataTableData {name="Finn",lastname="Camacho",position="Support Engineer",startdate="2016/07/07",salary="$87,500",email="f.camacho@datatables.net"},
                new DataTableData {name="Serge",lastname="Baldwin",position="Data Coordinator",startdate="2017/04/09",salary="$138,575",email="s.baldwin@datatables.net"},
                new DataTableData {name="Zenaida",lastname="Frank",position="Software Engineer",startdate="2018/01/04",salary="$125,250",email="z.frank@datatables.net"},
                new DataTableData {name="Zorita",lastname="Serrano",position="Software Engineer",startdate="2017/06/01",salary="$115,000",email="z.serrano@datatables.net"},
                new DataTableData {name="Jennifer",lastname="Acosta",position="Junior Javascript Developer",startdate="2017/02/01",salary="$75,650",email="j.acosta@datatables.net"},
            };
        }
    }
}