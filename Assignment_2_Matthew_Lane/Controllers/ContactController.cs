/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : ContactController.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is ContactController class, which is the go to for anything that occurs on the Contact page
  
------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_2_Matthew_Lane.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
    }
}