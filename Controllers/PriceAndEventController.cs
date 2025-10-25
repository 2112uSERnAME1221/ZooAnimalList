using Microsoft.AspNetCore.Mvc;

namespace ZooAnimalList.Controllers
{
    public class PriceAndEventController : Controller
    {
        public IActionResult Event()
        {
            return View();
        }
        public IActionResult Price()
        {
            return View();
        }
    }
}
