using Assignment2_3.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_3.Models.Lookup
{
    public class AssignedWorker
    {
        [Key]
        public int AssignedWorkerId { get; set; }
        public string Worker { get; set; }

        public ICollection<Client> Clients { get; set; }
    }
}
