using Microsoft.AspNetCore.Mvc;

namespace PflegeGRAM.Areas.LoginRegister.Controllers
{
    [Area("LoginRegister")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        { 
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }


    }
}
