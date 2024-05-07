using System.ComponentModel.DataAnnotations;

namespace QuanLyPhongTro
{
    public class NguoiThue
    {
        [Key]
        public int IdNguoiThue { get; set; }

        public string MaPhongTro { get; set; }

        public string HoVaTen { get; set; }

        public string Sdt {  get; set; }

        public bool GioiTinh { get; set; }

        public string email { get; set; }

        public DateTime NgaySinh { get; set; }

        public DateTime NgayDK {  get; set; }
    }
}
