using System.ComponentModel.DataAnnotations;

namespace QuanLyPhongTro
{
    public class ThanhToan
    {
        [Key]
        public int MaThanhToan { get; set; }

        public int MaPhongTro { get; set; }

        public DateTime NgayTraTien { get; set; }

        public int SoTien { get; set; }

        public string PhuongThucTT { get; set; }
    }
}
