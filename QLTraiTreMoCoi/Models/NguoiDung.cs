using Microsoft.AspNetCore.Identity;

namespace QLTraiTreMoCoi.Models
{
    public class NguoiDung : IdentityUser
    {
        public string CCCD { get; set; }
        public string HoTen { get; set; }
        public string Dantoc { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string? UrlAnh { get; set; }
        public string MatKhau { get; set; }
        public string? DiaChi { get; set; }
        public int VaiTro { get; set; }
        public string NgayTaoTaiKhoan { get; set; }
        public int TrangThai { get; set; }

    }
}
