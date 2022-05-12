﻿// <auto-generated />
using System;
using AppStoreOne.DataAccess.Concrete.EfCore.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppStoreOne.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220311110530_initDb")]
    partial class initDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23");

            modelBuilder.Entity("AppStoreOne.Entities.Concrete.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adres1")
                        .HasColumnType("TEXT")
                        .HasMaxLength(2000);

                    b.Property<string>("Adres2")
                        .HasColumnType("TEXT")
                        .HasMaxLength(2000);

                    b.Property<string>("Eposta")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("Fax")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("Gsm")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("IdentityNo")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("MusteriAdi")
                        .HasColumnType("TEXT")
                        .HasMaxLength(250);

                    b.Property<string>("MusteriBilgi")
                        .HasColumnType("TEXT")
                        .HasMaxLength(5000);

                    b.Property<int>("MusteriTip")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(1);

                    b.Property<string>("Telefon")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("Web")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("AppStoreOne.Entities.Concrete.Estate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ada")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("Adres")
                        .HasColumnType("TEXT")
                        .HasMaxLength(2000);

                    b.Property<int>("Banyo")
                        .HasColumnType("INTEGER")
                        .HasMaxLength(200);

                    b.Property<string>("Baslik")
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<string>("Bilgi")
                        .HasColumnType("TEXT")
                        .HasMaxLength(5000);

                    b.Property<string>("Blok")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("DaireNo")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<int>("Durum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0);

                    b.Property<int>("EmlakTipi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(1);

                    b.Property<double>("Fiyat")
                        .HasColumnType("REAL");

                    b.Property<string>("Il")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("Ilce")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<int>("Islem")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("IslemTarih")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kat")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<int>("M2")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0);

                    b.Property<int>("Oda")
                        .HasColumnType("INTEGER")
                        .HasMaxLength(200);

                    b.Property<string>("Pafta")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("Parsel")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<int>("SahipId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Salon")
                        .HasColumnType("INTEGER")
                        .HasMaxLength(200);

                    b.Property<string>("Semt")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("SiteAdi")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<DateTime>("SonlanmaTarih")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SahipId");

                    b.ToTable("estates");
                });

            modelBuilder.Entity("AppStoreOne.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0);

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("Password")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("AppStoreOne.Entities.Concrete.Estate", b =>
                {
                    b.HasOne("AppStoreOne.Entities.Concrete.Customer", "Sahip")
                        .WithMany("Estates")
                        .HasForeignKey("SahipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
