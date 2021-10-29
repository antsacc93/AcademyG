using AcademyG.Week8.EsercitazioneFinale.Core.Models;
using AcademyG.Week8.EsercitazioneFinale.MVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyG.Week8.EsercitazioneFinale.MVC.Helpers
{
    public static class MappingExtensions
    {
        //public static IEnumerable<SelectListItem> FromMenuToSelectList(this IEnumerable<MenuViewModel> menus)
        //{
        //    return menus.Select(
        //            e => new SelectListItem() { Text = e., Value = e.ToString() }).ToList();
        //}
        public static DishViewModel ToViewModel(this Dish dish)
        {
            return new DishViewModel
            {
                Id = dish.Id,
                Name = dish.Name,
                Description = dish.Description,
                DishType = dish.DishType,
                MenuID = dish.MenuID == null ? 0 : dish.MenuID.Value,
                Price = dish.Price
            };
        }

        public static IEnumerable<DishViewModel> ToListViewModel(this IEnumerable<Dish> dishes)
        {
            return dishes.Select(e => e.ToViewModel());
        }

        public static IEnumerable<MenuViewModel> ToListViewModel(this IEnumerable<Menu> menus)
        {
            return menus.Select(e => e.ToMenuViewModel());
        }

        public static MenuViewModel ToMenuViewModel(this Menu menu)
        {
            var dishesViewModel = menu.Dishes.ToListViewModel();
            return new MenuViewModel
            {
                Id = menu.Id,
                Name = menu.Name,
                Dishes = dishesViewModel,
                TotalPrice = dishesViewModel.Sum(x => x.Price)
            };
        }

    }
}
