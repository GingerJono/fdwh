
namespace ListGroupData
{
    public class ListGroupElements {
        public string? ListGroupClass { get; set; } 
        public string? ListGroupText { get; set; }
        public string? ImageUrl { get; set; }    
        public string? ListIcon { get; set; }   
        public string? BadgeClass { get; set; }   
        public string? BadgeText { get; set; }   
        public bool IsDisabled { get; set; }
        public bool IsActive { get; set; }
        public bool IsChecked { get; set; }
    };
    
    public class ListGroupService {
        public List<ListGroupElements> GetListGroup1()
        {
            return new List<ListGroupElements>
            {
                new ListGroupElements { ListGroupText = "Isha Bella", ImageUrl = "../assets/images/faces/1.jpg" },
                new ListGroupElements { ListGroupText = "Elsa Urena", ImageUrl = "../assets/images/faces/3.jpg" },
                new ListGroupElements { ListGroupText = "Flora Mary", ImageUrl = "../assets/images/faces/6.jpg" },
                new ListGroupElements { ListGroupText = "Gatin Leo", ImageUrl = "../assets/images/faces/15.jpg" },
                new ListGroupElements { ListGroupText = "Raja Ryder", ImageUrl = "../assets/images/faces/13.jpg" }
            };
        }
        public List<ListGroupElements> GetListGroup2()
        {
            return new List<ListGroupElements>
            {
                new ListGroupElements { ListGroupText = "A disabled item meant to be disabled",IsDisabled=true },
                new ListGroupElements { ListGroupText = "Simply dummy text of the printing", },
                new ListGroupElements { ListGroupText = "There are many variations of passages", },
                new ListGroupElements { ListGroupText = "All the Lorem Ipsum generators", },
                new ListGroupElements { ListGroupText = "Written in 45 BC. This book is a treatise on the theory",  }
            };
        }
        public List<ListGroupElements> GetListGroup3()
        {
            return new List<ListGroupElements>
            {
                new ListGroupElements { ListIcon="ri-home-2-line" , ListGroupText = "Asish Trivedhi<span class='ms-1 text-muted fw-normal d-inline-block'>(+1023-84534)</span>"},
                new ListGroupElements { ListIcon="ri-cloud-line" , ListGroupText = "Alezander Russo<span class='ms-1 text-muted fw-normal d-inline-block'>(+7546-12342)</span>"},
                new ListGroupElements { ListIcon="ri-global-line" , ListGroupText = "Karem Smith<span class='ms-1 text-muted fw-normal d-inline-block'>(+9944-56632)</span>"},
                new ListGroupElements { ListIcon="ri-stack-line" , ListGroupText = "Melissa Brien<span class='ms-1 text-muted fw-normal d-inline-block'>(+1023-34323)</span>"},
                new ListGroupElements { ListIcon="ri-gift-2-line" , ListGroupText = "Kamala Harris<span class='ms-1 text-muted fw-normal d-inline-block'>(+91-63421)</span>" }
            };
        }
        public List<ListGroupElements> GetListGroup4()
        {
            return new List<ListGroupElements>
            {
                new ListGroupElements { ListIcon="ri-home-2-line" , ListGroupText = "Home" ,IsActive=true},
                new ListGroupElements { ListIcon="ri-notification-3-line" , ListGroupText = "Notifications"},
                new ListGroupElements { ListIcon="ri-chat-1-line" , ListGroupText = "Sent Messages"},
                new ListGroupElements { ListIcon="ri-user-add-line" , ListGroupText = "New Requests"},
                new ListGroupElements { ListIcon="ri-delete-bin-line" , ListGroupText = "Deleted Messages" }
            };
        }
        public List<ListGroupElements> GetListGroup5()
        {
            return new List<ListGroupElements>
            {
                new ListGroupElements { ListGroupText = "Simply dummy text of the printing",IsActive=true, BadgeClass="bg-primary",BadgeText="243",},
                new ListGroupElements { ListGroupText = "There are many variations of passages", BadgeClass="bg-secondary-transparent",BadgeText="35",},
                new ListGroupElements { ListGroupText = "All the Lorem Ipsum generators", BadgeClass="bg-info-transparent",BadgeText="132",},
                new ListGroupElements { ListGroupText = "All the Lorem Ipsum generators", BadgeClass="bg-success-transparent",BadgeText="25",},
                new ListGroupElements { ListGroupText = "A disabled item meant to be disabled" ,IsDisabled=true, BadgeClass="bg-danger-transparent",BadgeText="21",}
            };
        }
        
