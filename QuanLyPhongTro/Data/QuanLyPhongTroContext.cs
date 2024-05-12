using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLyPhongTro;

namespace QuanLyPhongTro.Data
{
    public class QuanLyPhongTroContext : DbContext
    {
        public QuanLyPhongTroContext (DbContextOptions<QuanLyPhongTroContext> options)
            : base(options)
        {
        }

        public DbSet<QuanLyPhongTro.ChuTro> ChuTro { get; set; } = default!;
        public DbSet<QuanLyPhongTro.Blog> Blog { get; set; } = default!;
        public DbSet<QuanLyPhongTro.NguoiThue> NguoiThue { get; set; } = default!;
        public DbSet<QuanLyPhongTro.PhongTro> PhongTro { get; set; } = default!;
        public DbSet<QuanLyPhongTro.ChiTietThue> ChiTietThue { get; set; } = default!;
        public DbSet<QuanLyPhongTro.ThanhToan> ThanhToan { get; set; } = default!;
        public DbSet<QuanLyPhongTro.DanhGia> DanhGia { get; set; } = default!;
    }
}
