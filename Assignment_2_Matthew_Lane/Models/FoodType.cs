/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : FoodType.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is FoodType class, which holds information about the type of food
  
------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_2_Matthew_Lane.Models;

namespace Assignment_2_Matthew_Lane.Models
{
    public class FoodType
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public FoodType()
        {

        }

        /// <summary>
        /// This constuctor passes in the name of the food type (Appetizer, main or dessert)
        /// </summary>
        /// <param name="Name"></param>
        public FoodType(string Name)
        {
            this.Name = Name;
        }

        //FoodTypeID is the key used for the database
        //foodGenre holds the information of what group the food belongs to (App, Main, Dessert)
        //Name holds the foods name
        public int foodTypeID { get; set; }
        public string Name { get; set; }
        public FoodType foodGenre { get; set; }
    }
}