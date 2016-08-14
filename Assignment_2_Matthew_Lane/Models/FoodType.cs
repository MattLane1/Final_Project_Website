/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : FoodType.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is FoodType class, which holds information about the type of food 
  
------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        //FoodTypeID is the key used for the database, Name holds the foods name, FoodTypeID specifies if it is a main, dessert or appetizer, 
        //Description is the description of the food, Price is its cost, Food Picture Url is where the picture resides. 
        public virtual int foodTypeID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int FoodID { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string FoodPictureUrl { get; set; }
    }
}