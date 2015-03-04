namespace Assignment2_3.Migrations.ClientsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Month", c => c.Int());
            AlterColumn("dbo.Clients", "Day", c => c.Int());
            AlterColumn("dbo.Clients", "CourtFileNumber", c => c.Int());
            AlterColumn("dbo.Clients", "SwcFileNumber", c => c.Int());
            AlterColumn("dbo.Clients", "NumOfChildrenZeroToSix", c => c.Int());
            AlterColumn("dbo.Clients", "NumOfChildrenSevenToTwelve", c => c.Int());
            AlterColumn("dbo.Clients", "NumOfChildrenThirteenToEighteen", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "NumOfChildrenThirteenToEighteen", c => c.Int(nullable: false));
            AlterColumn("dbo.Clients", "NumOfChildrenSevenToTwelve", c => c.Int(nullable: false));
            AlterColumn("dbo.Clients", "NumOfChildrenZeroToSix", c => c.Int(nullable: false));
            AlterColumn("dbo.Clients", "SwcFileNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Clients", "CourtFileNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Clients", "Day", c => c.Int(nullable: false));
            AlterColumn("dbo.Clients", "Month", c => c.Int(nullable: false));
        }
    }
}
