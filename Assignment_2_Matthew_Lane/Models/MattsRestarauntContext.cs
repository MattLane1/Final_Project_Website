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