using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QLTraiTreMoCoi.Models;

namespace QLTraiTreMoCoi.Data
{
    public class AppDbContext : IdentityDbContext<NguoiDung>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }
    }
}
