using Sandbox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardModel;

namespace POSSystem
{
    public class POSSystemService{
        public List<Poscard> PoscardData = new List<Poscard>{
            new Poscard{imgSrc="../assets/images/pos-system/9.jpg",title="Classic Cheeseburger",item="Classic Burgers",price="$78.99",Category="burger",InStock =true},
            new Poscard{imgSrc="../assets/images/pos-system/18.jpg",title="Coconut Almond Fudge",item="Specialty Flavors",price="$29.99",Category="icecream",InStock =false},
            new Poscard{imgSrc="../assets/images/pos-system/17.jpg",title="Cappuccino",item="Espresso Beverages",price="$7.99",Category="coffee",InStock =true},
            new Poscard{imgSrc="../assets/images/pos-system/11.jpg",title="Frosting Choices",item="Cupcake Creations",price="$19.99",Category="cupcakes",InStock =true},
            new Poscard{imgSrc="../assets/images/pos-system/12.jpg",title="Nutella Cupcake",item="Specialty Cupcakes",price="$123.99",Category="cupcakes",InStock =true},
            new Poscard{imgSrc="../assets/images/pos-system/16.jpg",title="Mediterranean",item="Specialty Pizzas",price="$2.79",Category="pizza",InStock =true},
            new Poscard{imgSrc="../assets/images/pos-system/14.jpg",title="Cold Brew Concentrate",item="Cold Brews",price="$1.29",Category="coffee",InStock =true},
            new Poscard{imgSrc="../assets/images/pos-system/15.jpg",title="Blue Cheese Burger",item="Gourmet Burgers",price="$24.99",Category="burger",InStock =true},
            new Poscard{imgSrc="../assets/images/pos-system/19.jpg",title="Apple Cinnamon Waffle",item="Specialty Waffles",price="$24.99",Category="waffle",InStock =true},
            new Poscard{imgSrc="../assets/images/pos-system/10.jpg",title="Pesto Delight",item="Specialty Pizzas",price="$24.99",Category="pizza",InStock =true},
            new Poscard{imgSrc="../assets/images/pos-system/8.jpg",title="Cookie Dough Sundae",item="Sundae Creations",price="$24.99",Category="icecream",InStock =true},
            new Poscard{imgSrc="../assets/images/pos-system/13.jpg",title="Americano",item="Espresso Beverages",price="$24.99",Category="coffee",InStock =true},
        };        
        public List<Poscard> GetPoscardData() => PoscardData;
        public List<Orderlist> OrderlistData = new List<Orderlist>{
            new Orderlist{id= 1,imgSrc="../assets/images/pos-system/17.jpg",title="Cappuccino",quantity="1",price="$3.99",discount="30% Off"},
            new Orderlist{id = 2,imgSrc ="../assets/images/pos-system/19.jpg",title = "Apple Cinnamon Waffle",quantity = "1",price = "$1.99",discount = "30% Off",},
            new Orderlist{id = 3,imgSrc = "../assets/images/pos-system/15.jpg",title = "Classic Cheeseburger",quantity = "2",price = "$2.79",discount = "10% Off",},
            new Orderlist{id = 4,imgSrc = "../assets/images/pos-system/12.jpg",title = "Nutella Cupcakes",quantity = "1",price = "$123.99",discount = "10% Off",},
            new Orderlist{id = 5,imgSrc = "../assets/images/pos-system/11.jpg",title = "Strawberry Cupcakes",quantity = "1",price = "$123.99",discount = "10% Off",},
            new Orderlist{id = 6,imgSrc = "../assets/images/pos-system/14.jpg",title = "Cold Coffee",quantity = "1",price = "$546.99",discount = "10% Off",},
            new Orderlist{id = 7,imgSrc = "../assets/images/pos-system/16.jpg",title = "Cheese Burst Pizza",quantity = "2", price = "$4.99",discount = "10% Off",},
            new Orderlist{id = 8,imgSrc = "../assets/images/pos-system/13.jpg",title = "Americano",quantity = "1",price = "$1.29",discount = "10% Off",},
        };        
        public List<Orderlist> GetOrderlistData() => OrderlistData;
        
