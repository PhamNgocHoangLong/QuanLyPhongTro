using System.ComponentModel.DataAnnotations;

namespace QuanLyPhongTro
{
    public class PhongTro
    {
        [Key]
        public int MaPhongTro { get; set; }

        public int MaChuTro { get; set; }

        public string TenChuTro { get; set; }

        public string DiaChiTro { get; set; }

        public bool TrangThai {  get; set; }

        public int DienTich { get; set; }

        public int Gia {  get; set; }

        public DateTime NgayDang { get; set; }

        public string ChiTiet { get; set; }
    }
}
