using WebApplication1.Models;
using System.Collections.Generic;
using System.Web.Mvc;
namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public ActionResult AddEquip(Class1 theOne)
        {
            List<Class1> junk = (List<Class1>)HttpContext.Application["junklist"];

            if (string.IsNullOrEmpty(theOne.Code))
            {
                ViewBag.code = "*Code must be filled out";
                ViewBag.list = junk;
                ViewBag.color = "Red";
                return View("Index");
            }

            if (string.IsNullOrEmpty(theOne.Name))
            {
                ViewBag.code = "*Name must be filled out";
                ViewBag.list = junk;
                ViewBag.color = "Red";
                return View("Index");
            }

            if (string.IsNullOrEmpty(theOne.Description))
            {
                ViewBag.code = "*Description must be filled out";
                ViewBag.list = junk;
                ViewBag.color = "Red";
                return View("Index");
            }

            if (string.IsNullOrEmpty(theOne.Category))
            {
                ViewBag.code = "*Category must be Selected";
                ViewBag.list = junk;
                ViewBag.color = "Red";
                return View("Index");
            }

            foreach (Class1 entry in junk)
            {
                if (entry.Code.Equals(theOne.Code))
                {
                    ViewBag.code = "*code already exist could not add it";
                    ViewBag.list = junk;
                    ViewBag.color = "Red";
                    return View("Index");
                }
            }

            theOne.id = junk.Count + 1;
            junk.Add(theOne);
            ViewBag.code = "*********NICE!!!!! entry has been added************";
            ViewBag.list = junk;
            ViewBag.color = "Green";
            return View("Index");

        }

        public ViewResult Index()
        {
            List<Class1> junk = (List<Class1>)HttpContext.Application["junklist"];

            ViewBag.list = junk;
            return View();
        }

        public ActionResult Index2(string category)
        {
            List<Class2> catList = (List<Class2>)HttpContext.Application["catList"];
            Class2 another = new Class2
            {
                Name = (string)category
            };

            catList.Add(another);
            ViewBag.list = catList;
            ViewBag.name = category;
            return View("AddEquipment");
        }

        public ViewResult AddCat()
        {
            return View();
        }

        public ViewResult ItemInfo(int id)
        {
            ViewBag.list = (List<Class1>)HttpContext.Application["junklist"];
            ViewBag.id = id;
            return View();
        }

        public ViewResult AddEquipment()
        {
            List<Class2> catList = (List<Class2>)HttpContext.Application["catList"];
            ViewBag.list = catList;
            return View();
        }

    }
}