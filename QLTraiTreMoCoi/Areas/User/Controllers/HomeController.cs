using Microsoft.AspNetCore.Mvc;
using QLTraiTreMoCoi.Areas.User.Models;
using QLTraiTreMoCoi.Areas.User.Services;

namespace QLTraiTreMoCoi.Areas.User.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        public HomeController(IUserService userService)
        {
            _userService = userService;   
        }
        [Area("User")]
        public IActionResult Home()
        {
            return View();
        }

        [Area("User")]
        public IActionResult RegisterChild()
        {
            var req = new RegisterChildReq();
            return View(req);
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
