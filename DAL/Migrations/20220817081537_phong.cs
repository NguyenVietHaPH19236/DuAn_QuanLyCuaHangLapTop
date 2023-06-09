﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class phong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "keyCaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKeyCaps = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_keyCaps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "khachHangs",
                columns: table => new
                {
                    MaKH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachHangs", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "khuyenMais",
                columns: table => new
                {
                    MaKM = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKhuyenMai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChietKhau = table.Column<double>(type: "float", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khuyenMais", x => x.MaKM);
                });

            migrationBuilder.CreateTable(
                name: "mauSacs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaMau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenMau = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mauSacs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nhanViens",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    Vaitro = table.Column<bool>(type: "bit", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanViens", x => x.MaNV);
                });

            migrationBuilder.CreateTable(
                name: "sanPhams",
                columns: table => new
                {
                    MaSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "3970, 1"),
                    TenSP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DonGiaNhap = table.Column<float>(type: "real", nullable: false),
                    DonGiaBan = table.Column<float>(type: "real", nullable: false),
                    DongSP = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhams", x => x.MaSP);
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayLapHD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HinhThucThanhToan = table.Column<int>(type: "int", nullable: true),
                    HinhThucGiaoHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TienKhachDua = table.Column<float>(type: "real", nullable: true),
                    TienTraLai = table.Column<float>(type: "real", nullable: true),
                    TongTienHD = table.Column<float>(type: "real", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaKH = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MaKM = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_hoaDons_khachHangs_MaKH",
                        column: x => x.MaKH,
                        principalTable: "khachHangs",
                        principalColumn: "MaKH");
                    table.ForeignKey(
                        name: "FK_hoaDons_khuyenMais_MaKM",
                        column: x => x.MaKM,
                        principalTable: "khuyenMais",
                        principalColumn: "MaKM");
                    table.ForeignKey(
                        name: "FK_hoaDons_nhanViens_MaNV",
                        column: x => x.MaNV,
                        principalTable: "nhanViens",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "banPhims",
                columns: table => new
                {
                    MaSP = table.Column<int>(type: "int", nullable: false),
                    HangSanXuat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KieuKetNoi = table.Column<int>(type: "int", nullable: false),
                    KieuBanPhim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Led = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Layout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KichThuoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrongLuong = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banPhims", x => x.MaSP);
                    table.ForeignKey(
                        name: "FK_banPhims_sanPhams_MaSP",
                        column: x => x.MaSP,
                        principalTable: "sanPhams",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chuots",
                columns: table => new
                {
                    MaChuot = table.Column<int>(type: "int", nullable: false),
                    KetNoi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IPS = table.Column<int>(type: "int", nullable: false),
                    TanSoPhanHoi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChetLieuVo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrongLuong = table.Column<double>(type: "float", nullable: false),
                    Switch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Led = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaToc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KichThuoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TuoiTho = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chuots", x => x.MaChuot);
                    table.ForeignKey(
                        name: "FK_chuots_sanPhams_MaChuot",
                        column: x => x.MaChuot,
                        principalTable: "sanPhams",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "laptops",
                columns: table => new
                {
                    MaLaptop = table.Column<int>(type: "int", nullable: false),
                    CPU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VGA_Card = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OCung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrongLuong = table.Column<double>(type: "float", nullable: false),
                    ManHinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoPhanGiai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebCam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeDieuHanh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KichThuoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bluetooth = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_laptops", x => x.MaLaptop);
                    table.ForeignKey(
                        name: "FK_laptops_sanPhams_MaLaptop",
                        column: x => x.MaLaptop,
                        principalTable: "sanPhams",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonChiTiets",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaSP = table.Column<int>(type: "int", nullable: false),
                    SoLuongMua = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonChiTiets", x => new { x.MaHD, x.MaSP });
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_hoaDons_MaHD",
                        column: x => x.MaHD,
                        principalTable: "hoaDons",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_sanPhams_MaSP",
                        column: x => x.MaSP,
                        principalTable: "sanPhams",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "banPhimKeyCaps",
                columns: table => new
                {
                    IdKeyCaps = table.Column<int>(type: "int", nullable: false),
                    MaSP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banPhimKeyCaps", x => new { x.IdKeyCaps, x.MaSP });
                    table.ForeignKey(
                        name: "FK_banPhimKeyCaps_banPhims_MaSP",
                        column: x => x.MaSP,
                        principalTable: "banPhims",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_banPhimKeyCaps_keyCaps_IdKeyCaps",
                        column: x => x.IdKeyCaps,
                        principalTable: "keyCaps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "banPhimSoLuongSwitches",
                columns: table => new
                {
                    MaSP = table.Column<int>(type: "int", nullable: false),
                    Switch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banPhimSoLuongSwitches", x => x.MaSP);
                    table.ForeignKey(
                        name: "FK_banPhimSoLuongSwitches_banPhims_MaSP",
                        column: x => x.MaSP,
                        principalTable: "banPhims",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sanPhamMauSacs",
                columns: table => new
                {
                    Idmau = table.Column<int>(type: "int", nullable: false),
                    Masp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhamMauSacs", x => new { x.Masp, x.Idmau });
                    table.ForeignKey(
                        name: "FK_sanPhamMauSacs_banPhims_Masp",
                        column: x => x.Masp,
                        principalTable: "banPhims",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamMauSacs_mauSacs_Idmau",
                        column: x => x.Idmau,
                        principalTable: "mauSacs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_banPhimKeyCaps_MaSP",
                table: "banPhimKeyCaps",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_MaSP",
                table: "hoaDonChiTiets",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_MaKH",
                table: "hoaDons",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_MaKM",
                table: "hoaDons",
                column: "MaKM");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_MaNV",
                table: "hoaDons",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamMauSacs_Idmau",
                table: "sanPhamMauSacs",
                column: "Idmau");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "banPhimKeyCaps");

            migrationBuilder.DropTable(
                name: "banPhimSoLuongSwitches");

            migrationBuilder.DropTable(
                name: "chuots");

            migrationBuilder.DropTable(
                name: "hoaDonChiTiets");

            migrationBuilder.DropTable(
                name: "laptops");

            migrationBuilder.DropTable(
                name: "sanPhamMauSacs");

            migrationBuilder.DropTable(
                name: "keyCaps");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "banPhims");

            migrationBuilder.DropTable(
                name: "mauSacs");

            migrationBuilder.DropTable(
                name: "khachHangs");

            migrationBuilder.DropTable(
                name: "khuyenMais");

            migrationBuilder.DropTable(
                name: "nhanViens");

            migrationBuilder.DropTable(
                name: "sanPhams");
        }
    }
}
