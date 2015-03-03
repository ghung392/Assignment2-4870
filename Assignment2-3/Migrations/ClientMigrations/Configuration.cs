namespace Assignment2_3.Migrations.ClientMigrations
{
    using Assignment2_3.Models.Lookup;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment2_3.Models.Entities.ClientContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ClientMigrations";
        }

        protected override void Seed(Assignment2_3.Models.Entities.ClientContext context)
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
            List<AbuserRelationship> relationships = GetAbuserRelationships();
            context.AbuserRelationships.AddOrUpdate(
                a => new { a.AbuRelationship },
                relationships.ToArray()
                );

            List<Age> ages = GetAges();
            context.Ages.AddOrUpdate(
                a => new { a.Value },
                ages.ToArray()
                );

            context.SaveChanges();
        }
        private List<AbuserRelationship> GetAbuserRelationships()
        {
            List<AbuserRelationship> relationships = new List<AbuserRelationship> {
                new AbuserRelationship
                {
                    AbuRelationship="Acquaintance"
                },
                new AbuserRelationship
                {
                    AbuRelationship="Bad Date"
                },
                new AbuserRelationship
                {
                    AbuRelationship="DNA"
                },
                new AbuserRelationship
                {
                    AbuRelationship="Ex-Partner"
                },
                new AbuserRelationship
                {
                    AbuRelationship="Friend"
                },
                new AbuserRelationship
                {
                    AbuRelationship="Multiple Perps"
                },
                new AbuserRelationship
                {
                    AbuRelationship="N/A"
                },
                new AbuserRelationship
                {
                    AbuRelationship="Other"
                },
                new AbuserRelationship
                {
                    AbuRelationship="Other Familial"
                },
                new AbuserRelationship
                {
                    AbuRelationship="Parent"
                },
                new AbuserRelationship
                {
                    AbuRelationship="Partner"
                },
                new AbuserRelationship
                {
                    AbuRelationship="Sibling"
                },
                new AbuserRelationship
                {
                    AbuRelationship="Stranger"
                }
            };
            return relationships;
        }

        private List<Age> GetAges()
        {
            List<Age> ages = new List<Age> {
                new Age
                {
                    Value="Adult > 24 < 65"
                },
                new Age
                {
                    Value="Youth > 12 < 19"
                },
                new Age
                {
                    Value="Youth > 18 < 25"
                },
                new Age
                {
                    Value="Child < 13"
                },
                new Age
                {
                    Value="Senior > 64"
                }
            };
            return ages;
        }
    }
}
