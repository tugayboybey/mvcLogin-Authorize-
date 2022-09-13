namespace mvcLogin.Migrations
{
    using mvcLogin.Models.Data.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models.Data.ProjeContext;

    internal sealed class Configuration : DbMigrationsConfiguration<mvcLogin.Models.Data.ProjeContext.PorojectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(mvcLogin.Models.Data.ProjeContext.PorojectContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            ApplicationUser kullanici = new ApplicationUser();
            kullanici.Email = "ba@ba.com";
            kullanici.Name = "bilge adam";
            kullanici.Password = "123";
            context.Users.AddOrUpdate(kullanici);




        }
    }
}
