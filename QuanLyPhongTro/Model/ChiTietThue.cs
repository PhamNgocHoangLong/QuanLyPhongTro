using System.ComponentModel.DataAnnotations;

namespace QuanLyPhongTro
{
    public class ChiTietThue
    {
        [Key]
        public string MaChiTietThue { get; set; }

        public string MaPhong { get; set; }

        public string MaNgThue { get; set; }

        public DateTime ThoiGianThue { get; set; }
        public string DiaChiThue { get; set; }

    }
}
