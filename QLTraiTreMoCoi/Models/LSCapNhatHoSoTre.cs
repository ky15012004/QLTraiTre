using System.ComponentModel.DataAnnotations;

namespace QLTraiTreMoCoi.Models
{
    public class LSCapNhatHoSoTre
    {
        [Key]
        public int MaCapNhatHoSo {  get; set; }
        public int Matre {  get; set; }
        public string MaNguoiDung { get; set; }
        public  DateTime ThoiGian {  get; set; }
        public string? NoiDungCapNhat {  get; set; }
    }
}
