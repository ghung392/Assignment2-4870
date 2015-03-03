using Assignment2_3.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_3.Models.Lookup
{
    public class Incident
    {
        [Key]
        public int IncidentId { get; set; }
        public string Type { get; set; }

        public ICollection<Client> Clients { get; set; }
    }
}
