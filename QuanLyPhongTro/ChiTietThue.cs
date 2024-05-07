using System.ComponentModel.DataAnnotations;

namespace QuanLyPhongTro
{
    public class ChiTietThue
    {
        [Key]
        public int MaChiTietThue { get; set; }

        public int MaChuTro { get; set; }

        public int MaNguoiThue { get; set; }

        public DateTime ThoiGianThue { get; set; }

        public string DiaChiThue { get; set; }
    }
}
