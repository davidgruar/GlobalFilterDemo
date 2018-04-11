using Microsoft.AspNetCore.Mvc;

namespace GlobalFilterDemo.Controllers
{
    using GlobalFilterDemo.Models;

    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new NameViewModel());
        }

        [HttpPost]
        public IActionResult Index(NameViewModel model)
        {
            return View(model);
        }
    }
}
