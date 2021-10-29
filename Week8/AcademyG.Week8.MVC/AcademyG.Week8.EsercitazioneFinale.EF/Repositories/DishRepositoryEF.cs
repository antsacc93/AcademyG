using AcademyG.Week8.EsercitazioneFinale.Core.Models;
using AcademyG.Week8.EsercitazioneFinale.EF;
using AcademyG.Week8.EsercizioFinale.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace AcademyG.Week8.EsercitazioneFinale.EF.Repositories
{
    public class DishRepositoryEF : IDishRepository
    {
        private readonly RestaurantContext ctx;

        public DishRepositoryEF(RestaurantContext context)
        {
            this.ctx = context;
        }

        public bool AddItem(Dish newItem)
        {
            if(newItem == null)
            {
                return false;
            }
            try
            {
                ctx.Dishes.Add(newItem);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool EditDish(int id)
        {         
            try
            {
                var itemToEdit = GetByID(id);
                if(itemToEdit == null)
                {
                    return false;
                }
                else
                {
                    ctx.Entry(itemToEdit).State = EntityState.Modified;
                    ctx.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Dish> FetchAll()
        {
            return ctx.Dishes;
        }

        public Dish GetByID(int id)
        {
            if(id < 0)
            {
                return null;
            }
            return ctx.Dishes.Find(id);
        }

        public bool RemoveItem(Dish item)
        {
            if(item == null)
            {
                return false;
            }
            try
            {
                ctx.Dishes.Remove(item);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
