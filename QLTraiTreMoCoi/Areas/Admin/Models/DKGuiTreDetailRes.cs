using QLTraiTreMoCoi.Models;

namespace QLTraiTreMoCoi.Areas.Admin.Models
{
    public class DKGuiTreDetailRes
    {
        public int Id { get; set; }
        public string TenNguoiGui { get; set; }

        public DateTime NgayDangKy { get; set; }

        public int TrangThai { get; set; }

        public DateTime? NgayTiepNhanTre { get; set; }

        public string HoTenTre { get; set; }

        public DateTime NgaySinhTre { get; set; }

        public int GioiTinhTre { get; set; }

        public string DanTocTre { get; set; }

        public string UrlAnh { get; set; }

        public int HoanCanh { get; set; }

        public int QuanHeVoiNguoiGui { get; set; }
    }
}
