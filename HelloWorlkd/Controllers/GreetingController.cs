using Microsoft.AspNetCore.Mvc;

namespace HelloWorlkd.Controllers
{
    public class GreetingController : Controller
    {

        public IActionResult Index()
        {
            return RedirectToAction("NameYourself", "Greeting");
        }
        public IActionResult NameYourself()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Greet(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "Guest";
            }
            return View(model: name);
        }
    }
}
