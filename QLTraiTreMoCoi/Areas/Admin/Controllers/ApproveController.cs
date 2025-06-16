using Microsoft.AspNetCore.Mvc;

namespace QLTraiTreMoCoi.Areas.Admin.Controllers
{
    public class ApproveController : Controller
    {
        [Area("Admin")]
        public IActionResult ListApprove()
        {
            return View();
        }

        [Area("Admin")]
        public IActionResult ApproveApplication()
        {
            return View();
        }
    }
}
