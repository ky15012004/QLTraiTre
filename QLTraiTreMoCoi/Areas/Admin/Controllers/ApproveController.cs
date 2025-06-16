using Microsoft.AspNetCore.Mvc;
using QLTraiTreMoCoi.Areas.Admin.Services;

namespace QLTraiTreMoCoi.Areas.Admin.Controllers
{
    public class ApproveController : Controller
    {
        private readonly IAdminService _adminService;
        public ApproveController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [Area("Admin")]
        public async Task<IActionResult> ListApprove()
        {
            var list = await _adminService.GetListDKGuiTre();
            return View(list);
        }

        [Area("Admin")]
        [HttpGet]
        public async Task<IActionResult> ApproveApplication(int id)
        {
            var model = await _adminService.GetDKGuiTre(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
    }
}
