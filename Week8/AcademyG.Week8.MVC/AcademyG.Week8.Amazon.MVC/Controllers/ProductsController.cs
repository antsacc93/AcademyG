using AcademyG.Week8.Amazon.Core.Interfaces;
using AcademyG.Week8.Amazon.Core.Models;
using AcademyG.Week8.Amazon.MVC.Helper;
using AcademyG.Week8.Amazon.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyG.Week8.Amazon.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IMainBusinessLayer mainBl;

        public ProductsController(IMainBusinessLayer bl)
        {
            this.mainBl = bl;
        }
        public IActionResult Index()
        {
            var result = mainBl.FetchProducts();
            var resultMapping = result.ToListViewModel();
            return View(resultMapping);
        }

        public IActionResult Create()
        {
            LoadViewBag();
            return View(new ProductViewModel());
        }

        //HTTP POST Products/Create
        [HttpPost]
        public IActionResult Create(ProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (model == null)
            {
                return View("ExceptionError", new ResultBL(false, "Error!"));
            }
            //Mappatura da Employee View Model a Employee
            Product newEmp = model.ToProduct();
            var result = mainBl.CreateProduct(newEmp);
            if (!result.Success)
            {
                return View("ExceptionError", result);
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            if (id <= 0)
                return View("NotFound");
            var prodToEdit = mainBl.GetProductById(id);
            if (prodToEdit == null)
                return View("NotFound");
            var prodViewModel = prodToEdit.ToViewModel();
            LoadViewBag();
            return View(prodViewModel);
        }

        //POST Employees/Edit/ + dati del dipendente da modificare
        [HttpPost]
        public IActionResult Edit(ProductViewModel pvm)
        {
            if (!ModelState.IsValid)
            {
                return View(pvm);
            }
            if (pvm == null)
                return View("ExceptionError", new ResultBL(false, "Something wrong!"));
            //MAPPING DA VIEW MODEL -> EMPLOYEE
            var prodToEdit = pvm.ToProduct();
            var result = mainBl.EditProduct(prodToEdit);
            if (!result.Success)
            {
                return View("ExceptionError", result);
            }
            return View("Detail", pvm);
        }

        public IActionResult Detail(int id)
        {
            if(id <= 0)
            {
                return View("Index");
            }
            var prod = mainBl.GetProductById(id);
            //VERIFICA SULL'OGGETTO TROVATO
            var prodViewModel = prod.ToViewModel();
            return View(prodViewModel);
        }

        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return View();

            // chiamata a BL ...
            Product data = mainBl.GetProductById(id);
            ProductViewModel model = data.ToViewModel();

            return View(model);
        }

        // HTTP POST /products/delete/16
        [HttpPost]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            if (id <= 0)
                return View();

            // chiamate al BL ...
            var result = mainBl.DeleteProductById(id);

            if (!result.Success)
            {
                return View("Error", null);
            } // in caso di errore

            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteJS(int id)
        {
            if (id <= 0)
                return Json(false);

            // chiamate al BL ...
            var result = mainBl.DeleteProductById(id);

            return Json(result.Success);
        }


        private void LoadViewBag()
        {

            //ViewBag.Categories = new SelectList(new[]{
            //    "Electronic",
            //    "Clothes",
            //    "HomeLife"
            //});
            ViewBag.Categories = MappingExtension.FromEnumToSelectList<ProductType>();
        }


    }
}
