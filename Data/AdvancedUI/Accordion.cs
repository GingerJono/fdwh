
namespace AccordionData
{
    public class AccordionModel
    {
        public decimal id { get; set; }
        public string? title { get; set; } 
        public string? desc { get; set; } 
        public string? accordionclass { get; set; } 
    }
    public class AccordionService {
        private List<AccordionModel> AccordionData = new List<AccordionModel>()
        {
            new AccordionModel{ id= 1,title= " Accordion Item #1", desc= "<strong>This is the first item's accordion body.</strong> It is shown by default, until the collapse plugin adds the appropriate classes that we use to  style each element. These classes control the overall appearance, as well as  the  showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just aboutany HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.",accordionclass="custom-accordion-primary"},
            new AccordionModel{ id= 2,title= "Accordion Item #2", desc= " <strong>This is the second item's accordion body.</strong> It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as  well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.",accordionclass="custom-accordion-secondary"},
            new AccordionModel{ id= 3,title= "Accordion Item #3", desc= "<strong>This is the third item's accordion body.</strong> It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It's also worth noting that just about any HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.",accordionclass="custom-accordion-danger"},

        };
        public List<AccordionModel> GetAccordionData() => AccordionData;
    }
}