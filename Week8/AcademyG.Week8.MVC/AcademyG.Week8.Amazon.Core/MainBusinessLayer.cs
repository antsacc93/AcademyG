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
            throw new NotImplementedException();
        }

        public ResultBL EditProduct(Product modifiedProduct)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> FetchProducts(Func<Product, bool> filter = null)
        {
            if(filter == null)
                return repoProd.Fetch();
            return repoProd.Fetch(filter);
        }

        public Product GetProductByCode(string code)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
