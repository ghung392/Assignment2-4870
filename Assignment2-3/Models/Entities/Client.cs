using Assignment2_3.Models.Lookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_3.Models.Entities
{
    class Client
    {
        public int ClientReferenceNumber { get; set; }
        public FiscalYear FiscalYear { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string PoliceFileNumber { get; set; }
        public int CourtFileNumber { get; set; }
        public int SwcFileNumber { get; set; }
        public RiskLevel RiskLevel { get; set; }
        public Service Service { get; set; }
        public Program Program { get; set; }
        public string RiskAssessAssignment { get; set; }
        public RiskStatus RiskStatus { get; set; }
        public AssignedWorker AssignedWorker { get; set; }
        public ReferralSource ReferralSource { get; set; }
        public ReferralContact ReferralContact { get; set; }
        public Incident Incident { get; set; }
        public string AbuserName { get; set; }
        public AbuserRelationship AbuserRelationship { get; set; }
        public VictimOfIncident VictimOfIncident { get; set; }
        public FamilyViolenceFile FamilyViolenceFile { get; set; }
        public char Gender { get; set; }
        public Ethnicity Ethnicity { get; set; }
        public Age Age { get; set; }
        public RepeatClient RepeatClient { get; set; }
        public DuplicateFile DuplicateFile { get; set; }
        public int NumOfChildrenZeroToSix { get; set; }
        public int NumOfChildrenSevenToTwelve { get; set; }
        public int NumOfChildrenThirteenToEighteen { get; set; }
        public StatusOfFile StatusOfFile { get; set; }
        public DateTime DateLastTransferred { get; set; }
        public DateTime DateClosed { get; set; }
        public DateTime DateReopened { get; set; }
    }
}
