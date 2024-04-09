using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Eco_Tanger.Controllers
{
    public class ChartsController : Controller
    {
        [Authorize]
        public ActionResult Charts()
        {
            return View();
        }
    }
}
