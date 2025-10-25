using Microsoft.AspNetCore.Mvc;

namespace ZooAnimalList.Controllers
{
    public class AnimalController : Controller
    {
        public IActionResult Aquatic()
        {
            return View();
        }
        public IActionResult Avian()
        {
            return View();
        }
        public IActionResult Land()
        {
            return View();
        }
    }
}
