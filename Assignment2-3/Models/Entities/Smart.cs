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
    class Smart
    {
        [ForeignKey("Client")]
        public int ClientReferenceNumber { get; set; }
        public SexWork SexWork { get; set; }
        public MultiplePerpetrators MultiplePerpetrators { get; set; }
        public DrugAssault DrugAssault { get; set; }
        public CityOfAssault CityOfAssault { get; set; }
        public CityOfResidence CityOfResidence { get; set; }
        public int AccompanimentMinutes { get; set; }
        public ReferringHospital ReferringHospital { get; set; }
        public HospitalAttended HospitalAttended { get; set; }
        public SocialWorkAttendance SocialWorkAttendance { get; set; }
        public PoliceAttendance PoliceAttendance { get; set; }
        public VictimServicesAttendance VictimServicesAttendance { get; set; }
        public MedicalOnly MedicalOnly { get; set; }
        public EvidenceStored EvidenceStored { get; set; }
        public HivMeds HivMeds { get; set; }
        public ReferredCbvs ReferredCbvs { get; set; }
        public PoliceReported PoliceReported { get; set; }
        public ThirdPartyReport ThirdPartyReport { get; set; }
        public BadDateReport BadDateReport { get; set; }
        public int NumTransportsProvided { get; set; }
        public bool ReferredToNurse { get; set; }
    }
}
