using Microsoft.EntityFrameworkCore;
using QLTraiTreMoCoi.Areas.Admin.Models;
using QLTraiTreMoCoi.Data;

namespace QLTraiTreMoCoi.Areas.Admin.Services
{
    public class ItemAdminService : IAdminService
    {
        private readonly AppDbContext _context;
        public ItemAdminService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<DKGuiTreDetailRes> GetDKGuiTre(int id)
        {
            var result = await _context.DKGuiTres
                .Include(x => x.NguoiDung) // 🔥 PHẢI Include nếu muốn lấy TenNguoiGui từ navigation
                .Where(x => x.Id == id)
                .Select(x => new DKGuiTreDetailRes
                {
                    Id = x.Id,
                    TenNguoiGui = x.NguoiDung.HoTen,
                    NgayDangKy = x.NgayDangKy,
                    TrangThai = x.TrangThai,
                    NgayTiepNhanTre = x.NgayTiepNhanTre,
                    HoTenTre = x.HoTenTre,
                    NgaySinhTre = x.NgaySinhTre,
                    GioiTinhTre = x.GioiTinhTre,
                    DanTocTre = x.DanTocTre,
                    UrlAnh = x.UrlAnh,
                    HoanCanh = x.HoanCanh,
                    QuanHeVoiNguoiGui = x.QuanHeVoiNguoiGui
                })
                .FirstOrDefaultAsync();

            return result;
        }


        public async Task<List<DKGuiTreRes>> GetListDKGuiTre() {
            return await _context.DKGuiTres.Select(x => new DKGuiTreRes
            {
                GioiTinh = x.GioiTinhTre,
                HoanCanh = x.HoanCanh,
                HoTen = x.HoTenTre,
                Id = x.Id,
                ImageUrl = x.UrlAnh,
                NgaySinh = x.NgaySinhTre
            }).ToListAsync();
        }

        public async Task<bool> UpdateStatus(int id)
        {
            var tre = await _context.ThongTinTres.FirstOrDefaultAsync(x => x.Id == id);
            if (tre == null)
            {
                return false;
            }

            tre.TrangThai = 0;
            _context.ThongTinTres.Update(tre);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
