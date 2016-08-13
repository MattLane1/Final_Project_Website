namespace Assignment_2_Matthew_Lane.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FoodStoreContext : DbContext
    {
        public FoodStoreContext()
            : base("name=FoodStoreConnection")
        {
        }

        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
