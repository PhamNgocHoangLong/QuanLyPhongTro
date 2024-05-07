﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyPhongTro.Data;

#nullable disable

namespace QuanLyPhongTro.Migrations
{
    [DbContext(typeof(QuanLyPhongTroContext))]
    [Migration("20240427041321_phongtro")]
    partial class phongtro
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuanLyPhongTro.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("QuanLyPhongTro.NguoiThue", b =>
                {
                    b.Property<int>("IdNguoiThue")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdNguoiThue"));

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("HoVaTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaPhongTro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayDK")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdNguoiThue");

                    b.ToTable("NguoiThue");
                });

            modelBuilder.Entity("QuanLyPhongTro.PhongTro", b =>
                {
                    b.Property<int>("MaPhongTro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaPhongTro"));

                    b.Property<string>("ChiTiet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChiTro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DienTich")
                        .HasColumnType("int");

                    b.Property<int>("Gia")
                        .HasColumnType("int");

                    b.Property<int>("MaChuTro")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayDang")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenChuTro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaPhongTro");

                    b.ToTable("PhongTro");
                });
#pragma warning restore 612, 618
        }
    }
}
