using System.ComponentModel.DataAnnotations;

namespace QLTraiTreMoCoi.Models
{
    public class ThongTinTre
    {
        [Key]
        public int Matre {  get; set; }
        public string HoTen {  get; set; }
        public DateTime? NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string DanToc {  get; set; }
        public string UrlAnh {  get; set; }
        public DateTime? NgayRoiTrai { get; set; }
        public int TrangThai {  get; set; }
        public int HoanCanh { get; set; }
    }
}
