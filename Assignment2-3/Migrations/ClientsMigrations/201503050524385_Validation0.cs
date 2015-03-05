namespace Assignment2_3.Migrations.ClientsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validation0 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AbuserRelationships", "AbuRelationship", c => c.String(maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AbuserRelationships", "AbuRelationship", c => c.String());
        }
    }
}
