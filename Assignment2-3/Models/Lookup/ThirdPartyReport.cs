﻿using Assignment2_3.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_3.Models.Lookup
{
    class ThirdPartyReport
    {
        [Key]
        public int ThirdPartyReportId { get; set; }
        public string Description { get; set; }

        public ICollection<Smart> Smarts { get; set; }
    }
}