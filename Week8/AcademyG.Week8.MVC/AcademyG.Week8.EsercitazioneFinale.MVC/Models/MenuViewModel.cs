using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyG.Week8.EsercitazioneFinale.MVC.Models
{
    public class MenuViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal TotalPrice { get; set; }

        public IEnumerable<DishViewModel> Dishes { get; set; }
    }
}
