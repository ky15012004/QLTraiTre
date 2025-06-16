using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using QLTraiTreMoCoi.Areas.User.Models;
using QLTraiTreMoCoi.Areas.User.Services;
using QLTraiTreMoCoi.Models;

namespace QLTraiTreMoCoi.Areas.User.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        private readonly UserManager<NguoiDung> _userManager;
        public HomeController(IUserService userService, UserManager<NguoiDung> userManager)
        {
            _userService = userService;   
            _userManager = userManager;
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
        [HttpPost]
        [Authorize(Roles = "user")]
        public async Task<IActionResult> RegisterChild(RegisterChildReq model, IFormFile ImageFile)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Có lỗi khi đăng ký!";
                return View(model); // Trả lại form nếu có lỗi
            }

            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload");
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            string uniqueFileName = null;
            if (ImageFile != null && ImageFile.Length > 0)
            {

                uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(ImageFile.FileName);
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await ImageFile.CopyToAsync(fileStream);
                }

                model.UrlAnh = "/Upload/" + uniqueFileName;
            }

            model.TrangThai = 0;
            var user = await _userManager.GetUserAsync(User);
            //if (string.IsNullOrEmpty(user.Id))
            //{
            //    TempData["Error"] = "Không xác định được người dùng.";
            //    return RedirectToAction("Login", "Account");
            //}
            model.MaNguoiDung = user.Id;

            await _userService.RegisterChild(model);

            // TODO: Lưu model vào DB (sử dụng model.UrlAnh nếu cần)

            TempData["Success"] = "Đăng ký thành công!";
            return RedirectToAction("RegisterChild");
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