        public List<ListGroupElements> GetListGroup6()
        {
            return new List<ListGroupElements>
            {
                new ListGroupElements { ListGroupText = "California",IsActive=true, BadgeClass="bg-white  text-default",BadgeText="C",},
                new ListGroupElements { ListGroupText = "New Jersey", BadgeClass="bg-secondary",BadgeText="N",},
                new ListGroupElements { ListGroupText = "Los Angeles", BadgeClass="bg-info",BadgeText="L",},
                new ListGroupElements { ListGroupText = "Miami Florida", BadgeClass="bg-warning",BadgeText="M",},
                new ListGroupElements { ListGroupText = "Washington D.c" ,IsDisabled=true, BadgeClass="bg-success",BadgeText="W",}
            };
        }
        public List<ListGroupElements> GetListGroup7()
        {
            return new List<ListGroupElements>
            {
                new ListGroupElements { ListGroupText = "<div class='fw-medium fs-14 text-default'>What Happened?</div> Many experts have recently suggested may exist. ", BadgeClass="bg-primary-transparent",BadgeText="32",}, 
                new ListGroupElements { ListGroupText = "<div class='fw-medium fs-14 text-default'>It Was Amazing!</div>  His idea involved taking red. ", BadgeClass="bg-secondary-transparent",BadgeText="52",},
                new ListGroupElements { ListGroupText = "<div class='fw-medium fs-14 text-default'>News Is A Great Weapon.</div> News can influence in many ways. ", BadgeClass="bg-success-transparent",BadgeText="1,204",},
                new ListGroupElements { ListGroupText = "<div class='fw-medium fs-14 text-default'>majority have suffered.</div> If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything.", BadgeClass="bg-danger-transparent",BadgeText="14",},
            };
        }
        public List<ListGroupElements> GetListGroup8()
        {
            return new List<ListGroupElements>
            {
                new ListGroupElements { ListGroupText = "Simply dummy text of the printing."}, 
                new ListGroupElements { ListGroupText = "There are many variations of passages."},
                new ListGroupElements { ListGroupText = "All the Lorem Ipsum generators."},
                new ListGroupElements { ListGroupText = "Written in 45 BC. This book is a treatise on the theory."},
                new ListGroupElements { ListGroupText = "Randomised words which don't look."},
                new ListGroupElements { ListGroupText = "Always free from repetition, injected humour."},
            };
        }
        public List<ListGroupElements> GetListGroup9()
        {
            return new List<ListGroupElements>
            {
                new ListGroupElements { ListGroupText = "Accurate information at any given point.." ,IsChecked=true}, 
                new ListGroupElements { ListGroupText = "Hearing the information and responding."},
                new ListGroupElements { ListGroupText = "Setting up and customizing your own sales.",IsChecked=true},
                new ListGroupElements { ListGroupText = "New Admin Launched.",IsChecked=true},
                new ListGroupElements { ListGroupText = "To maximize profits and improve productivity."},
                new ListGroupElements { ListGroupText = "To have a complete 360° overview of sales information, having."},
            };
        }
        public List<ListGroupElements> GetListGroup10()
        {
            return new List<ListGroupElements>
            {
                new ListGroupElements { ListGroupText = "Groceries", BadgeClass="bg-primary",BadgeText="Available",}, 
                new ListGroupElements { ListGroupText = "Furniture", BadgeClass="bg-secondary",BadgeText="Buy",}, 
                new ListGroupElements { ListGroupText = "Beauty", BadgeClass="bg-primary1 rounded-pill",BadgeText="32",}, 
                new ListGroupElements { ListGroupText = "Books", BadgeClass="bg-light text-default",BadgeText="New",}, 
                new ListGroupElements { ListGroupText = "Toys", BadgeClass="bg-info-gradient",BadgeText="Out of Stock",}, 
                new ListGroupElements { ListGroupText = "Electronic Gadgets", BadgeClass="bg-danger-transparent",BadgeText="&#128293; Hot",}, 
                new ListGroupElements { ListGroupText = "Mobiles", BadgeClass="bg-primary2",BadgeText="Sold Out",}, 
            };
        }
        public List<ListGroupElements> GetListGroup11()
        {
            return new List<ListGroupElements>
            {
                new ListGroupElements { ListGroupClass = "" , ListGroupText = "A simple default list group item"}, 
                new ListGroupElements { ListGroupClass = "list-item-primary" , ListGroupText = "A simple primary list group group item"}, 
                new ListGroupElements { ListGroupClass = "list-item-primary1" , ListGroupText = "A simple primary1 list group list group item"}, 
                new ListGroupElements { ListGroupClass = "list-item-primary2" , ListGroupText = "A simple primary2 list group group item"}, 
                new ListGroupElements { ListGroupClass = "list-item-primary3" , ListGroupText = "A simple primary3 list group group item"}, 
                new ListGroupElements { ListGroupClass = "list-item-secondary" , ListGroupText = "A simple secondary list group group item"}, 
                new ListGroupElements { ListGroupClass = "list-item-info" , ListGroupText = "A simple info list group group item"}, 
                new ListGroupElements { ListGroupClass = "list-item-success" , ListGroupText = "A simple success list group group item"}, 
                new ListGroupElements { ListGroupClass = "list-item-danger" , ListGroupText = "A simple danger list group group item"}, 
                new ListGroupElements { ListGroupClass = "list-item-warning" , ListGroupText = "A simple warning list group item"}, 
                new ListGroupElements { ListGroupClass = "list-item-light" , ListGroupText = "A simple light list group item"}, 
                new ListGroupElements { ListGroupClass = "list-item-dark" , ListGroupText = "A simple dark list group item"}, 
            };
        }

    }
}