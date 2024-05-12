using System.ComponentModel.DataAnnotations;

namespace QuanLyPhongTro;

public class ChuTro
{
    [Key]
    public string MaCT { get; set; }

    public string HoTen { get; set; }

    public string SDT { get; set; }

    public string MatKhau { get; set; }

    public string GioiTinh { get; set; }

    public string Email { get; set; }

    public DateTime NgaySinh { get; set; }

    public DateTime NgayDK { get; set; }

    public int SLgTro { get; set; }
}