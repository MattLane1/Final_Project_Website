/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : FoodStoreContext.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is FoodStoreContext page. This holds connecting information for the DB
  
------------------------------------------------------------------------------*/

namespace Assignment_2_Matthew_Lane.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FoodStoreContext : DbContext
    {
        /*The connection to the DB*/
        public FoodStoreContext()
            : base("name=FoodStoreConnection")
        {
        }

        /*This is the information to be passed onto the DB*/
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
