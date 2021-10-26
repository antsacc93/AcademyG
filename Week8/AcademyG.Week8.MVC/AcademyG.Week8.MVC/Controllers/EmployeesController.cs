using AcademyG.Week8.Core.Interfaces;
using AcademyG.Week8.Core.Models;
using AcademyG.Week8.MVC.Helpers;
using AcademyG.Week8.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyG.Week8.MVC.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IMainBusinessLayer mainBl;

        public EmployeesController(IMainBusinessLayer bl)
        {
            this.mainBl = bl;
        }

        public IActionResult Index()
        {
            //recupero i dati degli impiegati
            var result = mainBl.FetchEmployees();
            //mappare da Employee (entità in Core) -> EmployeeViewModel
            //var resultMapping = new List<EmployeeViewModel>();
            //foreach (var item in result)
            //{
            //    resultMapping.Add(new EmployeeViewModel
            //    {
            //        EmployeeCode = item.EmployeeCode,
            //        FirstName = item.FirstName,
            //        LastName = item.LastName,
            //        BirthDate = item.BirthDate
            //    });
            //}

            var resultMapping = result.ToListViewModel();
            return View(resultMapping);
        }

        //GET Employees/Detail/{code}
        public IActionResult Detail(string code)
        {
            if (string.IsNullOrEmpty(code))
                return View("NotFound");
            var employee = this.mainBl.GetEmployeeByCode(code);
            if (employee == null)
                return View("NotFound");
            var resultMapped = employee.ToViewModel();
            return View(resultMapped);
        }

        //HTTP GET Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        //HTTP POST Employees/Create
        [HttpPost]
        public IActionResult Create(EmployeeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if(model == null)
            {
                return View("ExceptionError", new ResultBL(false, "Error!"));
            }
            //Mappatura da Employee View Model a Employee
            Employee newEmp = model.ToEmployee();
            var result = mainBl.CreateEmployee(newEmp);
            if (!result.Success)
            {
                return View("ExceptionError", result);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
