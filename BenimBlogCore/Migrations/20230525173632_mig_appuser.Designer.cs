﻿// <auto-generated />
using System;
using BenimBlogCore.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BenimBlogCore.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230525173632_mig_appuser")]
    partial class mig_appuser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BenimBlogCore.Models.Entity.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminID"), 1L, 1);

                    b.Property<string>("Acıklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullanıcıAdı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResimYolu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rolu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Şifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("BenimBlogCore.Models.Entity.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AdıSoyadı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("ResimUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("BenimBlogCore.Models.Entity.Bildirimler", b =>
                {
                    b.Property<int>("BildirimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BildirimID"), 1L, 1);

                    b.Property<string>("BildirimDetay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BildirimRengi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BildirimSembolü")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BildirimStatu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("BildirimTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("BildirimTipi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BildirimID");

                    b.ToTable("Bildirimlers");
                });

            modelBuilder.Entity("BenimBlogCore.Models.Entity.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogID"), 1L, 1);

                    b.Property<string>("BlogBaslık")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogKucukResim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogResim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BlogStatu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("BlogTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Blogİcerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<int>("YazarID")
                        .HasColumnType("int");

                    b.HasKey("BlogID");

                    b.HasIndex("KategoriID");

                    b.HasIndex("YazarID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("BenimBlogCore.Models.Entity.BlogReyting", b =>
                {
                    b.Property<int>("BlogReytinID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogReytinID"), 1L, 1);

                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.Property<int>("BlogReytingSayısı")
                        .HasColumnType("int");

                    b.Property<int>("BlogToplamSkoru")
                        .HasColumnType("int");

                    b.HasKey("BlogReytinID");

                    b.ToTable("BlogsReyting");
                });

            modelBuilder.Entity("BenimBlogCore.Models.Entity.HaberBulteni", b =>
                {
                    b.Property<int>("MailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MailID"), 1L, 1);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MailStatu")
                        .HasColumnType("bit");

                    b.HasKey("MailID");

                    b.ToTable("HaberBultenis");
                });

            modelBuilder.Entity("BenimBlogCore.Models.Entity.Hakkımızda", b =>
                {
                    b.Property<int>("HakkımızdaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HakkımızdaID"), 1L, 1);

                    b.Property<string>("HakkımızdaDetaylar1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkımızdaDetaylar2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkımızdaLokasyon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkımızdaResim1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkımızdaResim2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HakkımızdaStatu")
                        .HasColumnType("bit");

                    b.HasKey("HakkımızdaID");

                    b.ToTable("Hakkımızdas");
                });

            modelBuilder.Entity("BenimBlogCore.Models.Entity.İletisim", b =>
                {
                    b.Property<int>("İletisimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("İletisimID"), 1L, 1);

                    b.Property<string>("İletisimBaslık")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("İletisimKullanıcıAdı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("İletisimMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("İletisimMesaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("İletisimStatu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("İletisimTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("İletisimID");

                    b.ToTable("İletisims");
                });

            modelBuilder.Entity("BenimBlogCore.Models.Entity.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriID"), 1L, 1);

                    b.Property<string>("KategoriAcıklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KategoriAdı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("KategoriStatu")
                        .HasColumnType("bit");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategoris");
                });

            modelBuilder.Entity("BenimBlogCore.Models.Entity.Mesajlar", b =>
                {
                    b.Property<int>("MesajID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MesajID"), 1L, 1);

                    b.Property<string>("Alan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gönderen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MesajBaslık")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MesajDetay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MesajStatu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MesajTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("MesajID");

                    b.ToTable("Mesajlars");
                });

            modelBuilder.Entity("BenimBlogCore.Models.Entity.Mesajlar2", b =>
                {
                    b.Property<int>("Mesaj2ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Mesaj2ID"), 1L, 1);

                    b.Property<int?>("AlanID")
                        .HasColumnType("int");

                    b.Property<int?>("GönderenID")
                        .HasColumnType("int");

                    b.Property<string>("MesajBaslık")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MesajDetay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MesajStatu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MesajTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Mesaj2ID");

                    b.HasIndex("AlanID");

                    b.HasIndex("GönderenID");

                    b.ToTable("Mesajlar2s");
                });

            modelBuilder.Entity("BenimBlogCore.Models.Entity.Yazar", b =>
                {
                    b.Property<int>("YazarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YazarID"), 1L, 1);

                    b.Property<string>("YazarAdı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarHakkında")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarSifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("YazarStatu")
                        .HasColumnType("bit");

                    b.HasKey("YazarID");

                    b.ToTable("Yazars");
                });

            modelBuilder.Entity("BenimBlogCore.Models.Entity.Yorum", b =>
                {
                    b.Property<int>("YorumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YorumID"), 1L, 1);

                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.Property<int>("BlogSkoru")
                        .HasColumnType("int");

                    b.Property<string>("YorumBaslık")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumKullanıcıAdı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("YorumStatu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("YorumTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Yorumİcerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YorumID");

                    b.HasIndex("BlogID");

                    b.ToTable("Yorums");
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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("BenimBlogCore.Models.Entity.Blog", b =>
                {
                    b.HasOne("BenimBlogCore.Models.Entity.Kategori", "Kategori")
                        .WithMany("Blogs")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BenimBlogCore.Models.Entity.Yazar", "Yazar")
                        .WithMany("Blogs")
                        .HasForeignKey("YazarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Yazar");
                });

            modelBuilder.Entity("BenimBlogCore.Models.Entity.Mesajlar2", b =>
                {
                    b.HasOne("BenimBlogCore.Models.Entity.Yazar", "AlanKullanıcı")
                        .WithMany("YazarAlıcı")
                        .HasForeignKey("AlanID");

                    b.HasOne("BenimBlogCore.Models.Entity.Yazar", "GönderKullanıcı")
                        .WithMany("YazarGönderen")
                        .HasForeignKey("GönderenID");

                    b.Navigation("AlanKullanıcı");

                    b.Navigation("GönderKullanıcı");
                });

            modelBuilder.Entity("BenimBlogCore.Models.Entity.Yorum", b =>
                {
                    b.HasOne("BenimBlogCore.Models.Entity.Blog", "Blog")
                        .WithMany("Yorums")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
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
                    b.HasOne("BenimBlogCore.Models.Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BenimBlogCore.Models.Entity.AppUser", null)
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

                    b.HasOne("BenimBlogCore.Models.Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BenimBlogCore.Models.Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BenimBlogCore.Models.Entity.Blog", b =>
                {
                    b.Navigation("Yorums");
                });

            modelBuilder.Entity("BenimBlogCore.Models.Entity.Kategori", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("BenimBlogCore.Models.Entity.Yazar", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("YazarAlıcı");

                    b.Navigation("YazarGönderen");
                });
#pragma warning restore 612, 618
        }
    }
}
