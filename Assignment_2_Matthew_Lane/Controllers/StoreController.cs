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
        public string Index()
        {
            return "Hello from Store.Index()";
        }
        //
        // GET: /Store/Browse?genre=Disco
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = "
        + genre);

            return message;
        }
        //
        // GET: /Store/Details/5
        public ActionResult Details(int id = 1)
        {
            var appetizer = new Appetizers { Title = "Appetizer " + id };
            return View(appetizer);
        }
    }
}