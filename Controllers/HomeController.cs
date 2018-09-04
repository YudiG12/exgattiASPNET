using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using exgattiASPNET.Models;

namespace exgattiASPNET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ExIdade()
        {
            return View();
        }
        public IActionResult ExPecas()
        {
            return View();
        }
        public IActionResult ExCalculo()
        {
            return View();
        }
        public IActionResult ExSoma()
        {
            return View();
        }
        public IActionResult ExIdadeSexo()
        {
            return View();
        }
        public IActionResult ExAreaTriangulo()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
