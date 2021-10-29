using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week8.EsercitazioneFinale.Core.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Dish> Dishes { get; set; } = new List<Dish>();

    }
}
