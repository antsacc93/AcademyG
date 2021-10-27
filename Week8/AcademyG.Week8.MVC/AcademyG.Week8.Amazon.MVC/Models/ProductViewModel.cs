using AcademyG.Week8.Amazon.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyG.Week8.Amazon.MVC.Models
{
    public class ProductViewModel
    {
        public int ID { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public decimal PurchasePrice { get; set; }
        public string Description { get; set; }
        public ProductType Type { get; set; }
    }
}
