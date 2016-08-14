/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : food.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is food class. Objects of this class are generated later, and it holds the information about the selected food
  
------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Assignment_2_Matthew_Lane.Models
{
    //Object of food type. Used to allow specification of what the food is, and passed as a peram in several places
    public class Food
    {
        public Food()
        {

        }

        public Food(string FoodName)
        {
            this.FoodName = FoodName;
        }

        /*Information about the food item*/
        public virtual int FoodID { get; set; }
        public virtual string FoodName { get; set; }
        public virtual int FoodTypeID { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string FoodPictureUrl { get; set; }
        public virtual string Description { get; set; }
    }

}
