using AcademyG.Week8.EsercitazioneFinale.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace AcademyG.Week8.EsercizioFinale.Core.Interfaces
{
    public interface IBusinessLayer
    {
        #region User
        User GetUser(string username);
        bool AddUser(User newUser);
        #endregion

        #region Dish
        IEnumerable<Dish> GetAllDishes();
        bool AddDish(Dish newDish);
        Dish GetDishById(int id);
        bool RemoveDish(Dish itemToDelete);
        bool EditDish(Dish itemToEdit);
        #endregion

        #region Menu
        IEnumerable<Menu> GetAllMenus();
        bool AddMenu(Menu menu);
        bool AssignDishToMenu(int idMenu, int idDish);
        bool DecoupleDishToMenu(int idMenu, int idDish);
        Menu GetMenuWithAllDishes(int id);
        #endregion
    }
}
