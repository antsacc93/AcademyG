using AcademyG.Week8.Amazon.Core.Interfaces;
using AcademyG.Week8.Amazon.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week8.Amazon.Core
{
    public class MainBusinessLayer : IMainBusinessLayer
    {
        private readonly IRepositoryProduct repoProd;

        public MainBusinessLayer(IRepositoryProduct repoProduct)
        {
            this.repoProd = repoProduct;
        }

        public ResultBL CreateProduct(Product newProduct)
        {
            if (newProduct == null)
                return new ResultBL(false, "Invalid Employee data");
            var result = repoProd.AddItem(newProduct);

            return new ResultBL(result, result ? "Ok!" : "Sorry, something wrong!");
        }

        public ResultBL EditProduct(Product modifiedProduct)
        {
            if (modifiedProduct == null)
                return new ResultBL(false, "Invalid Employee data");
            var result = repoProd.UpdateItem(modifiedProduct);

            return new ResultBL(result, result ? "Ok!" : "Cannot update Employee");
        }

        public IEnumerable<Product> FetchProducts(Func<Product, bool> filter = null)
        {
            if(filter == null)
                return repoProd.Fetch();
            return repoProd.Fetch(filter);
        }

        public Product GetProductByCode(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return null;
            }
            return repoProd.GetProductByCode(code);
        }

        public Product GetProductById(int id)
        {
            if (id <= 0)
                return null;
            return repoProd.GetById(id);
        }
    }
}
