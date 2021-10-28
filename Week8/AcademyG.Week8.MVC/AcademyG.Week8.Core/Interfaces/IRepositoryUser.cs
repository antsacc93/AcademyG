using AcademyG.Week8.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week8.Core.Interfaces
{
    public interface IRepositoryUser : IRepository<User>
    {
        User GetByEmail(string email);
    }
}
