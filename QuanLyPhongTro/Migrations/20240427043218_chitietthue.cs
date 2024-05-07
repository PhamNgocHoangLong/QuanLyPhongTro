using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyPhongTro.Migrations
{
    /// <inheritdoc />
    public partial class chitietthue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiTietThue",
                columns: table => new
                {
                    MaChiTietThue = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaChuTro = table.Column<int>(type: "int", nullable: false),
                    MaNguoiThue = table.Column<int>(type: "int", nullable: false),
                    ThoiGianThue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChiThue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietThue", x => x.MaChiTietThue);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietThue");
        }
    }
}
