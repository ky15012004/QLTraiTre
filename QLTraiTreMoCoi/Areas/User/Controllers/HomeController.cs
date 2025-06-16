using Microsoft.AspNetCore.Mvc;

namespace QLTraiTreMoCoi.Areas.User.Controllers
{
    public class HomeController : Controller
    {
        [Area("User")]
        public IActionResult Home()
        {
            return View();
        }

        [Area("User")]
        public IActionResult RegisterChild()
        {
            return View();
        }

        [Area("User")]
        public IActionResult UpdateInfo()
        {
            return View();
        }

        [Area("User")]
        public IActionResult AdoptChild()
        {
            return View();
        }


    }
}
