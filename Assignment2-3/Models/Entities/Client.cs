using Assignment2_3.Models.Lookup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_3.Models.Entities
{
    public class Client
    {
        [Key]
        public int ClientReferenceNumber { get; set; }
        public object FiscalYear { get; set; }
        public int? Month { get; set; }
        public int? Day { get; set; }

        [Required]
        [MaxLength(40), MinLength(3)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(40), MinLength(3)]
        public string FirstName { get; set; }

        [RegularExpression(@"^\d{2}-\d{5}$", ErrorMessage="Use the format: 99-99999")]
        public string PoliceFileNumber { get; set; }

        public int? CourtFileNumber { get; set; }
        public int? SwcFileNumber { get; set; }
        public object RiskLevel { get; set; }
        public object Service { get; set; }
        public object Program { get; set; }

        [MaxLength(40), MinLength(3)]
        public string RiskAssessAssignment { get; set; }

        public object RiskStatus { get; set; }
        public object AssignedWorker { get; set; }
        public object ReferralSource { get; set; }
        public object ReferralContact { get; set; }
        public object Incident { get; set; }

        [MaxLength(40), MinLength(3)]
        public string AbuserName { get; set; }

        [UIHint("AbuserRelationshipDropDown")]
        public object AbuserRelationship { get; set; }

        public object VictimOfIncident { get; set; }
        public object FamilyViolenceFile { get; set; }
        public char? Gender { get; set; }
        public object Ethnicity { get; set; }
        public object Age { get; set; }
        public object RepeatClient { get; set; }
        public object DuplicateFile { get; set; }
        public int? NumOfChildrenZeroToSix { get; set; }
        public int? NumOfChildrenSevenToTwelve { get; set; }
        public int? NumOfChildrenThirteenToEighteen { get; set; }
        public object StatusOfFile { get; set; }
        public DateTime? DateLastTransferred { get; set; }
        public DateTime? DateClosed { get; set; }
        public DateTime? DateReopened { get; set; }
    }
}
