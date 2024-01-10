using dotnetWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dotnetWeb.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult index() { return View(); }

        public IActionResult Filmes()
        {
            return View();
        }

        public IActionResult Series()
        {
            return View();
        }

        public IActionResult Animes()
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
