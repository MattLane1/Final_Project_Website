using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Assignment_2_Matthew_Lane.Models;
using System.Collections.Generic;

namespace Assignment_2_Matthew_Lane.Controllers
{
    public class MenuController : Controller
    {
        //
        // GET: Store
        public ActionResult Index()
        {
            List<FoodType> foodtypes = new List<FoodType>
            {
                new FoodType("Appetizers"),
                new FoodType("Mains"),
                new FoodType("Desserts")
            };

            return View(foodtypes);
        }
        //
        // GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string FoodType)
        {
            FoodType foodTypeModel = new FoodType { Name = FoodType };
            return View(foodTypeModel);
        }


        public ActionResult Appetizers(string FoodType)
        {
            FoodType foodTypeModel = new FoodType { Name = FoodType };

            return View(foodTypeModel);
        }

        public ActionResult Mains(string FoodType)
        {
            FoodType foodTypeModel = new FoodType { Name = FoodType };

            return View(foodTypeModel);
        }

        public ActionResult Desserts(string FoodType)
        {
            FoodType foodTypeModel = new FoodType { Name = FoodType };

            return View(foodTypeModel);
        }


        /* 
           //
           // GET: /Store/Details/5
           public ActionResult Details(int id = 1)
           {
               Appetizers appetizer = new Appetizers { Title = "Appetizer " + id };
               return View(appetizer);
           }
        */
    }
}