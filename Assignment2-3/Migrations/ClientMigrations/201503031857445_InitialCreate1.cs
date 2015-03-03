namespace Assignment2_3.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AbuserRelationships", "AbuRelationship", c => c.String());
            DropColumn("dbo.AbuserRelationships", "Relationship");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AbuserRelationships", "Relationship", c => c.String());
            DropColumn("dbo.AbuserRelationships", "AbuRelationship");
        }
    }
}
