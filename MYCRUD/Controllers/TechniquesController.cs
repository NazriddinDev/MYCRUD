using Microsoft.AspNetCore.Mvc;

namespace MYCRUD.Controllers
{
    public class TechniquesController : Controller
    {
        public IActionResult AddTechnique()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
