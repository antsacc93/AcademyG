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
        public DbSet<User> Users { get; set; }

        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region EMPLOYEE
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
            #endregion

            #region USER
            var userEntity = builder.Entity<User>();
            userEntity.HasKey(i => i.Id);
            userEntity.Property(e => e.Email).IsRequired();
            userEntity.Property(p => p.Password).IsRequired();
            userEntity.Property(r => r.Role).IsRequired();

            userEntity.HasData(
                new User
                {
                    Id = 1,
                    Email = "mrossi@abc.it",
                    Password = "1234",
                    Role = Role.Administator
                },
                new User
                {
                    Id = 2,
                    Email = "asacchitella@abc.it",
                    Password = "5678",
                    Role = Role.User
                }
                );
            #endregion
        }

    }
}
