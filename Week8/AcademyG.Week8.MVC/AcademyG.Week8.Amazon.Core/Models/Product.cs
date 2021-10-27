using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week8.Amazon.Core.Models
{
    public enum ProductType
    {
        Electronic,
        Clothes,
        HomeLife
    }
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ProductType Type { get; set; }
        public decimal Price { get; set; }
        public decimal PurchasePrice { get; set; }
    }
}
