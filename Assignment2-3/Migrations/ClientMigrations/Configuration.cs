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
                a => new { a.Relationship },
                relationships.ToArray()
                );
        }
        private List<AbuserRelationship> GetAbuserRelationships()
        {
            List<AbuserRelationship> relationships = new List<AbuserRelationship> {
                new AbuserRelationship
                {
                    Relationship="Acquaintance"
                },
                new AbuserRelationship
                {
                    Relationship="Bad Date"
                },
                new AbuserRelationship
                {
                    Relationship="DNA"
                },
                new AbuserRelationship
                {
                    Relationship="Ex-Partner"
                },
                new AbuserRelationship
                {
                    Relationship="Friend"
                },
                new AbuserRelationship
                {
                    Relationship="Multiple Perps"
                },
                new AbuserRelationship
                {
                    Relationship="N/A"
                },
                new AbuserRelationship
                {
                    Relationship="Other"
                },
                new AbuserRelationship
                {
                    Relationship="Other Familial"
                },
                new AbuserRelationship
                {
                    Relationship="Parent"
                },
                new AbuserRelationship
                {
                    Relationship="Partner"
                },
                new AbuserRelationship
                {
                    Relationship="Sibling"
                },
                new AbuserRelationship
                {
                    Relationship="Stranger"
                }
            };
            return relationships;
        }
    }
}
