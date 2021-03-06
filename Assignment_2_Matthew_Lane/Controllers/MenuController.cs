﻿/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : MenuController.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is MenuController class, which is the go to for anything that occurs on the Menu page
  
------------------------------------------------------------------------------*/

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

        FoodStoreContext storeDB = new FoodStoreContext();

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

        public ActionResult Browse(string FoodType)
        {
            FoodType foodTypeModel = new FoodType { Name = FoodType };
            return View(foodTypeModel);
        }

        public ActionResult Details(string FoodType)
        {
            FoodType foodTypeModel = new FoodType { foodTypeID = 1, Name = FoodType, Description = null, FoodID = 1, Price = 5.00M, FoodPictureUrl = null  };
            //       Food food = storeDB.Food.Find(1);//id

         //   FoodType foodTypeModel = new FoodType { Name = FoodType };


            return View(foodTypeModel);
        }
    }
}