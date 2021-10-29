using AcademyG.Week8.EsercitazioneFinale.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace AcademyG.Week8.EsercizioFinale.Core.Interfaces
{
    public interface IMenuRepository : IRepository<Menu>
    {
        public bool AssignDishToMenu(int idMenu, int idDish);
        public bool DecoupleDishToMenu(int idMenu, int idDish);
        public Menu GetMenu(int id);

    }
}
