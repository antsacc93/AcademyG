using AcademyG.Week8.Amazon.Core.Interfaces;
using AcademyG.Week8.Amazon.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week8.Amazon.EF.Repositories
{
    public class RepositoryProductEF : IRepositoryProduct
    {
        private readonly AmazonContext ctx;

        public RepositoryProductEF(AmazonContext context)
        {
            this.ctx = context;
        }
        public bool AddItem(Product item)
        {
            if (item == null)
                return false;
            ctx.Products.Add(item);
            ctx.SaveChanges();
            return true;
        }

        public bool DeleteItem(int id)
        {
            if (id <= 0)
                return false;

            var itemToBeDeleted = this.ctx.Products.Find(id);

            if (itemToBeDeleted == null)
                return false;

            this.ctx.Products.Remove(itemToBeDeleted);
            this.ctx.SaveChanges();

            return true;
        }

        public IEnumerable<Product> Fetch(Func<Product, bool> filter = null)
        {
            if (filter != null)
                return this.ctx.Products.Where(filter);
            return ctx.Products;
        }

        public Product GetById(int id)
        {
            if (id <= 0)
                return null;
            return ctx.Products.Find(id);
        }

        public Product GetProductByCode(string code)
        {
            if (string.IsNullOrEmpty(code))
                return null;
            return ctx.Products.FirstOrDefault(e => e.Code.Equals(code));
        }

        public bool UpdateItem(Product updatedItem)
        {
            if (updatedItem == null)
                return false;
            ctx.Entry(updatedItem).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.SaveChanges();
            return true;
        }
    }
}
