
namespace AvatarData
{
    public class AvatarModel
    {
        public decimal AvatarId { get; set; }
        public string? AvatarClass { get; set; } 
        public string? AvatarImage { get; set; } 
        public string? AvatarSize { get; set; } 
        public string? AvatarIcon { get; set; } 
        public string? AvatarIconColor { get; set; } 
        public string? Value { get; set; } 
        public bool IsOnline { get; set; }
        public bool IsRounded { get; set; }
    }
    public class AvatarService {
        private List<AvatarModel> AvatarData = new List<AvatarModel>()
        {
            new AvatarModel { AvatarId= 1, AvatarClass= "avatar-radius-0", AvatarImage= "../assets/images/faces/1.jpg" },
            new AvatarModel { AvatarId= 1, IsRounded= false, AvatarImage= "../assets/images/faces/2.jpg" },
            new AvatarModel { AvatarId= 1, IsRounded= true, AvatarImage= "../assets/images/faces/3.jpg" },
        };
        public List<AvatarModel> GetAvatarData() => AvatarData;
        private List<AvatarModel> AvatarData2 = new List<AvatarModel>()
        {
            new AvatarModel { AvatarId= 1, IsRounded=true,AvatarSize= "xs", AvatarImage= "../assets/images/faces/2.jpg", AvatarIcon= "fe fe-camera", AvatarIconColor= "success" ,Value="2"},
            new AvatarModel { AvatarId= 2, IsRounded=true,AvatarSize= "sm", AvatarImage= "../assets/images/faces/3.jpg", AvatarIcon= "fe fe-edit", AvatarIconColor= "secondary" ,Value="5"},
            new AvatarModel { AvatarId= 3, IsRounded=true,AvatarSize= "md", AvatarImage= "../assets/images/faces/14.jpg", AvatarIcon= "fe fe-plus", AvatarIconColor= "warning" ,Value="1"},
            new AvatarModel { AvatarId= 4, IsRounded=true,AvatarSize= "lg", AvatarImage= "../assets/images/faces/13.jpg", AvatarIcon= "fe fe-edit", AvatarIconColor= "info" ,Value="7"},
            new AvatarModel { AvatarId= 5, IsRounded=true,AvatarSize= "xl", AvatarImage= "../assets/images/faces/15.jpg", AvatarIcon= "fe fe-camera", AvatarIconColor= "success" ,Value="3"},
            new AvatarModel { AvatarId= 6, IsRounded=true,AvatarSize= "xxl", AvatarImage= "../assets/images/faces/9.jpg", AvatarIcon= "fe fe-plus", AvatarIconColor= "danger" ,Value="9"},
        };
        public List<AvatarModel> GetAvatarData2() => AvatarData2;
        private List<AvatarModel> AvatarData3 = new List<AvatarModel>()
        {
            new AvatarModel { AvatarId= 1,AvatarSize= "xs", AvatarClass="primary",AvatarImage= "../assets/images/faces/4.jpg" },
            new AvatarModel { AvatarId= 2,AvatarSize= "sm", AvatarClass="secondary",AvatarImage= "../assets/images/faces/5.jpg" },
            new AvatarModel { AvatarId= 3,AvatarSize= "md", AvatarClass="warning",AvatarImage= "../assets/images/faces/6.jpg" },
            new AvatarModel { AvatarId= 4,AvatarSize= "lg", AvatarClass="danger",AvatarImage= "../assets/images/faces/7.jpg" },
            new AvatarModel { AvatarId= 5,AvatarSize= "xl", AvatarClass="success",AvatarImage= "../assets/images/faces/8.jpg" },
            new AvatarModel { AvatarId= 6,AvatarSize= "xxl", AvatarClass="info",AvatarImage= "../assets/images/faces/9.jpg" },
        };
        public List<AvatarModel> GetAvatarData3() => AvatarData3;
        private List<AvatarModel> AvatarData4 = new List<AvatarModel>()
        {
            new AvatarModel { AvatarId= 1,AvatarSize= "xs", IsRounded=true,IsOnline=true,AvatarImage= "../assets/images/faces/8.jpg" },
            new AvatarModel { AvatarId= 2,AvatarSize= "sm", IsRounded=true,IsOnline=true,AvatarImage= "../assets/images/faces/10.jpg" },
            new AvatarModel { AvatarId= 3,AvatarSize= "md", IsRounded=true,IsOnline=true,AvatarImage= "../assets/images/faces/12.jpg" },
            new AvatarModel { AvatarId= 4,AvatarSize= "lg", IsRounded=true,IsOnline=true,AvatarImage= "../assets/images/faces/13.jpg" },
            new AvatarModel { AvatarId= 5,AvatarSize= "xl", IsRounded=true,IsOnline=true,AvatarImage= "../assets/images/faces/14.jpg" },
            new AvatarModel { AvatarId= 6,AvatarSize= "xxl", IsRounded=true,IsOnline=true,AvatarImage= "../assets/images/faces/15.jpg" },
        };
        public List<AvatarModel> GetAvatarData4() => AvatarData4;
        private List<AvatarModel> AvatarData5 = new List<AvatarModel>()
        {
            new AvatarModel { AvatarId= 1,AvatarSize= "xs", IsRounded=true,IsOnline=false,AvatarImage= "../assets/images/faces/2.jpg" },
            new AvatarModel { AvatarId= 2,AvatarSize= "sm", IsRounded=true,IsOnline=false,AvatarImage= "../assets/images/faces/3.jpg" },
            new AvatarModel { AvatarId= 3,AvatarSize= "md", IsRounded=true,IsOnline=false,AvatarImage= "../assets/images/faces/4.jpg" },
            new AvatarModel { AvatarId= 4,AvatarSize= "lg", IsRounded=true,IsOnline=false,AvatarImage= "../assets/images/faces/5.jpg" },
            new AvatarModel { AvatarId= 5,AvatarSize= "xl", IsRounded=true,IsOnline=false,AvatarImage= "../assets/images/faces/6.jpg" },
            new AvatarModel { AvatarId= 6,AvatarSize= "xxl", IsRounded=true,IsOnline=false,AvatarImage= "../assets/images/faces/7.jpg" },
        };
        public List<AvatarModel> GetAvatarData5() => AvatarData5;
        private List<AvatarModel> AvatarData6 = new List<AvatarModel>()
        {
            new AvatarModel { AvatarId= 1,IsRounded=true,AvatarImage= "../assets/images/faces/2.jpg" },
            new AvatarModel { AvatarId= 2,IsRounded=true,AvatarImage= "../assets/images/faces/8.jpg" },
            new AvatarModel { AvatarId= 3,IsRounded=true,AvatarImage= "../assets/images/faces/2.jpg" },
            new AvatarModel { AvatarId= 4,IsRounded=true,AvatarImage= "../assets/images/faces/10.jpg" },
            new AvatarModel { AvatarId= 5,IsRounded=true,AvatarImage= "../assets/images/faces/4.jpg" },
            new AvatarModel { AvatarId= 6,IsRounded=true,AvatarImage= "../assets/images/faces/13.jpg" },
            new AvatarModel { AvatarId= 7,IsRounded=true,AvatarImage= "../assets/images/faces/2.jpg" },
            new AvatarModel { AvatarId= 8,IsRounded=true,AvatarImage= "../assets/images/faces/8.jpg" },
            new AvatarModel { AvatarId= 9,IsRounded=true,AvatarImage= "../assets/images/faces/2.jpg" },
            new AvatarModel { AvatarId= 10,IsRounded=true,AvatarImage= "../assets/images/faces/10.jpg" },
            new AvatarModel { AvatarId= 11,IsRounded=true,AvatarImage= "../assets/images/faces/4.jpg" },
            new AvatarModel { AvatarId= 12,IsRounded=true,AvatarImage= "../assets/images/faces/13.jpg" },
            new AvatarModel { AvatarId= 13,IsRounded=true,AvatarImage= "../assets/images/faces/13.jpg" },
            new AvatarModel { AvatarId= 14,IsRounded=true,AvatarImage= "../assets/images/faces/13.jpg" },
        };
        public List<AvatarModel> GetAvatarData6() => AvatarData6;
    }
}