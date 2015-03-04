namespace Assignment2_3.Migrations.ClientsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "DateLastTransferred", c => c.DateTime());
            AlterColumn("dbo.Clients", "DateClosed", c => c.DateTime());
            AlterColumn("dbo.Clients", "DateReopened", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "DateReopened", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Clients", "DateClosed", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Clients", "DateLastTransferred", c => c.DateTime(nullable: false));
        }
    }
}
