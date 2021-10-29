using AcademyG.Week8.EsercitazioneFinale.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyG.Week8.EsercitazioneFinale.MVC.Models
{
    public class DishViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, DataType(DataType.Text)]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public DishType DishType { get; set; }
        public int MenuID { get; set; }
        //public bool CheckValue { get; set; }
    }
}
