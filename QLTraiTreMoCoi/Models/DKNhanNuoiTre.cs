using QLTraiTreMoCoi.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class DKNhanNuoiTre
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string NguoiDungId { get; set; }

    [ForeignKey("NguoiDungId")]
    public NguoiDung NguoiDung { get; set; }

    [Required]
    public int TreId { get; set; }

    [ForeignKey("TreId")]
    public ThongTinTre ThongTinTre { get; set; }

    public DateTime NgayDangKy { get; set; }

    public int TrangThai { get; set; }
}
