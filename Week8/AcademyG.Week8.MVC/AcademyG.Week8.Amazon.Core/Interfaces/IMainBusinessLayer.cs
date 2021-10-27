using AcademyG.Week8.Amazon.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week8.Amazon.Core.Interfaces
{
    public interface IMainBusinessLayer
    {
        IEnumerable<Product> FetchProducts(Func<Product, bool> filter = null);
        Product GetProductById(int id);
        Product GetProductByCode(string code);
        ResultBL CreateProduct(Product newProduct);
        ResultBL EditProduct(Product modifiedProduct);

        ResultBL DeleteProductById(int id);
    }
}
