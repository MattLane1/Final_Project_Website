namespace Assignment_2_Matthew_Lane.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FoodStoreEntities : DbContext
    {
        public FoodStoreEntities()
            : base("name=FoodStoreEntities")
        {
        }

        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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
