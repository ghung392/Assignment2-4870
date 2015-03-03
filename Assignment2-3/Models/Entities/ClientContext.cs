using Assignment2_3.Models.Lookup;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_3.Models.Entities
{
    class ClientContext : DbContext
    {
        public ClientContext() : base("DefaultConnection") { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Smart> Smarts { get; set; }
        public DbSet<AbuserRelationship> AbuserRelationships { get; set; }
        public DbSet<Age> Ages { get; set; }
        public DbSet<AssignedWorker> AssignedWorkers { get; set; }
        public DbSet<BadDateReport> BadDateReports { get; set; }
        public DbSet<CityOfAssault> CityOfAssaults { get; set; }
        public DbSet<CityOfResidence> CityOfResidences { get; set; }
        public DbSet<Crisis> Crisises { get; set; }
        public DbSet<DrugAssault> DrugAssaults { get; set; }
        public DbSet<DuplicateFile> DuplicateFiles { get; set; }
        public DbSet<Ethnicity> Ethnicities { get; set; }
        public DbSet<EvidenceStored> EvidencesStored { get; set; }
        public DbSet<FamilyViolenceFile> FamilyViolencesFiles { get; set; }
        public DbSet<FiscalYear> FiscalYears { get; set; }
        public DbSet<HivMeds> HivMeds { get; set; }
        public DbSet<HospitalAttended> HospitalsAttended { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<MedicalOnly> MedicalsOnly { get; set; }
        public DbSet<MultiplePerpetrators> MultiplePerpetrators { get; set; }
        public DbSet<PoliceAttendance> PoliceAttendances { get; set; }
        public DbSet<PoliceReported> PolicesReported { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<ReferralContact> ReferralContacts { get; set; }
        public DbSet<ReferralSource> ReferralSources { get; set; }
        public DbSet<ReferredCbvs> ReferredCbvses { get; set; }
        public DbSet<ReferringHospital> ReferringHospitals { get; set; }
        public DbSet<RepeatClient> RepeatClients { get; set; }
        public DbSet<RiskLevel> RiskLevels { get; set; }
        public DbSet<RiskStatus> RiskStatuses { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SexWork> SexWorks { get; set; }
        public DbSet<SocialWorkAttendance> SocialWorkAttendances { get; set; }
        public DbSet<StatusOfFile> StatusOfFiles { get; set; }
        public DbSet<ThirdPartyReport> ThirdPartyReports { get; set; }
        public DbSet<VictimOfIncident> VictimsOfIncident { get; set; }
        public DbSet<VictimServicesAttendance> VictimServicesAttendances { get; set; }
    }
}
