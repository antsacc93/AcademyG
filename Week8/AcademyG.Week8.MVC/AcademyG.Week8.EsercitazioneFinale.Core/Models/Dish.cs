using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week8.EsercitazioneFinale.Core.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DishType DishType { get; set; }
        public int? MenuID { get; set; }
        public Menu Menu { get; set; }

    }

    public enum DishType
    {

        Main,
        Second,
        Side,
        Dessert
    }
}
