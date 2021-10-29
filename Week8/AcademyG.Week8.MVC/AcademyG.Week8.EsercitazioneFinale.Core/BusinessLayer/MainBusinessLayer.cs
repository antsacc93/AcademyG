using AcademyG.Week8.EsercitazioneFinale.Core.Models;
using AcademyG.Week8.EsercizioFinale.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AcademyG.Week8.EsercizioFinale.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IDishRepository dishRepo;
        private readonly IUserRepository userRepo;
        private readonly IMenuRepository menuRepo;

        public MainBusinessLayer(IDishRepository dishRepository, IUserRepository userRepository, IMenuRepository menuRepository)
        {
            this.dishRepo = dishRepository;
            this.userRepo = userRepository;
            menuRepo = menuRepository;
        }

        public bool AddDish(Dish newDish)
        {           
            return dishRepo.AddItem(newDish);
        }

        public bool AddUser(User newUser)
        {
            if(GetUser(newUser.Username) != null) // guardia per il controllo dell'esistenza di un utente
            {
                return false;
            }
            return userRepo.AddItem(newUser);
        }

        public IEnumerable<Dish> GetAllDishes()
        {
            return dishRepo.FetchAll();
        }

        public User GetUser(string username)
        {
            return userRepo.GetUserByUsername(username);
        }
        public Dish GetDishById(int id)
        {
            if(id < 0)
            {
                return null;
            }
            return dishRepo.GetByID(id);
        }

        public bool RemoveDish(Dish itemToDelete)
        {
            return dishRepo.RemoveItem(itemToDelete);
        }

        public bool EditDish(Dish itemToEdit)
        {
            return dishRepo.EditDish(itemToEdit.Id);
        }

        public IEnumerable<Menu> GetAllMenus()
        {
            return menuRepo.FetchAll();
        }

        public bool AddMenu(Menu menu)
        {
            return menuRepo.AddItem(menu);
        }

        public bool AssignDishToMenu(int idMenu, int idDish)
        {
            
            
            menuRepo.AssignDishToMenu(idMenu, idDish);
            return true;
        }

        public Menu GetMenuWithAllDishes(int id)
        {
            return menuRepo.GetMenu(id);
        }

        public bool DecoupleDishToMenu(int idMenu, int idDish)
        {
            return menuRepo.DecoupleDishToMenu(idMenu, idDish);
        }
    }
}
