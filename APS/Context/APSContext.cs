using APS.Models;
using Microsoft.EntityFrameworkCore;

namespace APS.Context
{
    public class APSContext : DbContext
    {
        public APSContext(DbContextOptions<APSContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Locsite> Locsites { get; set; }
        public DbSet<Merchandise> Merchandises { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Invoice>().ToTable("Invoice");
            modelBuilder.Entity<Locsite>().ToTable("Locsite");
            modelBuilder.Entity<Merchandise>().ToTable("Merchandise");
            modelBuilder.Entity<Part>().ToTable("Part");
            modelBuilder.Entity<Stock>().ToTable("Stock");
            modelBuilder.Entity<Vehicle>().ToTable("Vehicle");
            modelBuilder.Entity<Vendor>().ToTable("Vendor");
        }
    }
}
