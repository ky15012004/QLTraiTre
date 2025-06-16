using System.ComponentModel.DataAnnotations;

namespace QLTraiTreMoCoi.Models
{
    public class ThongTinTre
    {
        [Key]
        public int Id {  get; set; }
        public string HoTen {  get; set; }
        public DateTime? NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string DanToc {  get; set; }
        public string UrlAnh {  get; set; }
        public DateTime? NgayRoiTrai { get; set; }
        public int TrangThai {  get; set; }
        public int HoanCanh { get; set; }

        public ICollection<DKNhanNuoiTre> DKNhanNuoiTres { get; set; }
        public ICollection<LSCapNhatHoSoTre> CapNhatHoSoTres { get; set; }
    }
}
