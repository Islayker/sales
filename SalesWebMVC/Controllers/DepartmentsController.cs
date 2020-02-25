using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departments> depart = new List<Departments>();
            depart.Add(new Departments { Id = 1, Name = "Eletronics" });
            depart.Add(new Departments { Id = 2, Name = "Fashion" });

            return View(depart);
        }
    }
}