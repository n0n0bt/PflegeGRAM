using Microsoft.AspNetCore.Mvc;

namespace PflegeGRAM.Areas.Identity.Controllers
{
    public class LoginRegisterController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
