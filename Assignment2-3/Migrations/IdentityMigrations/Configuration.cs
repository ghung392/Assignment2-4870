namespace Assignment2_3.Migrations.IdentityMigrations
{
    using Assignment2_3.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment2_3.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\IdentityMigrations";
            ContextKey = "Assignment2_3.Models.ApplicationDbContext";
        }

        protected override void Seed(Assignment2_3.Models.ApplicationDbContext context)
        {
            if (!context.Roles.Any(r => r.Name == "Administrator"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Administrator" };

                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "Worker"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Worker" };

                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "Reporter"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Reporter" };

                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "Active User"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Active User" };

                manager.Create(role);
            }


            if (!context.Users.Any(u => u.UserName == "adam@gs.ca"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "adam@gs.ca" };

                manager.Create(user, "P@$$w0rd");
                manager.AddToRole(user.Id, "Administrator");
            }

            if (!context.Users.Any(u => u.UserName == "wendy@gs.ca"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "wendy@gs.ca" };

                manager.Create(user, "P@$$w0rd");
                manager.AddToRole(user.Id, "Worker");
                manager.AddToRole(user.Id, "Active User");
            }

            if (!context.Users.Any(u => u.UserName == "rob@gs.ca"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "rob@gs.ca" };

                manager.Create(user, "P@$$w0rd");
                manager.AddToRole(user.Id, "Reporter");
                manager.AddToRole(user.Id, "Active User");
            }
        }
    }
}
