using AcademyG.Week8.Core.Interfaces;
using AcademyG.Week8.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week8.EF.Repositories
{
    public class RepositoryUserEF : IRepositoryUser
    {
        private readonly EmployeeContext _ctx;

        public RepositoryUserEF(EmployeeContext context)
        {
            _ctx = context;
        }

        public bool AddItem(User item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Fetch(Func<User, bool> filter = null)
        {
            throw new NotImplementedException();
        }

        public User GetByEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return null;
            return _ctx.Users.FirstOrDefault(u => u.Email.Equals(email));
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem(User updatedItem)
        {
            throw new NotImplementedException();
        }
    }
}
