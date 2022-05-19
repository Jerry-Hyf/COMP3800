using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RDKS.Models;
using RDKSDatabase.Models;

namespace RDKSDatabase.Data
{
    public class RDKSDatabaseContext : DbContext
    {
        public RDKSDatabaseContext (DbContextOptions<RDKSDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<RDKS.Models.HWY37N_HAZELTON>? HWY37N_HAZELTON { get; set; }

        public DbSet<RDKS.Models.HWY37N_KITWANGA>? HWY37N_KITWANGA { get; set; }
        public DbSet<RDKSDatabase.Models.Customer>? Customer { get; set; }
        public DbSet<RDKSDatabase.Models.Address>? Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Address>().ToTable("Address");
        }

        public DbSet<RDKSDatabase.Models.ABCRecycling>? ABCRecycling { get; set; }
    }
}
