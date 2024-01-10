using dotnetWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dotnetWeb.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index() { return View(); }

        public IActionResult Filmes(string name)
        {
            ViewData["name"] = "Hello" + name;
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

        public string Joaovitor() {

            return "My name is john and im the fastest and the greater of all time";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
