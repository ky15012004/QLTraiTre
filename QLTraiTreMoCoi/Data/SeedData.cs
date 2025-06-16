using Microsoft.AspNetCore.Identity;
using QLTraiTreMoCoi.Models;

namespace QLTraiTreMoCoi.Data
{
    public class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<NguoiDung>>();

            string[] roleNames = { "admin", "user" };

            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                    await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            // Tạo tài khoản admin mặc định
            var adminEmail = "045204006306";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                adminUser = new NguoiDung
                {
                    UserName = "045204006306",
                    Email = $"{adminEmail}@fakeemail.com",
                    CCCD = "045204006306",
                    HoTen = "Admin",
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(adminUser, "Admin@123");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "admin");
                }
            }
        }
    }
}
