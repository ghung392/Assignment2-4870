using Assignment2_3.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_3.Models.Lookup
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        [Required]
        [MaxLength(40), MinLength(3)]
        public string Type { get; set; }

        public ICollection<Client> Clients { get; set; }
    }
}
