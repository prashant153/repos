namespace eManager.Web.Migrations
{
    using eManager.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<eManager.Web.Infrasturcture.DepartmentDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(eManager.Web.Infrasturcture.DepartmentDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Departments.AddOrUpdate(
                    new Department() { Name="Engineering" },
                    new Department() { Name="Sales" },
                    new Department() { Name="Shipping" },
                    new Department() { Name="Humar Resources" }
                );
        }
    }
}
