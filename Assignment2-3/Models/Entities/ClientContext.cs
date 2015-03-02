using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_3.Models.Entities
{
    class ClientContext : DbContext
    {
        public ClientContext() : base("DefaultConnection") { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Smart> Smarts { get; set; }
    }
}
