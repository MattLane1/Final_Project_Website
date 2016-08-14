/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : Configurations.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is Configurations file used to Migrate changes made to the object, to the database automatically. This keeps the DB up to date.
  
------------------------------------------------------------------------------*/

namespace Assignment_2_Matthew_Lane.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment_2_Matthew_Lane.Models.FoodStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Assignment_2_Matthew_Lane.Models.FoodStoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
