﻿// <auto-generated />
using System;
using Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20230729122314_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("Entity.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Majority")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2023, 7, 29, 15, 23, 14, 471, DateTimeKind.Local).AddTicks(9769),
                            ImageUrl = "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",
                            Majority = "math",
                            Name = "Matematik sınavı var",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2023, 7, 29, 15, 23, 14, 471, DateTimeKind.Local).AddTicks(9772),
                            ImageUrl = "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",
                            Majority = "math",
                            Name = "yazılım yardım",
                            Price = 20200m
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2023, 7, 29, 15, 23, 14, 471, DateTimeKind.Local).AddTicks(9774),
                            ImageUrl = "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",
                            Majority = "math",
                            Name = "Matematik sınavı var",
                            Price = 20200m
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2023, 7, 29, 15, 23, 14, 471, DateTimeKind.Local).AddTicks(9775),
                            ImageUrl = "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",
                            Majority = "math",
                            Name = "Matematik sınavı var",
                            Price = 223000m
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2023, 7, 29, 15, 23, 14, 471, DateTimeKind.Local).AddTicks(9776),
                            ImageUrl = "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",
                            Majority = "math",
                            Name = "Matematik sınavı var",
                            Price = 20300m
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2023, 7, 29, 15, 23, 14, 471, DateTimeKind.Local).AddTicks(9777),
                            ImageUrl = "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",
                            Majority = "math",
                            Name = "Matematik sınavı var",
                            Price = 20400m
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2023, 7, 29, 15, 23, 14, 471, DateTimeKind.Local).AddTicks(9778),
                            ImageUrl = "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",
                            Majority = "math",
                            Name = "Matematik sınavı var",
                            Price = 25000m
                        });
                });

            modelBuilder.Entity("Entity.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Majority")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2023, 7, 29, 15, 23, 14, 471, DateTimeKind.Local).AddTicks(9652),
                            ImageUrl = "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",
                            Majority = "math",
                            Name = "TIP ÖĞRENCİSİNDEN AÇIK LİSE SINAVI YARDIM",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2023, 7, 29, 15, 23, 14, 471, DateTimeKind.Local).AddTicks(9670),
                            ImageUrl = "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",
                            Majority = "math",
                            Name = "TEZ/PROJE/ ÖDEV PROFESYONEL DESTEK",
                            Price = 3422m
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2023, 7, 29, 15, 23, 14, 471, DateTimeKind.Local).AddTicks(9672),
                            ImageUrl = "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",
                            Majority = "math",
                            Name = "EGE TIP ÖĞRENCİSİNDE SAĞLIK ve AÇIK ÖĞRETİM DERSLERİNE DESTEK",
                            Price = 12332m
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2023, 7, 29, 15, 23, 14, 471, DateTimeKind.Local).AddTicks(9673),
                            ImageUrl = "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",
                            Majority = "math",
                            Name = "ODTÜ mezunu hocalardan özel ders ve üniversite sınav yardımı",
                            Price = 2332m
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2023, 7, 29, 15, 23, 14, 471, DateTimeKind.Local).AddTicks(9674),
                            ImageUrl = "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",
                            Majority = "math",
                            Name = "Matemmatik öedv yardımı",
                            Price = 2000232m
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2023, 7, 29, 15, 23, 14, 471, DateTimeKind.Local).AddTicks(9675),
                            ImageUrl = "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",
                            Majority = "math",
                            Name = "Fizik ödev",
                            Price = 202300m
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2023, 7, 29, 15, 23, 14, 471, DateTimeKind.Local).AddTicks(9676),
                            ImageUrl = "https://krtknadmn.karatekin.edu.tr/files/karatekin/yl/a.jpg",
                            Majority = "math",
                            Name = "MAtematik Master",
                            Price = 203200m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
