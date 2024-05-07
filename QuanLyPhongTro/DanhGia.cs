using System.ComponentModel.DataAnnotations;

namespace QuanLyPhongTro
{
    public class DanhGia
    {
        [Key]
        public int MaDanhGia { get; set; }

        public DateTime NgayDanhGia { get; set; }

        public string NoiDung { get; set; }

        public int MaNguoiDanhGia { get; set; }

        public int MaPhongTro { get; set; }
    }
}
