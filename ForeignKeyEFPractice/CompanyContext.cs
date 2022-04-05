using ForeignKeyEFPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace ForeignKeyEFPractice
{
    public class CompanyContext : DbContext
    {

        //DB Context using EF Core
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) { }


        //Each Table is Generated off the Classes in DBSets
        public DbSet<Company> Company { get; set; }
        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(p => p.Company)
                .WithMany(b => b.Employees);
        }


    }
}
