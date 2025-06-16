using Microsoft.AspNetCore.Mvc;

namespace QLTraiTreMoCoi.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        public IActionResult CreateChild()
        {
            return View();
        }

        [Area("Admin")]
        public IActionResult ListChild()
        {
            return View();
        }

        [Area("Admin")]
        public IActionResult EditChild()
        {
            return View();
        }

        [Area("Admin")]
        public IActionResult AcceptChild()
        {
            return View();
        }

        [Area("Admin")]
        public IActionResult ListAccept()
        {
            return View();
        }
    }
}