        public List<Poscard> CategoriesData = new List<Poscard>{
            new Poscard{imgSrc="../assets/images/pos-system/1.png",title="All Menu",item="43 Items",Category="*"},
            new Poscard{imgSrc="../assets/images/pos-system/2.png",title="Pizza",item="80 Items",Category=".pizza"},
            new Poscard{imgSrc="../assets/images/pos-system/3.png",title="Burger",item="36 Items",Category=".burger"},
            new Poscard{imgSrc="../assets/images/pos-system/4.png",title="Waffle",item="25 Items",Category=".waffle"},
            new Poscard{imgSrc="../assets/images/pos-system/5.png",title="Ice Cream",item="58 Items",Category=".icecream"},
            new Poscard{imgSrc="../assets/images/pos-system/6.png",title="Coffee",item="38 Items",Category=".coffee"},
            new Poscard{imgSrc="../assets/images/pos-system/7.png",title="CupCakes",item="38 Items",Category=".cupcakes"},
        };        
        public List<Poscard> GetCategoriesData() => CategoriesData;
        
        public List<Productlist> ProductlistData = new List<Productlist>{
            new Productlist{id= 1,imgSrc="../assets/images/pos-system/17.jpg",title="Cappuccino",category="Espresso Beverages",price="$517",orders="2.7K Orders"},
            new Productlist{id = 2,imgSrc = "../assets/images/pos-system/15.jpg",title = "Cheese Burger",category = "Gourmet Burgers",price = "$564",orders = "1,758 Orders",discount = "15% Off",discountcolor ="info"},
            new Productlist{id = 3,imgSrc = "../assets/images/pos-system/19.jpg",title = "Cinnamon Waffle",category = "Specialty Waffles",price = "$24.89",orders = "894 Orders",},
            new Productlist{id = 4,imgSrc = "../assets/images/pos-system/16.jpg",title = "Mediterranean",category = "Special Pizza",price = "$2.7",orders = "865 Orders",discount = "10% Off",discountcolor ="primary1"},
            new Productlist{id = 5,imgSrc = "../assets/images/pos-system/9.jpg",title = "Classic Burger",category = "Gourmet Burgers",price = "$564",orders = "1,758 Orders",discount = "10% Off",discountcolor ="primary3"},
            new Productlist{id = 6,imgSrc = "../assets/images/pos-system/18.jpg",title = "Almond Fudge",category = "Icecream",price = "$89",orders = "789 Orders",discount = "30% Off",discountcolor ="success"}
        };        
        public List<Productlist> GetProductlistData() => ProductlistData;
        public List<Orderlist> CartlistData = new List<Orderlist>{
            new Orderlist{id= 1,imgSrc="../assets/images/pos-system/17.jpg",title="Cappuccino",Quantity=1,subtitle="Coffee",price="$3.99",discount="30% Off"},
            new Orderlist{id= 1,imgSrc="../assets/images/pos-system/11.jpg",title="Frosting",Quantity=1,subtitle="Cupcakes",price="$3.99",discount="30% Off"},
            new Orderlist{id= 1,imgSrc="../assets/images/pos-system/9.jpg",title="Cheeseburger",Quantity=1,subtitle="Burger",price="$3.99",discount="30% Off"},
            new Orderlist{id= 1,imgSrc="../assets/images/pos-system/16.jpg",title="Cheese Pizza",Quantity=1,subtitle="Pizza",price="$3.99",discount="30% Off"},
            new Orderlist{id= 1,imgSrc="../assets/images/pos-system/10.jpg",title="Normal Pizza",Quantity=1,subtitle="Pizza",price="$3.99",discount="30% Off"},
        };        
        public List<Orderlist> GetCartlistData() => CartlistData;
    }
}
