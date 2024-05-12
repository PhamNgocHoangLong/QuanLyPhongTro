using System.ComponentModel.DataAnnotations;

namespace QuanLyPhongTro
{
    public class PhongTro
    {
        
        [Key]
        public string MaPhongTro { get; set; }

        public string MaCT { get; set; }

        public string DiaChi { get; set; }

        public bool TrangThai { get; set; }

        public string DienTich { get; set; }

        public string Gia { get; set; }

        public DateTime NgayDang { get; set; }

        public string MoTa { get; set; }
    }
}
