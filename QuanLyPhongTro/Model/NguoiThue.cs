using System.ComponentModel.DataAnnotations;

namespace QuanLyPhongTro
{
    public class NguoiThue
    {
        [Key]
        public string MaNgThue { get; set; }
        public string MaPhongTro { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string MatKhau { get; set; }
        public bool GioiTinh { get; set; }
        public string Email { get; set; }
        public DateTime NgaySinh { get; set; }
        public DateTime NgayDK { get; set; }
    }
}
