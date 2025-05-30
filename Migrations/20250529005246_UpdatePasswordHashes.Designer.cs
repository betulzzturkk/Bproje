﻿// <auto-generated />
using System;
using AutismEducationPlatform.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutismEducationPlatform.Migrations
{
    [DbContext(typeof(UygulamaDbContext))]
    [Migration("20250529005246_UpdatePasswordHashes")]
    partial class UpdatePasswordHashes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AutismEducationPlatform.Models.Cocuk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("EgitimDurumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OzelDurum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VeliId")
                        .HasColumnType("int");

                    b.Property<int>("Yas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VeliId");

                    b.ToTable("Cocuklar");
                });

            modelBuilder.Entity("AutismEducationPlatform.Models.CocukDurumu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CocukId")
                        .HasColumnType("int");

                    b.Property<string>("Durum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TarihSaat")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CocukId");

                    b.ToTable("CocukDurumlari");
                });

            modelBuilder.Entity("AutismEducationPlatform.Models.EgitimModulu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<string>("ModulAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModulTipi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturulmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResimYolu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SesYolu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EgitimModulleri");
                });

            modelBuilder.Entity("AutismEducationPlatform.Models.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciTipi")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kullanicilar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Admin",
                            Email = "admin@gmail.com",
                            KullaniciAdi = "",
                            KullaniciTipi = "Admin",
                            Sifre = "admin1234",
                            Soyad = "Admin"
                        });
                });

            modelBuilder.Entity("AutismEducationPlatform.Models.ModulIcerik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EgitimModuluId")
                        .HasColumnType("int");

                    b.Property<string>("Icerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResimYolu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SesYolu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sira")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EgitimModuluId");

                    b.ToTable("ModulIcerikleri");
                });

            modelBuilder.Entity("AutismEducationPlatform.Models.VeliBilgilendirme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Mesaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Okundu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TarihSaat")
                        .HasColumnType("datetime2");

                    b.Property<int>("VeliId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VeliId");

                    b.ToTable("VeliBilgilendirmeler");
                });

            modelBuilder.Entity("AutismEducationPlatform.Models.Cocuk", b =>
                {
                    b.HasOne("AutismEducationPlatform.Models.Kullanici", "Veli")
                        .WithMany()
                        .HasForeignKey("VeliId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Veli");
                });

            modelBuilder.Entity("AutismEducationPlatform.Models.CocukDurumu", b =>
                {
                    b.HasOne("AutismEducationPlatform.Models.Cocuk", "Cocuk")
                        .WithMany()
                        .HasForeignKey("CocukId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cocuk");
                });

            modelBuilder.Entity("AutismEducationPlatform.Models.ModulIcerik", b =>
                {
                    b.HasOne("AutismEducationPlatform.Models.EgitimModulu", "EgitimModulu")
                        .WithMany("Icerikler")
                        .HasForeignKey("EgitimModuluId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EgitimModulu");
                });

            modelBuilder.Entity("AutismEducationPlatform.Models.VeliBilgilendirme", b =>
                {
                    b.HasOne("AutismEducationPlatform.Models.Kullanici", "Veli")
                        .WithMany()
                        .HasForeignKey("VeliId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Veli");
                });

            modelBuilder.Entity("AutismEducationPlatform.Models.EgitimModulu", b =>
                {
                    b.Navigation("Icerikler");
                });
#pragma warning restore 612, 618
        }
    }
}
