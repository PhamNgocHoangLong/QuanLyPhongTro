using System.ComponentModel.DataAnnotations;

namespace QuanLyPhongTro
{
    public class ThanhToan
    {
        
        [Key]
        
        public string MaTT { get; set; }
        public string MaChiTietThue { get; set; }
        public DateTime NgayTT { get; set; }
        public int TongTien { get; set; }
        public string PhuongThucTT { get; set; }
    }
}
