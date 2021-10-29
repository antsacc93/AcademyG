using AcademyG.Week8.EsercitazioneFinale.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace AcademyG.Week8.EsercizioFinale.Core.Interfaces
{
    public interface IDishRepository : IRepository<Dish>
    {
        public Dish GetByID(int id);
        public bool EditDish(int id);
    }
}
