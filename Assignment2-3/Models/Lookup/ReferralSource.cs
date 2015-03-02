using Assignment2_3.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_3.Models.Lookup
{
    class ReferralSource
    {
        [Key]
        public int ReferralSourceId { get; set; }
        public string Source { get; set; }

        public ICollection<Client> Clients { get; set; }
    }
}
