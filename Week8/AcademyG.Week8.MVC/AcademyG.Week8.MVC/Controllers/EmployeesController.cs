using AcademyG.Week8.Core.Interfaces;
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
    }
}
