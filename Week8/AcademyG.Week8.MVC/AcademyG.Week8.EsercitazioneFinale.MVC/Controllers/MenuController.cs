using AcademyG.Week8.EsercitazioneFinale.MVC.Helpers;
using AcademyG.Week8.EsercizioFinale.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyG.Week8.EsercitazioneFinale.MVC.Controllers
{
    public class MenuController : Controller
    {
        private readonly IBusinessLayer mainBusinessLayer;
        public MenuController(IBusinessLayer bl)
        {
            this.mainBusinessLayer = bl;
        }
        public IActionResult Index()
        {
            var menu = mainBusinessLayer.GetAllMenus();
            return View(menu.ToListViewModel());
        }

        public IActionResult Details(int id)
        {
            var model = mainBusinessLayer.GetMenuWithAllDishes(id);
            return View(model.ToMenuViewModel());
        }

        [Route("Menu/Decouple/{dishId}/{menuId}")]
        public IActionResult Decouple(int dishId, int menuId)
        {

            var model = mainBusinessLayer.DecoupleDishToMenu(menuId, dishId);
            return Json(model);
        }
    }
}
