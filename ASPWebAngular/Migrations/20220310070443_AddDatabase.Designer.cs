﻿// <auto-generated />
using System;
using ASPWebAngular.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPWebAngular.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220310070443_AddDatabase")]
    partial class AddDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASPWebAngular.Model.Customer", b =>
                {
                    b.Property<int>("MaKh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaKh"), 1L, 1);

                    b.Property<string>("Diachi")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LoaiKH")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Sodienthoai")
                        .IsRequired()
                        .HasColumnType("varchar(12)");

                    b.Property<string>("TenKh")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("MaKh");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ASPWebAngular.Model.Manufacture", b =>
                {
                    b.Property<int>("MaNCC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaNCC"), 1L, 1);

                    b.Property<string>("Diachi")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Sodienthoai")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TenNCC")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("MaNCC");

                    b.ToTable("Manufactures");
                });

            modelBuilder.Entity("ASPWebAngular.Model.Product", b =>
                {
                    b.Property<int>("MaSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaSP"), 1L, 1);

                    b.Property<DateTime>("NgayNhanHang")
                        .HasColumnType("DateTime");

                    b.Property<string>("NhaCC")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("MaSP");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
