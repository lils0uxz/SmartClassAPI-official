﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartClassAPI.Data;

namespace SmartClassAPI.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20221210034759_V5")]
    partial class V5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmartClassAPI.Data.LopHoc", b =>
                {
                    b.Property<int>("IdLopHoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaLopHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLopHoc");

                    b.ToTable("LopHoc");
                });

            modelBuilder.Entity("SmartClassAPI.Data.MonHoc", b =>
                {
                    b.Property<int>("IdMonHoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdLopHoc")
                        .HasColumnType("int");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoTiet")
                        .HasColumnType("int");

                    b.Property<string>("TenMonHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMonHoc");

                    b.HasIndex("IdLopHoc");

                    b.HasIndex("IdUser");

                    b.ToTable("MonHoc");
                });

            modelBuilder.Entity("SmartClassAPI.Data.TaiLieuHocTap", b =>
                {
                    b.Property<int>("IdTaiLieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdMonHoc")
                        .HasColumnType("int");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("TenTaiLieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlTaiLieu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTaiLieu");

                    b.HasIndex("IdMonHoc");

                    b.HasIndex("IdUser");

                    b.ToTable("TaiLieuHocTap");
                });

            modelBuilder.Entity("SmartClassAPI.Data.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("Nvarchar(200)");

                    b.Property<int?>("IdHocSinh")
                        .HasColumnType("int");

                    b.Property<int?>("IdLopHoc")
                        .HasColumnType("int");

                    b.Property<int>("LoaiUser")
                        .HasColumnType("int");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdUser");

                    b.HasIndex("IdLopHoc");

                    b.ToTable("User");
                });

            modelBuilder.Entity("SmartClassAPI.Data.MonHoc", b =>
                {
                    b.HasOne("SmartClassAPI.Data.LopHoc", "LopHoc")
                        .WithMany("MonHocs")
                        .HasForeignKey("IdLopHoc");

                    b.HasOne("SmartClassAPI.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser");

                    b.Navigation("LopHoc");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartClassAPI.Data.TaiLieuHocTap", b =>
                {
                    b.HasOne("SmartClassAPI.Data.MonHoc", "MonHoc")
                        .WithMany()
                        .HasForeignKey("IdMonHoc");

                    b.HasOne("SmartClassAPI.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser");

                    b.Navigation("MonHoc");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartClassAPI.Data.User", b =>
                {
                    b.HasOne("SmartClassAPI.Data.LopHoc", "LopHoc")
                        .WithMany("Users")
                        .HasForeignKey("IdLopHoc");

                    b.Navigation("LopHoc");
                });

            modelBuilder.Entity("SmartClassAPI.Data.LopHoc", b =>
                {
                    b.Navigation("MonHocs");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
