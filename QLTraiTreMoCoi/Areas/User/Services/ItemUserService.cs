using QLTraiTreMoCoi.Areas.User.Models;
using QLTraiTreMoCoi.Data;
using QLTraiTreMoCoi.Models;

namespace QLTraiTreMoCoi.Areas.User.Services
{ 

    public class ItemUserService : IUserService
    {
        private readonly AppDbContext _dbContext;
        public ItemUserService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<DataResponse<string>> RegisterChild(RegisterChildReq req)
        {
            if (req == null)
            {
                return new DataResponse<string>
                {
                    data = null,
                    message = "Thông tin gửi lên không hợp lệ!",
                    success = false
                };
            }

            var newRecord = new DKGuiTre
            {
                NguoiDungId = req.MaNguoiDung,
                NgayDangKy = req.NgayDangKy,
                NgayTiepNhanTre = req.NgayTiepNhanTre,
                HoTenTre = req.HoTenTre,
                NgaySinhTre = req.NgaySinhTre,
                GioiTinhTre = req.GioiTinhTre,
                DanTocTre = req.DanTocTre,
                UrlAnh = req.UrlAnh ?? string.Empty,
                HoanCanh = req.HoanCanh,
                QuanHeVoiNguoiGui = req.QuanHeVoiNguoiGui,
                TrangThai = req.TrangThai
            };

            await _dbContext.AddAsync(newRecord);
            await _dbContext.SaveChangesAsync();

            return new DataResponse<string>
            {
                data = null,
                message = "Gửi yêu cầu thành công!",
                success = true
            };
        }
    }
}
