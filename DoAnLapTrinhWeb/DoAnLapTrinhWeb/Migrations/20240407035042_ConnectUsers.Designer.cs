﻿// <auto-generated />
using System;
using DoAnLapTrinhWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoAnLapTrinhWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240407035042_ConnectUsers")]
    partial class ConnectUsers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoAnLapTrinhWeb.Models.tbChiTietDanhDau", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("maLoaiDanhDau")
                        .HasColumnType("int");

                    b.Property<int>("sachId")
                        .HasColumnType("int");

                    b.Property<int>("tbLoaiDanhDauMaLoaiDanhDau")
                        .HasColumnType("int");

                    b.Property<int>("tbSachsachId")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("tbLoaiDanhDauMaLoaiDanhDau");

                    b.HasIndex("tbSachsachId");

                    b.HasIndex("userId");

                    b.ToTable("tbChiTietDanhDau");
                });

            modelBuilder.Entity("DoAnLapTrinhWeb.Models.tbChiTietTheLoai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("maTheLoai")
                        .HasColumnType("int");

                    b.Property<int>("sachId")
                        .HasColumnType("int");

                    b.Property<int?>("tbSachsachId")
                        .HasColumnType("int");

                    b.Property<int?>("tbTheLoaimaTheLoai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("tbSachsachId");

                    b.HasIndex("tbTheLoaimaTheLoai");

                    b.ToTable("tbChiTietTheLoai");
                });

            modelBuilder.Entity("DoAnLapTrinhWeb.Models.tbLichSu", b =>
                {
                    b.Property<int>("lichSuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("lichSuId"));

                    b.Property<int>("sachId")
                        .HasColumnType("int");

                    b.Property<int>("tbSachsachId")
                        .HasColumnType("int");

                    b.Property<DateTime>("thoiGianDoc")
                        .HasColumnType("datetime2");

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("lichSuId");

                    b.HasIndex("tbSachsachId");

                    b.HasIndex("userId");

                    b.ToTable("tbLichSu");
                });

            modelBuilder.Entity("DoAnLapTrinhWeb.Models.tbLoaiDanhDau", b =>
                {
                    b.Property<int>("MaLoaiDanhDau")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLoaiDanhDau"));

                    b.Property<string>("TenDanhDau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLoaiDanhDau");

                    b.ToTable("tbLoaiDanhDau");
                });

            modelBuilder.Entity("DoAnLapTrinhWeb.Models.tbPhieuDanhGia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long>("diem")
                        .HasColumnType("bigint");

                    b.Property<int>("sachId")
                        .HasColumnType("int");

                    b.Property<int>("tbSachsachId")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("tbSachsachId");

                    b.HasIndex("userId");

                    b.ToTable("tbPhieuDanhGia");
                });

            modelBuilder.Entity("DoAnLapTrinhWeb.Models.tbSach", b =>
                {
                    b.Property<int>("sachId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("sachId"));

                    b.Property<string>("fileUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tacGiaId")
                        .HasColumnType("int");

                    b.Property<int?>("tbTacGiaTacGiaId")
                        .HasColumnType("int");

                    b.Property<string>("tenSach")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("sachId");

                    b.HasIndex("tbTacGiaTacGiaId");

                    b.ToTable("tbSach");
                });

            modelBuilder.Entity("DoAnLapTrinhWeb.Models.tbTacGia", b =>
                {
                    b.Property<int>("TacGiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TacGiaId"));

                    b.Property<string>("TenTacGia")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TacGiaId");

                    b.ToTable("tbTacGia");
                });

            modelBuilder.Entity("DoAnLapTrinhWeb.Models.tbTheLoai", b =>
                {
                    b.Property<int>("maTheLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("maTheLoai"));

                    b.Property<string>("tenTheLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("maTheLoai");

                    b.ToTable("tbTheLoai");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DoAnLapTrinhWeb.Models.tbChiTietDanhDau", b =>
                {
                    b.HasOne("DoAnLapTrinhWeb.Models.tbLoaiDanhDau", "tbLoaiDanhDau")
                        .WithMany("chiTietDanhDaus")
                        .HasForeignKey("tbLoaiDanhDauMaLoaiDanhDau")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoAnLapTrinhWeb.Models.tbSach", "tbSach")
                        .WithMany("chiTietDanhDaus")
                        .HasForeignKey("tbSachsachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("tbLoaiDanhDau");

                    b.Navigation("tbSach");
                });

            modelBuilder.Entity("DoAnLapTrinhWeb.Models.tbChiTietTheLoai", b =>
                {
                    b.HasOne("DoAnLapTrinhWeb.Models.tbSach", "tbSach")
                        .WithMany("chiTietTheLoais")
                        .HasForeignKey("tbSachsachId");

                    b.HasOne("DoAnLapTrinhWeb.Models.tbTheLoai", "tbTheLoai")
                        .WithMany("chiTietTheLoais")
                        .HasForeignKey("tbTheLoaimaTheLoai");

                    b.Navigation("tbSach");

                    b.Navigation("tbTheLoai");
                });

            modelBuilder.Entity("DoAnLapTrinhWeb.Models.tbLichSu", b =>
                {
                    b.HasOne("DoAnLapTrinhWeb.Models.tbSach", "tbSach")
                        .WithMany("lichSus")
                        .HasForeignKey("tbSachsachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("tbSach");
                });

            modelBuilder.Entity("DoAnLapTrinhWeb.Models.tbPhieuDanhGia", b =>
                {
                    b.HasOne("DoAnLapTrinhWeb.Models.tbSach", "tbSach")
                        .WithMany("phieuDanhGias")
                        .HasForeignKey("tbSachsachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("tbSach");
                });

            modelBuilder.Entity("DoAnLapTrinhWeb.Models.tbSach", b =>
                {
                    b.HasOne("DoAnLapTrinhWeb.Models.tbTacGia", "tbTacGia")
                        .WithMany("Saches")
                        .HasForeignKey("tbTacGiaTacGiaId");

                    b.Navigation("tbTacGia");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoAnLapTrinhWeb.Models.tbLoaiDanhDau", b =>
                {
                    b.Navigation("chiTietDanhDaus");
                });

            modelBuilder.Entity("DoAnLapTrinhWeb.Models.tbSach", b =>
                {
                    b.Navigation("chiTietDanhDaus");

                    b.Navigation("chiTietTheLoais");

                    b.Navigation("lichSus");

                    b.Navigation("phieuDanhGias");
                });

            modelBuilder.Entity("DoAnLapTrinhWeb.Models.tbTacGia", b =>
                {
                    b.Navigation("Saches");
                });

            modelBuilder.Entity("DoAnLapTrinhWeb.Models.tbTheLoai", b =>
                {
                    b.Navigation("chiTietTheLoais");
                });
#pragma warning restore 612, 618
        }
    }
}
