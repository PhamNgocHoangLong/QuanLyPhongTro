using System.ComponentModel.DataAnnotations;

namespace QuanLyPhongTro
{
    public class DanhGia
    {
        
        [Key]
      
        public string MaDanhGia { get; set; }
        public DateTime NgayDanhGia { get; set; }
        public string NoiDung { get; set; }
        public string MaNgThue { get; set; }
        public string MaPhongTro { get; set; }
    }
}
