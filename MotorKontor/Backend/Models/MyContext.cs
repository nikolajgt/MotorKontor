using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotorKontor.Backend.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Login> Login { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Registration> Registration { get; set; }
        //public DbSet<Address> Address { get; set; }

        public MyContext(DbContextOptions options) : base(options) { }
    }
}
