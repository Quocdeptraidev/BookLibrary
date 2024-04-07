﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnLapTrinhWeb.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbLoaiDanhDau",
                columns: table => new
                {
                    MaLoaiDanhDau = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDanhDau = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbLoaiDanhDau", x => x.MaLoaiDanhDau);
                });

            migrationBuilder.CreateTable(
                name: "tbTacGia",
                columns: table => new
                {
                    TacGiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTacGia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbTacGia", x => x.TacGiaId);
                });

            migrationBuilder.CreateTable(
                name: "tbTheLoai",
                columns: table => new
                {
                    maTheLoai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenTheLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbTheLoai", x => x.maTheLoai);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbSach",
                columns: table => new
                {
                    sachId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenSach = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    fileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tacGiaId = table.Column<int>(type: "int", nullable: false),
                    tbTacGiaTacGiaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbSach", x => x.sachId);
                    table.ForeignKey(
                        name: "FK_tbSach_tbTacGia_tbTacGiaTacGiaId",
                        column: x => x.tbTacGiaTacGiaId,
                        principalTable: "tbTacGia",
                        principalColumn: "TacGiaId");
                });

            migrationBuilder.CreateTable(
                name: "tbChiTietDanhDau",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sachId = table.Column<int>(type: "int", nullable: false),
                    tbSachsachId = table.Column<int>(type: "int", nullable: false),
                    maLoaiDanhDau = table.Column<int>(type: "int", nullable: false),
                    tbLoaiDanhDauMaLoaiDanhDau = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbChiTietDanhDau", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbChiTietDanhDau_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbChiTietDanhDau_tbLoaiDanhDau_tbLoaiDanhDauMaLoaiDanhDau",
                        column: x => x.tbLoaiDanhDauMaLoaiDanhDau,
                        principalTable: "tbLoaiDanhDau",
                        principalColumn: "MaLoaiDanhDau",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbChiTietDanhDau_tbSach_tbSachsachId",
                        column: x => x.tbSachsachId,
                        principalTable: "tbSach",
                        principalColumn: "sachId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbChiTietTheLoai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sachId = table.Column<int>(type: "int", nullable: false),
                    tbSachsachId = table.Column<int>(type: "int", nullable: true),
                    maTheLoai = table.Column<int>(type: "int", nullable: false),
                    tbTheLoaimaTheLoai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbChiTietTheLoai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbChiTietTheLoai_tbSach_tbSachsachId",
                        column: x => x.tbSachsachId,
                        principalTable: "tbSach",
                        principalColumn: "sachId");
                    table.ForeignKey(
                        name: "FK_tbChiTietTheLoai_tbTheLoai_tbTheLoaimaTheLoai",
                        column: x => x.tbTheLoaimaTheLoai,
                        principalTable: "tbTheLoai",
                        principalColumn: "maTheLoai");
                });

            migrationBuilder.CreateTable(
                name: "tbLichSu",
                columns: table => new
                {
                    lichSuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    thoiGianDoc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sachId = table.Column<int>(type: "int", nullable: false),
                    tbSachsachId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbLichSu", x => x.lichSuId);
                    table.ForeignKey(
                        name: "FK_tbLichSu_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbLichSu_tbSach_tbSachsachId",
                        column: x => x.tbSachsachId,
                        principalTable: "tbSach",
                        principalColumn: "sachId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbPhieuDanhGia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sachId = table.Column<int>(type: "int", nullable: false),
                    tbSachsachId = table.Column<int>(type: "int", nullable: false),
                    diem = table.Column<long>(type: "bigint", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPhieuDanhGia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbPhieuDanhGia_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbPhieuDanhGia_tbSach_tbSachsachId",
                        column: x => x.tbSachsachId,
                        principalTable: "tbSach",
                        principalColumn: "sachId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tbChiTietDanhDau_tbLoaiDanhDauMaLoaiDanhDau",
                table: "tbChiTietDanhDau",
                column: "tbLoaiDanhDauMaLoaiDanhDau");

            migrationBuilder.CreateIndex(
                name: "IX_tbChiTietDanhDau_tbSachsachId",
                table: "tbChiTietDanhDau",
                column: "tbSachsachId");

            migrationBuilder.CreateIndex(
                name: "IX_tbChiTietDanhDau_userId",
                table: "tbChiTietDanhDau",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_tbChiTietTheLoai_tbSachsachId",
                table: "tbChiTietTheLoai",
                column: "tbSachsachId");

            migrationBuilder.CreateIndex(
                name: "IX_tbChiTietTheLoai_tbTheLoaimaTheLoai",
                table: "tbChiTietTheLoai",
                column: "tbTheLoaimaTheLoai");

            migrationBuilder.CreateIndex(
                name: "IX_tbLichSu_tbSachsachId",
                table: "tbLichSu",
                column: "tbSachsachId");

            migrationBuilder.CreateIndex(
                name: "IX_tbLichSu_userId",
                table: "tbLichSu",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_tbPhieuDanhGia_tbSachsachId",
                table: "tbPhieuDanhGia",
                column: "tbSachsachId");

            migrationBuilder.CreateIndex(
                name: "IX_tbPhieuDanhGia_userId",
                table: "tbPhieuDanhGia",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_tbSach_tbTacGiaTacGiaId",
                table: "tbSach",
                column: "tbTacGiaTacGiaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "tbChiTietDanhDau");

            migrationBuilder.DropTable(
                name: "tbChiTietTheLoai");

            migrationBuilder.DropTable(
                name: "tbLichSu");

            migrationBuilder.DropTable(
                name: "tbPhieuDanhGia");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "tbLoaiDanhDau");

            migrationBuilder.DropTable(
                name: "tbTheLoai");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "tbSach");

            migrationBuilder.DropTable(
                name: "tbTacGia");
        }
    }
}
