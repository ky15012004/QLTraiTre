using System.ComponentModel.DataAnnotations;

namespace QLTraiTreMoCoi.Areas.User.Models
{
    public class RegisterChildReq
    {
        public string? MaNguoiDung { get; set; }
        public DateTime NgayDangKy { get; set; } = DateTime.Now;
        public int TrangThai { get; set; } = 0;
        public DateTime? NgayTiepNhanTre { get; set; }
        [Required(ErrorMessage = "HoTenTre is required!")]
        public string HoTenTre { get; set; }
        [Required(ErrorMessage = "NgaySinhTre is required!")]
        public DateTime NgaySinhTre { get; set; }
        [Required(ErrorMessage = "GioiTinhTre is required!")]
        public int GioiTinhTre { get; set; }
        [Required(ErrorMessage = "DanTocTre is required!")]
        public string DanTocTre { get; set; }
        public string? UrlAnh { get; set; }
        [Required(ErrorMessage = "HoanCanh is required!")]
        public int HoanCanh { get; set; }
        [Required(ErrorMessage = "QuanHeVoiNguoiGui is required!")]
        public int QuanHeVoiNguoiGui { get; set; }
    }
}
