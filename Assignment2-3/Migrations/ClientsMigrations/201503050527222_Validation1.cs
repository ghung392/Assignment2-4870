namespace Assignment2_3.Migrations.ClientsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validation1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AbuserRelationships", "AbuRelationship", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Ages", "Value", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.AssignedWorkers", "Worker", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AssignedWorkers", "Worker", c => c.String());
            AlterColumn("dbo.Ages", "Value", c => c.String());
            AlterColumn("dbo.AbuserRelationships", "AbuRelationship", c => c.String(maxLength: 40));
        }
    }
}
