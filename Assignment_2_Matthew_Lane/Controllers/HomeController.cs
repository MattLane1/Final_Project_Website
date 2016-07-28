/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : HomeController.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is HomeController class, which is the go to for anything that occurs on the Home page
  
------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_2_Matthew_Lane.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
    }
}