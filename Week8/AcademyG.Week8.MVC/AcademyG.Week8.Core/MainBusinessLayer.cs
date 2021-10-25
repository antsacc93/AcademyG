using AcademyG.Week8.Core.Interfaces;
using AcademyG.Week8.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week8.Core
{
    public class MainBusinessLayer : IMainBusinessLayer
    {
        private readonly IRepositoryEmployee repoEmp;

        public MainBusinessLayer(IRepositoryEmployee repoEmployee)
        {
            this.repoEmp = repoEmployee;
        }

        public IEnumerable<Employee> FetchEmployees(Func<Employee, bool> filter = null)
        {
            return this.repoEmp.Fetch(filter);
        }

        public Employee GetEmployeeByCode(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return null;
            }
            return this.repoEmp.GetEmployeeByCode(code);
        }

        public Employee GetEmployeeById(int id)
        {
            if (id <= 0)
                return null;
            return this.repoEmp.GetById(id);
        }
    }
}
