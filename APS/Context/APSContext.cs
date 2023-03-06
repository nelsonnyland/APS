using APS.Models;
using Microsoft.EntityFrameworkCore;

namespace APS.Context
{
    public class APSContext : DbContext
    {
        public APSContext(DbContextOptions<APSContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Vendor>().ToTable("Vendor");
        }
    }
}
