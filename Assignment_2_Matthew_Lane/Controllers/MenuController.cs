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

namespace Assignment_2_Matthew_Lane.Controllers
{
    public class MenuController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
    }
}