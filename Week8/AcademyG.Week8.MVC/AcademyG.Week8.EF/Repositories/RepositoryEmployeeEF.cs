using AcademyG.Week8.Core.Interfaces;
using AcademyG.Week8.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week8.EF.Repositories
{
    public class RepositoryEmployeeEF : IRepositoryEmployee
    {
        private readonly EmployeeContext ctx;

        public RepositoryEmployeeEF(EmployeeContext context)
        {
            this.ctx = context;
        }

        public IEnumerable<Employee> Fetch(Func<Employee, bool> filter = null)
        {
            if (filter != null)
                return this.ctx.Employees.Where(filter);
            return ctx.Employees;
        }

        public Employee GetById(int id)
        {
            if (id <= 0)
                return null;
            return ctx.Employees.Find(id);
        }

        public Employee GetEmployeeByCode(string code)
        {
            if (string.IsNullOrEmpty(code))
                return null;
            return ctx.Employees.FirstOrDefault(e => e.EmployeeCode.Equals(code));
        }
    }
}
