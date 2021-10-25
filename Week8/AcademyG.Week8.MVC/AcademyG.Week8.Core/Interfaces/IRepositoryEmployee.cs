using AcademyG.Week8.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week8.Core.Interfaces
{
    public interface IRepositoryEmployee : IRepository<Employee>
    {
        public Employee GetEmployeeByCode(string code);
    }
}
