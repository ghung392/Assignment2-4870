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
    }
}
