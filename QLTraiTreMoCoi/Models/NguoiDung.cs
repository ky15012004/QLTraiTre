using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace QLTraiTreMoCoi.Models
{
    public class NguoiDung : IdentityUser
    {
        public string CCCD { get; set; }
        public string HoTen { get; set; }
        public string? Dantoc { get; set; }
        public string? SDT { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int? GioiTinh { get; set; }
        public string? UrlAnh { get; set; }
        public string? DiaChi { get; set; }
        public string NgayTaoTaiKhoan { get; set; } = DateTime.Now.ToString();
        public int TrangThai { get; set; } = 1;

        public ICollection<DKGuiTre> DKGuiTres { get; set; } 
        public ICollection<DKNhanNuoiTre> DKNhanNuoiTres { get; set; }
        public ICollection<LSCapNhatHoSoTre> CapNhatHoSoTres { get; set; }

    }
}
