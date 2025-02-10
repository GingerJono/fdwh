using CardModel;
namespace TeamData
{
    public class Members
    {
        public decimal Id { get; set; }     
        public string? User { get; set; }      
        public string? UserImg { get; set; }    
        public string? Designation { get; set; }  
        public string? DesignationColor { get; set; }     
        public string? Bio { get; set; }    
    }    
    public class TeamService {
        private List<Members> TeamMembersData = new List<Members>()
        {    
            new Members { Id =1,User ="Hadley Kylin",UserImg ="../assets/images/faces/1.jpg",Designation ="Director",DesignationColor ="bg-primary text-fixed-white",Bio="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since"},
            new Members { Id =2,User ="Ethan Mitchell",UserImg ="../assets/images/faces/2.jpg",Designation ="Manager",DesignationColor ="bg-primary1 text-fixed-white",Bio="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since"},
            new Members { Id =3,User ="Iliana Lilly",UserImg ="../assets/images/faces/3.jpg",Designation ="Creative Director",DesignationColor ="bg-primary2 text-fixed-white",Bio="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since"},
            new Members { Id =4,User ="Jasmine Della",UserImg ="../assets/images/faces/4.jpg",Designation ="Board Director",DesignationColor ="bg-primary3 text-fixed-white",Bio="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since"},
            new Members { Id =5,User ="Aurora Reed",UserImg ="../assets/images/faces/5.jpg",Designation ="Board Director",DesignationColor ="bg-secondary text-fixed-white",Bio="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since"},
            new Members { Id =6,User ="Ava Taylor",UserImg ="../assets/images/faces/6.jpg",Designation ="Board Director",DesignationColor ="bg-success text-fixed-white",Bio="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since"},
            new Members { Id =7,User ="Spencer Robin",UserImg ="../assets/images/faces/7.jpg",Designation ="Board Director",DesignationColor ="bg-primary text-fixed-white",Bio="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since"},
            new Members { Id =8,User ="Owen Foster",UserImg ="../assets/images/faces/8.jpg",Designation ="Board Director",DesignationColor ="bg-primary1 text-fixed-white",Bio="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since"},
        };
        public List<Members> GetTeamMembersData() => TeamMembersData;
        
    }
}