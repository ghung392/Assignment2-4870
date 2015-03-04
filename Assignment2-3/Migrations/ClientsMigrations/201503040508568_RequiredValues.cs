namespace Assignment2_3.Migrations.ClientsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredValues : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Surname", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Clients", "FirstName", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "FirstName", c => c.String(maxLength: 40));
            AlterColumn("dbo.Clients", "Surname", c => c.String(maxLength: 40));
        }
    }
}
