using Microsoft.AspNetCore.Mvc;

namespace Eco_Tanger.Controllers
{
    public class SolutionsController : Controller
    {
        public IActionResult AirPollutionSolutions()
        {
            return View();
        }
        public IActionResult ForestPollutionSolutions()
        {
            return View();
        }
        public IActionResult WasteWaterSolutions()
        {
            return View();
        }
    }
}
