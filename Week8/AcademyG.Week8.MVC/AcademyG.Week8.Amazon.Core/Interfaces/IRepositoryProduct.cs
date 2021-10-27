using AcademyG.Week8.Amazon.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week8.Amazon.Core.Interfaces
{
    public interface IRepositoryProduct : IRepository<Product>
    {
        public Product GetProductByCode(string code);
    }
}
