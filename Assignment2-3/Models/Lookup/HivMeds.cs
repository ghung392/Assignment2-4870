using Assignment2_3.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_3.Models.Lookup
{
    public class HivMeds
    {
        [Key]
        public int HivMedsId { get; set; }
        public string Description { get; set; }

        public ICollection<Smart> Smarts { get; set; }
    }
}
