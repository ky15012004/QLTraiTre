using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QLTraiTreMoCoi.Models;
using QLTraiTreMoCoi.ViewModels;
using System.Linq;
using System.Security.Claims;

namespace QLTraiTreMoCoi.Controllers
{
    public class AccountController : Controller
    {
            private readonly SignInManager<NguoiDung> signInManager;
            private readonly UserManager<NguoiDung> userManager;

            public AccountController(SignInManager<NguoiDung> signInManager, UserManager<NguoiDung> userManager)
            {
                this.signInManager = signInManager;
                this.userManager = userManager;
            }

            public IActionResult Login()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> Login(LoginViewModel model)
            {
                if (ModelState.IsValid)
                {
                    var user = await userManager.FindByNameAsync(model.CCCD);
                    if (user == null)
                    {
                        ModelState.AddModelError("", "Căn cước công dân không tồn tại");
                        TempData["Error"] = "Sai thông tin đăng nhập!";
                        return View(model);
                    }

                    var result = await signInManager.CheckPasswordSignInAsync(user, model.Password, false);
                    if (result.Succeeded)
                    {
                        // ✅ Đăng nhập kèm claim HoTen
                        var claims = new List<Claim>
                {
                    new Claim("HoTen", user.HoTen ?? "")
                };

                        await signInManager.SignInWithClaimsAsync(user, isPersistent: false, claims);

                        TempData["Success"] = "Đăng nhập thành công!";
                        var roles = await userManager.GetRolesAsync(user);
                        if(roles.Contains("admin"))
                    {
                        return RedirectToAction("ListChild", "Home", new { area = "Admin" });
                    }
                    return RedirectToAction("Home", "Home", new { area = "User" });
                    }

                    ModelState.AddModelError("", "Căn cước công dân hoặc mật khẩu không đúng");
                    TempData["Error"] = "Sai thông tin đăng nhập!";
                }

                return View(model);
            }


        public IActionResult Register()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> Register(RegisterViewModel model)
            {
                if (ModelState.IsValid)
                {
                    NguoiDung user = new NguoiDung
                    {
                        CCCD = model.CCCD,
                        Email = $"{model.CCCD}@fakeemail.com",
                        UserName = model.CCCD,
                        HoTen = model.HoTen
                    };

                    var result = await userManager.CreateAsync(user, model.Password);

                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, "user");
                        TempData["Success"] = "Dang ky thanh cong!";
                        return RedirectToAction("Login", "Account");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);

                        }
                        TempData["Error"] = "Loi khi dang ky!";
                        return View(model);
                    }
                }
                TempData["Error"] = "Loi khi dang ky!";
                return View(model);
            }


            public async Task<IActionResult> Logout()
            {
                await signInManager.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }
        
    }
}
