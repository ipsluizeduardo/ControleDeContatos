using System.Diagnostics;
using ControleDeContatos.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
