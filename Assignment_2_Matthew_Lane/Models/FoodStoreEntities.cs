namespace Assignment_2_Matthew_Lane.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FoodStoreEntities : DbContext
    {
        public FoodStoreEntities()
            : base("name=FoodStoreConnection")
        {
        }
        //Menu table
        public virtual DbSet<Table> MenuItems { get; set; }

        //test split tables
        public virtual DbSet<Table> Appetizers { get; set; }
        public virtual DbSet<Table> Mains { get; set; }
        public virtual DbSet<Table> Desserts { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .Property(e => e.Id);

            modelBuilder.Entity<Table>()
                .Property(e => e.FoodType);

            modelBuilder.Entity<Table>()
                .Property(e => e.FoodName)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.FoodPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Table>()
                .Property(e => e.FoodDescription)
                .IsUnicode(false);
        }
    }
}
