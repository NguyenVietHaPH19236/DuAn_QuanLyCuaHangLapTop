﻿// <auto-generated />
using System;
using DAL.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(DA1Context))]
    [Migration("20220816135838_ha")]
    partial class ha
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL.Model.BanPhim", b =>
                {
                    b.Property<int>("MaSP")
                        .HasColumnType("int");

                    b.Property<string>("HangSanXuat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KichThuoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KieuBanPhim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KieuKetNoi")
                        .HasColumnType("int");

                    b.Property<string>("Layout")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Led")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TrongLuong")
                        .HasColumnType("float");

                    b.HasKey("MaSP");

                    b.ToTable("banPhims");
                });

            modelBuilder.Entity("DAL.Model.BanPhimKeyCaps", b =>
                {
                    b.Property<int>("IdKeyCaps")
                        .HasColumnType("int");

                    b.Property<int>("MaSP")
                        .HasColumnType("int");

                    b.HasKey("IdKeyCaps", "MaSP");

                    b.HasIndex("MaSP");

                    b.ToTable("banPhimKeyCaps");
                });

            modelBuilder.Entity("DAL.Model.BanPhimSoLuongSwitch", b =>
                {
                    b.Property<int>("MaSP")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("Switch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaSP");

                    b.ToTable("banPhimSoLuongSwitches");
                });

            modelBuilder.Entity("DAL.Model.Chuot", b =>
                {
                    b.Property<int>("MaChuot")
                        .HasColumnType("int");

                    b.Property<string>("ChetLieuVo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GiaToc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IPS")
                        .HasColumnType("int");

                    b.Property<string>("KetNoi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KichThuoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Led")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Switch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TanSoPhanHoi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TrongLuong")
                        .HasColumnType("float");

                    b.Property<string>("TuoiTho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaChuot");

                    b.ToTable("chuots");
                });

            modelBuilder.Entity("DAL.Model.HoaDon", b =>
                {
                    b.Property<string>("MaHD")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhThucGiaoHang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HinhThucThanhToan")
                        .HasColumnType("int");

                    b.Property<string>("MaKH")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaKM")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgayLapHD")
                        .HasColumnType("datetime2");

                    b.Property<float?>("TienKhachDua")
                        .HasColumnType("real");

                    b.Property<float?>("TienTraLai")
                        .HasColumnType("real");

                    b.Property<float?>("TongTienHD")
                        .HasColumnType("real");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaHD");

                    b.HasIndex("MaKH");

                    b.HasIndex("MaKM");

                    b.HasIndex("MaNV");

                    b.ToTable("hoaDons");
                });

            modelBuilder.Entity("DAL.Model.HoaDonChiTiet", b =>
                {
                    b.Property<string>("MaHD")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MaSP")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongMua")
                        .HasColumnType("int");

                    b.HasKey("MaHD", "MaSP");

                    b.HasIndex("MaSP");

                    b.ToTable("hoaDonChiTiets");
                });

            modelBuilder.Entity("DAL.Model.KeyCaps", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TenKeyCaps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("keyCaps");
                });

            modelBuilder.Entity("DAL.Model.KhachHang", b =>
                {
                    b.Property<string>("MaKH")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaKH");

                    b.ToTable("khachHangs");
                });

            modelBuilder.Entity("DAL.Model.KhuyenMai", b =>
                {
                    b.Property<string>("MaKM")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("ChietKhau")
                        .HasColumnType("float");

                    b.Property<string>("Mota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenKhuyenMai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaKM");

                    b.ToTable("khuyenMais");
                });

            modelBuilder.Entity("DAL.Model.Laptop", b =>
                {
                    b.Property<int>("MaLaptop")
                        .HasColumnType("int");

                    b.Property<string>("Bluetooth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoPhanGiai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeDieuHanh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KichThuoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManHinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OCung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TrongLuong")
                        .HasColumnType("float");

                    b.Property<string>("VGA_Card")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebCam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLaptop");

                    b.ToTable("laptops");
                });

            modelBuilder.Entity("DAL.Model.MauSac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MaMau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenMau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("mauSacs");
                });

            modelBuilder.Entity("DAL.Model.NhanVien", b =>
                {
                    b.Property<string>("MaNV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<bool>("Vaitro")
                        .HasColumnType("bit");

                    b.HasKey("MaNV");

                    b.ToTable("nhanViens");
                });

            modelBuilder.Entity("DAL.Model.SanPham", b =>
                {
                    b.Property<int>("MaSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaSP"), 3970L, 1);

                    b.Property<float>("DonGiaBan")
                        .HasColumnType("real");

                    b.Property<float>("DonGiaNhap")
                        .HasColumnType("real");

                    b.Property<int>("DongSP")
                        .HasColumnType("int");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaSP");

                    b.ToTable("sanPhams");
                });

            modelBuilder.Entity("DAL.Model.SanPhamMauSac", b =>
                {
                    b.Property<int>("Masp")
                        .HasColumnType("int");

                    b.Property<int>("Idmau")
                        .HasColumnType("int");

                    b.HasKey("Masp", "Idmau");

                    b.HasIndex("Idmau");

                    b.ToTable("sanPhamMauSacs");
                });

            modelBuilder.Entity("DAL.Model.BanPhim", b =>
                {
                    b.HasOne("DAL.Model.SanPham", "sanPham")
                        .WithOne("banPhim")
                        .HasForeignKey("DAL.Model.BanPhim", "MaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sanPham");
                });

            modelBuilder.Entity("DAL.Model.BanPhimKeyCaps", b =>
                {
                    b.HasOne("DAL.Model.KeyCaps", "keyCaps")
                        .WithMany("banPhimKeyCaps")
                        .HasForeignKey("IdKeyCaps")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Model.BanPhim", "banPhim")
                        .WithMany("banPhimKeyCaps")
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("banPhim");

                    b.Navigation("keyCaps");
                });

            modelBuilder.Entity("DAL.Model.BanPhimSoLuongSwitch", b =>
                {
                    b.HasOne("DAL.Model.BanPhim", "banPhim")
                        .WithMany("banPhimSoLuongSwitches")
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("banPhim");
                });

            modelBuilder.Entity("DAL.Model.Chuot", b =>
                {
                    b.HasOne("DAL.Model.SanPham", "sanPham")
                        .WithOne("chuot")
                        .HasForeignKey("DAL.Model.Chuot", "MaChuot")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sanPham");
                });

            modelBuilder.Entity("DAL.Model.HoaDon", b =>
                {
                    b.HasOne("DAL.Model.KhachHang", "khachHang")
                        .WithMany("hoaDons")
                        .HasForeignKey("MaKH");

                    b.HasOne("DAL.Model.KhuyenMai", "khuyenMai")
                        .WithMany("hoaDons")
                        .HasForeignKey("MaKM");

                    b.HasOne("DAL.Model.NhanVien", "NhanVien")
                        .WithMany("hoaDons")
                        .HasForeignKey("MaNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanVien");

                    b.Navigation("khachHang");

                    b.Navigation("khuyenMai");
                });

            modelBuilder.Entity("DAL.Model.HoaDonChiTiet", b =>
                {
                    b.HasOne("DAL.Model.HoaDon", "hoaDon")
                        .WithMany("hoadonchitiets")
                        .HasForeignKey("MaHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Model.SanPham", "sanPham")
                        .WithMany("hoaDonChiTiets")
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hoaDon");

                    b.Navigation("sanPham");
                });

            modelBuilder.Entity("DAL.Model.Laptop", b =>
                {
                    b.HasOne("DAL.Model.SanPham", "sanPham")
                        .WithOne("laptop")
                        .HasForeignKey("DAL.Model.Laptop", "MaLaptop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sanPham");
                });

            modelBuilder.Entity("DAL.Model.SanPhamMauSac", b =>
                {
                    b.HasOne("DAL.Model.MauSac", "mausac")
                        .WithMany("sanPhamMauSacs")
                        .HasForeignKey("Idmau")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Model.BanPhim", "banphim")
                        .WithMany("sanPhamMauSacs")
                        .HasForeignKey("Masp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("banphim");

                    b.Navigation("mausac");
                });

            modelBuilder.Entity("DAL.Model.BanPhim", b =>
                {
                    b.Navigation("banPhimKeyCaps");

                    b.Navigation("banPhimSoLuongSwitches");

                    b.Navigation("sanPhamMauSacs");
                });

            modelBuilder.Entity("DAL.Model.HoaDon", b =>
                {
                    b.Navigation("hoadonchitiets");
                });

            modelBuilder.Entity("DAL.Model.KeyCaps", b =>
                {
                    b.Navigation("banPhimKeyCaps");
                });

            modelBuilder.Entity("DAL.Model.KhachHang", b =>
                {
                    b.Navigation("hoaDons");
                });

            modelBuilder.Entity("DAL.Model.KhuyenMai", b =>
                {
                    b.Navigation("hoaDons");
                });

            modelBuilder.Entity("DAL.Model.MauSac", b =>
                {
                    b.Navigation("sanPhamMauSacs");
                });

            modelBuilder.Entity("DAL.Model.NhanVien", b =>
                {
                    b.Navigation("hoaDons");
                });

            modelBuilder.Entity("DAL.Model.SanPham", b =>
                {
                    b.Navigation("banPhim")
                        .IsRequired();

                    b.Navigation("chuot")
                        .IsRequired();

                    b.Navigation("hoaDonChiTiets");

                    b.Navigation("laptop")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
