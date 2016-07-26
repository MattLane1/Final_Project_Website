using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_2_Matthew_Lane.Models;

namespace Assignment_2_Matthew_Lane.Controllers
{
    public class StoreController : Controller
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
        //
        // GET: /Store/Details/5
        public ActionResult Details(int id = 1)
        {
            Appetizers appetizer = new Appetizers { Title = "Appetizer " + id };
            return View(appetizer);
        }
    }
}