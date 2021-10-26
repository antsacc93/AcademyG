using AcademyG.Week8.Core.Models;
using AcademyG.Week8.MVC.Models;
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
                FirstName = empViewModel.FirstName,
                LastName = empViewModel.LastName,
                BirthDate = empViewModel.BirthDate,
                EmployeeCode = empViewModel.EmployeeCode
            };
        }

    }
}
