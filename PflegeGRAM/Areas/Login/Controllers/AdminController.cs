using Microsoft.AspNetCore.Mvc;

namespace PflegeGRAM.Areas.Login.Controllers
{
    [Area("Login")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        { 
            return View();
        }


    }
}
