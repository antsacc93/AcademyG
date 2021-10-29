using AcademyG.Week8.EsercitazioneFinale.Core.Models;
using AcademyG.Week8.EsercitazioneFinale.EF;
using AcademyG.Week8.EsercizioFinale.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AcademyG.Week8.EsercitazioneFinale.EF.Repositories
{
    public class MenuRepositoryEF : IMenuRepository
    {
        private readonly RestaurantContext ctx;

        public MenuRepositoryEF(RestaurantContext context)
        {
            this.ctx = context;
        }
        public bool AddItem(Menu newItem)
        {
            ctx.Menus.Add(newItem);
            ctx.SaveChanges();
            return true;
        }

        public bool AssignDishToMenu(int idMenu, int idDish)
        {
            var menu = ctx.Menus.Find(idMenu);
            var dish = ctx.Dishes.Find(idDish);
            menu.Dishes.Add(dish);
            ctx.SaveChanges();
            return true;
        }

        public bool DecoupleDishToMenu(int idMenu, int idDish)
        {
            var menu = ctx.Menus.Find(idMenu);
            var dish = ctx.Dishes.Find(idDish);
            menu.Dishes.Remove(dish);
            ctx.SaveChanges();
            return true;
        }

        public IEnumerable<Menu> FetchAll()
        {
            return ctx.Menus;
        }

        public Menu GetMenu(int id)
        {
            return ctx.Menus.Include(x => x.Dishes).FirstOrDefault(x => x.Id == id);
        }

        public bool RemoveItem(Menu item)
        {
            throw new NotImplementedException();
        }
    }
}
