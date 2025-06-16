using Microsoft.AspNetCore.Mvc;

namespace QLTraiTreMoCoi.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        [Area("Admin")]
        public IActionResult ListAccount()
        {
            return View();
        }

        [Area("Admin")]
        public IActionResult CreateAccount()
        {
            return View();
        }

        [Area("Admin")]
        public IActionResult EditAccount()
        {
            return View();
        }
    }
}
