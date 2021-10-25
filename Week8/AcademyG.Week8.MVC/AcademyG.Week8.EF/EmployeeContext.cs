using AcademyG.Week8.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week8.EF
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var employeeEntity = builder.Entity<Employee>();

            employeeEntity.HasKey(e => e.Id);

            employeeEntity.Property(e => e.EmployeeCode)
                          .IsRequired()
                          .HasMaxLength(5);

            employeeEntity.Property(e => e.FirstName)
                          .IsRequired()
                          .HasMaxLength(40);

            employeeEntity.Property(e => e.LastName)
                          .IsRequired()
                          .HasMaxLength(40);

            employeeEntity.Property(e => e.BirthDate);

            employeeEntity.HasData(
                    new Employee
                    {
                        Id = 1,
                        EmployeeCode = "ABC12",
                        FirstName = "Mario",
                        LastName = "Rossi",
                        BirthDate = new DateTime(1980, 1, 1)
                    },
                    new Employee
                    {
                        Id = 2,
                        EmployeeCode = "ABC34",
                        FirstName = "Matteo",
                        LastName = "Mattei",
                        BirthDate = new DateTime(1990, 2, 2)
                    }
                );
        }

    }
}
