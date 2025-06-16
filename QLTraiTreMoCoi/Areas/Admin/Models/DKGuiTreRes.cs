using System.Drawing;

namespace QLTraiTreMoCoi.Areas.Admin.Models
{
    public class DKGuiTreRes
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string HoTen { get; set; }
        public int HoanCanh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int GioiTinh { get; set; }
    }
}
