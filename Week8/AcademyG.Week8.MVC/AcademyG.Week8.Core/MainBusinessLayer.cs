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
        private readonly IRepositoryUser repoUser;

        public MainBusinessLayer(IRepositoryEmployee repoEmployee, 
                                IRepositoryUser repoUser)
        {
            this.repoEmp = repoEmployee;
            this.repoUser = repoUser;
        }

        public ResultBL AddNewUser(User user)
        {
            if(user == null)
            {
                return new ResultBL(false, "Invalid user");
            }
            var result = repoUser.AddItem(user);
            if (!result)
                return new ResultBL(result, "Something wrong!");
            return new ResultBL(result, "Ok!");
        }

        public ResultBL CreateEmployee(Employee newEmployee)
        {
            if (newEmployee == null)
                return new ResultBL(false, "Invalid Employee data");
            var result = repoEmp.AddItem(newEmployee);

            return new ResultBL(result, result ? "Ok!" : "Sorry, something wrong!");
        }

        public ResultBL DeleteEmployee(int employeeId)
        {
            if (employeeId <= 0)
                return new ResultBL(false, "Invalid ID");
            var result = repoEmp.DeleteItem(employeeId);
            if (!result)
                return new ResultBL(result, "Something wrong");
            return new ResultBL(result, "Ok!");
        }

        public ResultBL EditEmployee(Employee modifiedEmployee)
        {
            if (modifiedEmployee == null)
                return new ResultBL(false, "Invalid Employee data");
            var result = repoEmp.UpdateItem(modifiedEmployee);

            return new ResultBL(result, result ? "Ok!" : "Cannot update Employee");
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

        public User GetUserByEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return null;
            return repoUser.GetByEmail(email);
        }
    }
}
