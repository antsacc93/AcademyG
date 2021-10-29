using AcademyG.Week8.EsercitazioneFinale.Core.Models;
using AcademyG.Week8.EsercitazioneFinale.MVC.Helpers;
using AcademyG.Week8.EsercitazioneFinale.MVC.Models;
using AcademyG.Week8.EsercizioFinale.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyG.Week8.EsercitazioneFinale.MVC.Controllers
{
    public class DishesController : Controller
    {
        private readonly IBusinessLayer bl;

        public DishesController(IBusinessLayer businessLayer)
        {
            this.bl = businessLayer;
        }
        public IActionResult Index()
        {
            var dishes = bl.GetAllDishes();
            var model = dishes.ToListViewModel();
            return View(model);
        }

        [HttpGet]
        [Authorize(Policy = "CatererPolicy")]
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        [Authorize(Policy = "CatererPolicy")]
        public IActionResult Create(Dish dish)
        {
            if (dish == null)
            {
                return View("Error", new ErrorViewModel());
            }
            else
            {

                if (ModelState.IsValid && bl.AddDish(dish))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }

        }


        public IActionResult Details(int id)
        {
            var model = bl.GetDishById(id);
            return View(model);
        }

        [HttpGet]
        [Authorize(Policy = "CatererPolicy")]
        public IActionResult Delete(int id)
        {
            var model = bl.GetDishById(id);
            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "CatererPolicy")]
        public IActionResult Delete(Dish itemToDelete)
        {
            if (itemToDelete == null)
            {
                return View("Error", new ErrorViewModel());
            }
            var success = bl.RemoveDish(itemToDelete);
            if (success)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }


        [HttpGet]
        [Authorize(Policy = "CatererPolicy")]
        public IActionResult Edit(int id)
        {
            var model = bl.GetDishById(id);
            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "CatererPolicy")]
        public IActionResult Edit(Dish itemToEdit)
        {
            if (itemToEdit == null)
            {
                return View("Error", new ErrorViewModel());
            }
            var success = bl.EditDish(itemToEdit);
            if (success)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Assign(int id)
        {
            var dish = bl.GetAllDishes().FirstOrDefault(x => x.Id == id);

            ViewBag.Menus = new SelectList(bl.GetAllMenus().Select(x => x.Name));
            return View(new AssignmentDishViewModel { ID = id });
        }

        [HttpPost]
        public IActionResult Assign(AssignmentDishViewModel dishToAssign)
        {

            var menu = bl.GetAllMenus().FirstOrDefault(x => x.Name == dishToAssign.NameOfMenu);
            bl.AssignDishToMenu(menu.Id, dishToAssign.ID);
            return Redirect("/");
        }
    }
}
