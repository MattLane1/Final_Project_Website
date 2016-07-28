/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : MattsRestarauntContext.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is MattsRestarauntContext class, which which is a connection to the database information
  
------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment_2_Matthew_Lane.Models
{
    public class MattsRestarauntContext : DbContext
    {
        public virtual DbSet<FoodType> FoodTypes { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
    }
}