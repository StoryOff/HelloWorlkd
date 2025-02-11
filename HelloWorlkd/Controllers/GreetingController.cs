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

        [HttpPost]
        public IActionResult Greet(string name = "Guest")
        {
            ViewBag.Message = $"Greetings, {name}!";
            return View();
        }
    }
}
