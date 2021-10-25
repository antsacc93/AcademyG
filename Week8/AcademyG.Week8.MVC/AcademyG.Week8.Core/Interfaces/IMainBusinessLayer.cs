using AcademyG.Week8.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week8.Core.Interfaces
{
    public interface IMainBusinessLayer
    {
        IEnumerable<Employee> FetchEmployees(Func<Employee, bool> filter = null);
        Employee GetEmployeeById(int id);
        Employee GetEmployeeByCode(string code);
    }
}
