namespace Assignment2_3.Migrations.ClientsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeToObject : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Surname", c => c.String(maxLength: 40));
            AlterColumn("dbo.Clients", "FirstName", c => c.String(maxLength: 40));
            AlterColumn("dbo.Clients", "RiskAssessAssignment", c => c.String(maxLength: 40));
            AlterColumn("dbo.Clients", "AbuserName", c => c.String(maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "AbuserName", c => c.String());
            AlterColumn("dbo.Clients", "RiskAssessAssignment", c => c.String());
            AlterColumn("dbo.Clients", "FirstName", c => c.String());
            AlterColumn("dbo.Clients", "Surname", c => c.String());
        }
    }
}
