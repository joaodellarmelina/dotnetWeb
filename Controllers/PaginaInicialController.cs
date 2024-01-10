using Microsoft.AspNetCore.Mvc;

namespace dotnetWeb.Controllers
{
    public class PaginaInicialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
