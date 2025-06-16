using QLTraiTreMoCoi.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class LSCapNhatHoSoTre
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int TreId { get; set; }

    [ForeignKey("TreId")]
    public ThongTinTre ThongTinTre { get; set; } // Dùng đúng tên entity để tránh sinh cột phụ

    [Required]
    public string NguoiDungId { get; set; }

    [ForeignKey("NguoiDungId")]
    public NguoiDung NguoiDung { get; set; }

    public DateTime ThoiGian { get; set; }

    public string? NoiDungCapNhat { get; set; }
}
