using AcademyG.Week8.Amazon.Core.Models;
using AcademyG.Week8.Amazon.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyG.Week8.Amazon.MVC.Helper
{
    public static class MappingExtension
    {
        public static ProductViewModel ToViewModel(this Product product)
        {
            return new ProductViewModel
            {
                ID = product.Id,
                ProductCode = product.Code,
                Price = product.Price,
                Type = product.Type,
                Description = product.Description,
                PurchasePrice = product.PurchasePrice
            };
        }

        public static IEnumerable<ProductViewModel> ToListViewModel(this IEnumerable<Product> products)
        {
            return products.Select(e => e.ToViewModel());
        }

        public static Product ToProduct(this ProductViewModel prodViewModel)
        {
            return new Product
            {
                Id = prodViewModel.ID,
                Code = prodViewModel.ProductCode,
                Description = prodViewModel.Description,
                Price = prodViewModel.Price,
                Type = prodViewModel.Type,
                PurchasePrice = prodViewModel.PurchasePrice
            };
        }
    }
}
