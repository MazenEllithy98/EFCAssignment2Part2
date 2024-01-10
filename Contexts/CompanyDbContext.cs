using EFCAssignment2Part2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCAssignment2Part2.Contexts
{
    internal class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

            => optionsBuilder.UseSqlServer("Server = . ; Database = CompanyDB ; Trusted_Connection = true");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Table per hiererachy

            modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();


            base.OnModelCreating(modelBuilder);
        }

        ///Table per Concrete Class
        public DbSet<FullTimeEmployee> FullTimeEmployee { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployee { get; set; }


    }
}
