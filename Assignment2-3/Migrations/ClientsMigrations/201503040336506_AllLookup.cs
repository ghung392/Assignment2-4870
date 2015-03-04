namespace Assignment2_3.Migrations.ClientsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllLookup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbuserRelationships",
                c => new
                    {
                        AbuserRelationshipId = c.Int(nullable: false, identity: true),
                        AbuRelationship = c.String(),
                    })
                .PrimaryKey(t => t.AbuserRelationshipId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientReferenceNumber = c.Int(nullable: false, identity: true),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        Surname = c.String(),
                        FirstName = c.String(),
                        PoliceFileNumber = c.String(),
                        CourtFileNumber = c.Int(nullable: false),
                        SwcFileNumber = c.Int(nullable: false),
                        RiskAssessAssignment = c.String(),
                        AbuserName = c.String(),
                        NumOfChildrenZeroToSix = c.Int(nullable: false),
                        NumOfChildrenSevenToTwelve = c.Int(nullable: false),
                        NumOfChildrenThirteenToEighteen = c.Int(nullable: false),
                        DateLastTransferred = c.DateTime(nullable: false),
                        DateClosed = c.DateTime(nullable: false),
                        DateReopened = c.DateTime(nullable: false),
                        Age_AgeId = c.Int(),
                        AssignedWorker_AssignedWorkerId = c.Int(),
                        DuplicateFile_DuplicateFileId = c.Int(),
                        Ethnicity_EthnicityId = c.Int(),
                        FamilyViolenceFile_FamilyViolenceFileId = c.Int(),
                        FiscalYear_FiscalYearId = c.Int(),
                        Incident_IncidentId = c.Int(),
                        Program_ProgramId = c.Int(),
                        ReferralContact_ReferralContactId = c.Int(),
                        ReferralSource_ReferralSourceId = c.Int(),
                        RepeatClient_RepeatClientId = c.Int(),
                        RiskLevel_RiskLevelId = c.Int(),
                        RiskStatus_RiskStatusId = c.Int(),
                        Service_ServiceId = c.Int(),
                        StatusOfFile_StatusOfFileId = c.Int(),
                        VictimOfIncident_VictimOfIncidentId = c.Int(),
                        AbuserRelationship_AbuserRelationshipId = c.Int(),
                        Crisis_CrisisId = c.Int(),
                    })
                .PrimaryKey(t => t.ClientReferenceNumber)
                .ForeignKey("dbo.Ages", t => t.Age_AgeId)
                .ForeignKey("dbo.AssignedWorkers", t => t.AssignedWorker_AssignedWorkerId)
                .ForeignKey("dbo.DuplicateFiles", t => t.DuplicateFile_DuplicateFileId)
                .ForeignKey("dbo.Ethnicities", t => t.Ethnicity_EthnicityId)
                .ForeignKey("dbo.FamilyViolenceFiles", t => t.FamilyViolenceFile_FamilyViolenceFileId)
                .ForeignKey("dbo.FiscalYears", t => t.FiscalYear_FiscalYearId)
                .ForeignKey("dbo.Incidents", t => t.Incident_IncidentId)
                .ForeignKey("dbo.Programs", t => t.Program_ProgramId)
                .ForeignKey("dbo.ReferralContacts", t => t.ReferralContact_ReferralContactId)
                .ForeignKey("dbo.ReferralSources", t => t.ReferralSource_ReferralSourceId)
                .ForeignKey("dbo.RepeatClients", t => t.RepeatClient_RepeatClientId)
                .ForeignKey("dbo.RiskLevels", t => t.RiskLevel_RiskLevelId)
                .ForeignKey("dbo.RiskStatus", t => t.RiskStatus_RiskStatusId)
                .ForeignKey("dbo.Services", t => t.Service_ServiceId)
                .ForeignKey("dbo.StatusOfFiles", t => t.StatusOfFile_StatusOfFileId)
                .ForeignKey("dbo.VictimOfIncidents", t => t.VictimOfIncident_VictimOfIncidentId)
                .ForeignKey("dbo.AbuserRelationships", t => t.AbuserRelationship_AbuserRelationshipId)
                .ForeignKey("dbo.Crises", t => t.Crisis_CrisisId)
                .Index(t => t.Age_AgeId)
                .Index(t => t.AssignedWorker_AssignedWorkerId)
                .Index(t => t.DuplicateFile_DuplicateFileId)
                .Index(t => t.Ethnicity_EthnicityId)
                .Index(t => t.FamilyViolenceFile_FamilyViolenceFileId)
                .Index(t => t.FiscalYear_FiscalYearId)
                .Index(t => t.Incident_IncidentId)
                .Index(t => t.Program_ProgramId)
                .Index(t => t.ReferralContact_ReferralContactId)
                .Index(t => t.ReferralSource_ReferralSourceId)
                .Index(t => t.RepeatClient_RepeatClientId)
                .Index(t => t.RiskLevel_RiskLevelId)
                .Index(t => t.RiskStatus_RiskStatusId)
                .Index(t => t.Service_ServiceId)
                .Index(t => t.StatusOfFile_StatusOfFileId)
                .Index(t => t.VictimOfIncident_VictimOfIncidentId)
                .Index(t => t.AbuserRelationship_AbuserRelationshipId)
                .Index(t => t.Crisis_CrisisId);
            
            CreateTable(
                "dbo.Ages",
                c => new
                    {
                        AgeId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.AgeId);
            
            CreateTable(
                "dbo.VictimOfIncidents",
                c => new
                    {
                        VictimOfIncidentId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.VictimOfIncidentId);
            
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "Crisis_CrisisId", "dbo.Crises");
            DropForeignKey("dbo.Smarts", "VictimServicesAttendance_VictimServicesAttendanceId", "dbo.VictimServicesAttendances");
            DropForeignKey("dbo.Smarts", "ThirdPartyReport_ThirdPartyReportId", "dbo.ThirdPartyReports");
            DropForeignKey("dbo.Smarts", "SocialWorkAttendance_SocialWorkAttendanceId", "dbo.SocialWorkAttendances");
            DropForeignKey("dbo.Smarts", "SexWork_SexWorkId", "dbo.SexWorks");
            DropForeignKey("dbo.Smarts", "ReferringHospital_ReferringHospitalId", "dbo.ReferringHospitals");
            DropForeignKey("dbo.Smarts", "ReferredCbvs_ReferredCbvsId", "dbo.ReferredCbvs");
            DropForeignKey("dbo.Smarts", "PoliceReported_PoliceReportedId", "dbo.PoliceReporteds");
            DropForeignKey("dbo.Smarts", "PoliceAttendance_PoliceAttendanceId", "dbo.PoliceAttendances");
            DropForeignKey("dbo.Smarts", "MultiplePerpetrators_MultiplePerpetratorsId", "dbo.MultiplePerpetrators");
            DropForeignKey("dbo.Smarts", "MedicalOnly_MedicalOnlyId", "dbo.MedicalOnlies");
            DropForeignKey("dbo.Smarts", "HospitalAttended_HospitalAttendedId", "dbo.HospitalAttendeds");
            DropForeignKey("dbo.Smarts", "HivMeds_HivMedsId", "dbo.HivMeds");
            DropForeignKey("dbo.Smarts", "EvidenceStored_EvidenceStoredId", "dbo.EvidenceStoreds");
            DropForeignKey("dbo.Smarts", "DrugAssault_DrugAssaultId", "dbo.DrugAssaults");
            DropForeignKey("dbo.Smarts", "CityOfResidence_CityOfResidenceId", "dbo.CityOfResidences");
            DropForeignKey("dbo.Smarts", "CityOfAssault_CityOfAssaultId", "dbo.CityOfAssaults");
            DropForeignKey("dbo.Smarts", "BadDateReport_BadDateReportId", "dbo.BadDateReports");
            DropForeignKey("dbo.Clients", "AbuserRelationship_AbuserRelationshipId", "dbo.AbuserRelationships");
            DropForeignKey("dbo.Clients", "VictimOfIncident_VictimOfIncidentId", "dbo.VictimOfIncidents");
            DropForeignKey("dbo.Clients", "StatusOfFile_StatusOfFileId", "dbo.StatusOfFiles");
            DropForeignKey("dbo.Clients", "Service_ServiceId", "dbo.Services");
            DropForeignKey("dbo.Clients", "RiskStatus_RiskStatusId", "dbo.RiskStatus");
            DropForeignKey("dbo.Clients", "RiskLevel_RiskLevelId", "dbo.RiskLevels");
            DropForeignKey("dbo.Clients", "RepeatClient_RepeatClientId", "dbo.RepeatClients");
            DropForeignKey("dbo.Clients", "ReferralSource_ReferralSourceId", "dbo.ReferralSources");
            DropForeignKey("dbo.Clients", "ReferralContact_ReferralContactId", "dbo.ReferralContacts");
            DropForeignKey("dbo.Clients", "Program_ProgramId", "dbo.Programs");
            DropForeignKey("dbo.Clients", "Incident_IncidentId", "dbo.Incidents");
            DropForeignKey("dbo.Clients", "FiscalYear_FiscalYearId", "dbo.FiscalYears");
            DropForeignKey("dbo.Clients", "FamilyViolenceFile_FamilyViolenceFileId", "dbo.FamilyViolenceFiles");
            DropForeignKey("dbo.Clients", "Ethnicity_EthnicityId", "dbo.Ethnicities");
            DropForeignKey("dbo.Clients", "DuplicateFile_DuplicateFileId", "dbo.DuplicateFiles");
            DropForeignKey("dbo.Clients", "AssignedWorker_AssignedWorkerId", "dbo.AssignedWorkers");
            DropForeignKey("dbo.Clients", "Age_AgeId", "dbo.Ages");
            DropIndex("dbo.Smarts", new[] { "VictimServicesAttendance_VictimServicesAttendanceId" });
            DropIndex("dbo.Smarts", new[] { "ThirdPartyReport_ThirdPartyReportId" });
            DropIndex("dbo.Smarts", new[] { "SocialWorkAttendance_SocialWorkAttendanceId" });
            DropIndex("dbo.Smarts", new[] { "SexWork_SexWorkId" });
            DropIndex("dbo.Smarts", new[] { "ReferringHospital_ReferringHospitalId" });
            DropIndex("dbo.Smarts", new[] { "ReferredCbvs_ReferredCbvsId" });
            DropIndex("dbo.Smarts", new[] { "PoliceReported_PoliceReportedId" });
            DropIndex("dbo.Smarts", new[] { "PoliceAttendance_PoliceAttendanceId" });
            DropIndex("dbo.Smarts", new[] { "MultiplePerpetrators_MultiplePerpetratorsId" });
            DropIndex("dbo.Smarts", new[] { "MedicalOnly_MedicalOnlyId" });
            DropIndex("dbo.Smarts", new[] { "HospitalAttended_HospitalAttendedId" });
            DropIndex("dbo.Smarts", new[] { "HivMeds_HivMedsId" });
            DropIndex("dbo.Smarts", new[] { "EvidenceStored_EvidenceStoredId" });
            DropIndex("dbo.Smarts", new[] { "DrugAssault_DrugAssaultId" });
            DropIndex("dbo.Smarts", new[] { "CityOfResidence_CityOfResidenceId" });
            DropIndex("dbo.Smarts", new[] { "CityOfAssault_CityOfAssaultId" });
            DropIndex("dbo.Smarts", new[] { "BadDateReport_BadDateReportId" });
            DropIndex("dbo.Clients", new[] { "Crisis_CrisisId" });
            DropIndex("dbo.Clients", new[] { "AbuserRelationship_AbuserRelationshipId" });
            DropIndex("dbo.Clients", new[] { "VictimOfIncident_VictimOfIncidentId" });
            DropIndex("dbo.Clients", new[] { "StatusOfFile_StatusOfFileId" });
            DropIndex("dbo.Clients", new[] { "Service_ServiceId" });
            DropIndex("dbo.Clients", new[] { "RiskStatus_RiskStatusId" });
            DropIndex("dbo.Clients", new[] { "RiskLevel_RiskLevelId" });
            DropIndex("dbo.Clients", new[] { "RepeatClient_RepeatClientId" });
            DropIndex("dbo.Clients", new[] { "ReferralSource_ReferralSourceId" });
            DropIndex("dbo.Clients", new[] { "ReferralContact_ReferralContactId" });
            DropIndex("dbo.Clients", new[] { "Program_ProgramId" });
            DropIndex("dbo.Clients", new[] { "Incident_IncidentId" });
            DropIndex("dbo.Clients", new[] { "FiscalYear_FiscalYearId" });
            DropIndex("dbo.Clients", new[] { "FamilyViolenceFile_FamilyViolenceFileId" });
            DropIndex("dbo.Clients", new[] { "Ethnicity_EthnicityId" });
            DropIndex("dbo.Clients", new[] { "DuplicateFile_DuplicateFileId" });
            DropIndex("dbo.Clients", new[] { "AssignedWorker_AssignedWorkerId" });
            DropIndex("dbo.Clients", new[] { "Age_AgeId" });
            DropTable("dbo.Crises");
            DropTable("dbo.VictimServicesAttendances");
            DropTable("dbo.ThirdPartyReports");
            DropTable("dbo.SocialWorkAttendances");
            DropTable("dbo.SexWorks");
            DropTable("dbo.ReferringHospitals");
            DropTable("dbo.ReferredCbvs");
            DropTable("dbo.PoliceReporteds");
            DropTable("dbo.PoliceAttendances");
            DropTable("dbo.MultiplePerpetrators");
            DropTable("dbo.MedicalOnlies");
            DropTable("dbo.HospitalAttendeds");
            DropTable("dbo.HivMeds");
            DropTable("dbo.EvidenceStoreds");
            DropTable("dbo.DrugAssaults");
            DropTable("dbo.CityOfResidences");
            DropTable("dbo.CityOfAssaults");
            DropTable("dbo.Smarts");
            DropTable("dbo.BadDateReports");
            DropTable("dbo.VictimOfIncidents");
            DropTable("dbo.StatusOfFiles");
            DropTable("dbo.Services");
            DropTable("dbo.RiskStatus");
            DropTable("dbo.RiskLevels");
            DropTable("dbo.RepeatClients");
            DropTable("dbo.ReferralSources");
            DropTable("dbo.ReferralContacts");
            DropTable("dbo.Programs");
            DropTable("dbo.Incidents");
            DropTable("dbo.FiscalYears");
            DropTable("dbo.FamilyViolenceFiles");
            DropTable("dbo.Ethnicities");
            DropTable("dbo.DuplicateFiles");
            DropTable("dbo.AssignedWorkers");
            DropTable("dbo.Ages");
            DropTable("dbo.Clients");
            DropTable("dbo.AbuserRelationships");
        }
    }
}
