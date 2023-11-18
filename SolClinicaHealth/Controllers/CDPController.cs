using Microsoft.AspNetCore.Mvc;

namespace SolClinicaHealth.Controllers
{
    public class CDPController : Controller
    {
        [HttpPost]
        public IActionResult SaveCDP()
        {
            return View();
        }
    }
}
