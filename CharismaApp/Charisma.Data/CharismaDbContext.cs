using Charisma.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charisma.Data
{
    public class CharismaDbContext : DbContext
    {
        public CharismaDbContext()
            : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CharismaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Charisma");
            base.OnModelCreating(modelBuilder);
        }
    }
}
