using AcademyG.Week8.Core.Models;
using AcademyG.Week8.MVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyG.Week8.MVC.Helpers
{
    public static class MappingExtensions
    {
        


        public static EmployeeViewModel ToViewModel(this Employee employee)
        {
            return new EmployeeViewModel
            {
                Id = employee.Id,
                EmployeeCode = employee.EmployeeCode,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                BirthDate = employee.BirthDate
            };
        }

        public static IEnumerable<EmployeeViewModel> ToListViewModel(this IEnumerable<Employee> employees)
        {
            return employees.Select(e => e.ToViewModel());
        }

        public static Employee ToEmployee(this EmployeeViewModel empViewModel)
        {
            return new Employee
            {
                Id = empViewModel.Id,
                FirstName = empViewModel.FirstName,
                LastName = empViewModel.LastName,
                BirthDate = empViewModel.BirthDate,
                EmployeeCode = empViewModel.EmployeeCode
            };
        }

        public static User ToUser(this UserRegistrationViewModel userViewModel)
        {
            return new User
            {
                Email = userViewModel.Email,
                Password = userViewModel.Password,
                Role = Role.User
            };
        }

    }
}
