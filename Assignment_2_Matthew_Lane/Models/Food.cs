/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : food.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is food class. Objects of this class are generated later, and it holds the information about the selected food
  
------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2_Matthew_Lane.Models
{
    public class Food
    {
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public int Price { get; set; }
    }
}