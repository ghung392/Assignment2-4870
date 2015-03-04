using Assignment2_3.Models.Lookup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_3.Models.Entities
{
    public class Smart
    {
        [Key]
        virtual public int ClientReferenceNumber { get; set; }
        public object SexWork { get; set; }
        public object MultiplePerpetrators { get; set; }
        public object DrugAssault { get; set; }
        public object CityOfAssault { get; set; }
        public object CityOfResidence { get; set; }
        public int AccompanimentMinutes { get; set; }
        public object ReferringHospital { get; set; }
        public object HospitalAttended { get; set; }
        public object SocialWorkAttendance { get; set; }
        public object PoliceAttendance { get; set; }
        public object VictimServicesAttendance { get; set; }
        public object MedicalOnly { get; set; }
        public object EvidenceStored { get; set; }
        public object HivMeds { get; set; }
        public object ReferredCbvs { get; set; }
        public object PoliceReported { get; set; }
        public object ThirdPartyReport { get; set; }
        public object BadDateReport { get; set; }
        public int NumTransportsProvided { get; set; }
        public bool ReferredToNurse { get; set; }
    }
}
