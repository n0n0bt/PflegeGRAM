using Microsoft.AspNetCore.Mvc;

namespace PflegeGRAM.Areas.Register.Controllers
{
    [Area("Register")]
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
