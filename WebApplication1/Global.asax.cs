using System;
using WebApplication1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            List<Class1> junkList = new List<Class1>();
            List<Class2> catList = new List<Class2>();

            Class2 one1 = new Class2
            {
                Name = "Computer"
            };

            Class2 one2 = new Class2
            {
                Name = "Laptop"
            };

            Class2 one3 = new Class2
            {
                Name = "Plane"
            };

            Class2 one4 = new Class2
            {
                Name = "Boat"
            };

            catList.Add(one1);
            catList.Add(one3);
            catList.Add(one2);
            catList.Add(one4);

            Class1 loot1 = new Class1
            {
                id = 1,
                Code = "666",
                Name = "Evil Laptop",
                Category = "Laptop",
                Description = "Use at your own risk"
            };

            Class1 loot2 = new Class1
            {
                id = 2,
                Code = "007",
                Name = "Laptop",
                Category = "Laptop",
                Description = "Laptop used by 007"
            };

            Class1 loot3 = new Class1
            {
                id = 3,
                Code = "123",
                Name = "Another Laptop",
                Category = "Laptop",
                Description = "This wasn't used by 007"
            };
            Class1 loot4 = new Class1
            {
                id = 4,
                Code = "999",
                Name = "Nice Laptop",
                Category = "Laptop",
                Description = "Eviler then the other one"
            };

            Class1 loot5 = new Class1
            {
                id = 5,
                Code = "M16",
                Name = "Laptop",
                Category = "Laptop",
                Description = "Laptop used by 007"
            };

            Class1 loot6 = new Class1
            {
                id = 6,
                Code = "F16",
                Name = "Fighter Jet",
                Category = "Plane",
                Description = "Need a pilots license to use"
            };


            junkList.Add(loot1);
            junkList.Add(loot2);
            junkList.Add(loot3);
            junkList.Add(loot4);
            junkList.Add(loot5);
            junkList.Add(loot6);

            Application["junklist"] = junkList;
            Application["catlist"] = catList;


            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
