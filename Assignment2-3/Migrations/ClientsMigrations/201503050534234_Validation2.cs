namespace Assignment2_3.Migrations.ClientsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validation2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BadDateReports", "Description", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.CityOfAssaults", "Description", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.CityOfResidences", "Description", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Crises", "Type", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.DrugAssaults", "Description", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.DuplicateFiles", "Value", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Ethnicities", "Type", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.EvidenceStoreds", "Description", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.FamilyViolenceFiles", "Value", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.FiscalYears", "Year", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.HivMeds", "Description", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.HospitalAttendeds", "Description", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Incidents", "Type", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.MedicalOnlies", "Description", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.MultiplePerpetrators", "Description", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.PoliceAttendances", "Description", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.PoliceReporteds", "Description", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Programs", "Type", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.ReferralContacts", "Contact", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.ReferralSources", "Source", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.ReferredCbvs", "Description", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.ReferringHospitals", "Description", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.RepeatClients", "Value", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.RiskLevels", "Level", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.RiskStatus", "Status", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Services", "Type", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.SexWorks", "Description", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.SocialWorkAttendances", "Description", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.StatusOfFiles", "Status", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.ThirdPartyReports", "Description", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.VictimServicesAttendances", "Description", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.VictimOfIncidents", "Description", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VictimOfIncidents", "Description", c => c.String());
            AlterColumn("dbo.VictimServicesAttendances", "Description", c => c.String());
            AlterColumn("dbo.ThirdPartyReports", "Description", c => c.String());
            AlterColumn("dbo.StatusOfFiles", "Status", c => c.String());
            AlterColumn("dbo.SocialWorkAttendances", "Description", c => c.String());
            AlterColumn("dbo.SexWorks", "Description", c => c.String());
            AlterColumn("dbo.Services", "Type", c => c.String());
            AlterColumn("dbo.RiskStatus", "Status", c => c.String());
            AlterColumn("dbo.RiskLevels", "Level", c => c.String());
            AlterColumn("dbo.RepeatClients", "Value", c => c.String());
            AlterColumn("dbo.ReferringHospitals", "Description", c => c.String());
            AlterColumn("dbo.ReferredCbvs", "Description", c => c.String());
            AlterColumn("dbo.ReferralSources", "Source", c => c.String());
            AlterColumn("dbo.ReferralContacts", "Contact", c => c.String());
            AlterColumn("dbo.Programs", "Type", c => c.String());
            AlterColumn("dbo.PoliceReporteds", "Description", c => c.String());
            AlterColumn("dbo.PoliceAttendances", "Description", c => c.String());
            AlterColumn("dbo.MultiplePerpetrators", "Description", c => c.String());
            AlterColumn("dbo.MedicalOnlies", "Description", c => c.String());
            AlterColumn("dbo.Incidents", "Type", c => c.String());
            AlterColumn("dbo.HospitalAttendeds", "Description", c => c.String());
            AlterColumn("dbo.HivMeds", "Description", c => c.String());
            AlterColumn("dbo.FiscalYears", "Year", c => c.String());
            AlterColumn("dbo.FamilyViolenceFiles", "Value", c => c.String());
            AlterColumn("dbo.EvidenceStoreds", "Description", c => c.String());
            AlterColumn("dbo.Ethnicities", "Type", c => c.String());
            AlterColumn("dbo.DuplicateFiles", "Value", c => c.String());
            AlterColumn("dbo.DrugAssaults", "Description", c => c.String());
            AlterColumn("dbo.Crises", "Type", c => c.String());
            AlterColumn("dbo.CityOfResidences", "Description", c => c.String());
            AlterColumn("dbo.CityOfAssaults", "Description", c => c.String());
            AlterColumn("dbo.BadDateReports", "Description", c => c.String());
        }
    }
}
