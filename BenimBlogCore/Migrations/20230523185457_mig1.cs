using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenimBlogCore.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullanıcıAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Şifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acıklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResimYolu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rolu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

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
                name: "Bildirimlers",
                columns: table => new
                {
                    BildirimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BildirimTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BildirimSembolü = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BildirimDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BildirimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BildirimStatu = table.Column<bool>(type: "bit", nullable: false),
                    BildirimRengi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bildirimlers", x => x.BildirimID);
                });

            migrationBuilder.CreateTable(
                name: "BlogsReyting",
                columns: table => new
                {
                    BlogReytinID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogID = table.Column<int>(type: "int", nullable: false),
                    BlogToplamSkoru = table.Column<int>(type: "int", nullable: false),
                    BlogReytingSayısı = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogsReyting", x => x.BlogReytinID);
                });

            migrationBuilder.CreateTable(
                name: "HaberBultenis",
                columns: table => new
                {
                    MailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailStatu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HaberBultenis", x => x.MailID);
                });

            migrationBuilder.CreateTable(
                name: "Hakkımızdas",
                columns: table => new
                {
                    HakkımızdaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HakkımızdaDetaylar1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkımızdaDetaylar2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkımızdaResim1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkımızdaResim2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkımızdaLokasyon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkımızdaStatu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkımızdas", x => x.HakkımızdaID);
                });

            migrationBuilder.CreateTable(
                name: "İletisims",
                columns: table => new
                {
                    İletisimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İletisimKullanıcıAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İletisimMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İletisimBaslık = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İletisimMesaj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İletisimTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    İletisimStatu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_İletisims", x => x.İletisimID);
                });

            migrationBuilder.CreateTable(
                name: "Kategoris",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriAcıklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriStatu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoris", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Mesajlars",
                columns: table => new
                {
                    MesajID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gönderen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesajBaslık = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesajDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesajTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MesajStatu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesajlars", x => x.MesajID);
                });

            migrationBuilder.CreateTable(
                name: "Yazars",
                columns: table => new
                {
                    YazarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAdı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarHakkında = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarSifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarStatu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazars", x => x.YazarID);
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
                name: "Blogs",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogBaslık = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Blogİcerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogKucukResim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogResim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogStatu = table.Column<bool>(type: "bit", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    YazarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogID);
                    table.ForeignKey(
                        name: "FK_Blogs_Kategoris_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoris",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blogs_Yazars_YazarID",
                        column: x => x.YazarID,
                        principalTable: "Yazars",
                        principalColumn: "YazarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mesajlar2s",
                columns: table => new
                {
                    Mesaj2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GönderenID = table.Column<int>(type: "int", nullable: true),
                    AlanID = table.Column<int>(type: "int", nullable: true),
                    MesajBaslık = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesajDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesajTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MesajStatu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesajlar2s", x => x.Mesaj2ID);
                    table.ForeignKey(
                        name: "FK_Mesajlar2s_Yazars_AlanID",
                        column: x => x.AlanID,
                        principalTable: "Yazars",
                        principalColumn: "YazarID");
                    table.ForeignKey(
                        name: "FK_Mesajlar2s_Yazars_GönderenID",
                        column: x => x.GönderenID,
                        principalTable: "Yazars",
                        principalColumn: "YazarID");
                });

            migrationBuilder.CreateTable(
                name: "Yorums",
                columns: table => new
                {
                    YorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YorumKullanıcıAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YorumBaslık = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yorumİcerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YorumTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogSkoru = table.Column<int>(type: "int", nullable: false),
                    YorumStatu = table.Column<bool>(type: "bit", nullable: false),
                    BlogID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorums", x => x.YorumID);
                    table.ForeignKey(
                        name: "FK_Yorums_Blogs_BlogID",
                        column: x => x.BlogID,
                        principalTable: "Blogs",
                        principalColumn: "BlogID",
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
                name: "IX_Blogs_KategoriID",
                table: "Blogs",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_YazarID",
                table: "Blogs",
                column: "YazarID");

            migrationBuilder.CreateIndex(
                name: "IX_Mesajlar2s_AlanID",
                table: "Mesajlar2s",
                column: "AlanID");

            migrationBuilder.CreateIndex(
                name: "IX_Mesajlar2s_GönderenID",
                table: "Mesajlar2s",
                column: "GönderenID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorums_BlogID",
                table: "Yorums",
                column: "BlogID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

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
                name: "Bildirimlers");

            migrationBuilder.DropTable(
                name: "BlogsReyting");

            migrationBuilder.DropTable(
                name: "HaberBultenis");

            migrationBuilder.DropTable(
                name: "Hakkımızdas");

            migrationBuilder.DropTable(
                name: "İletisims");

            migrationBuilder.DropTable(
                name: "Mesajlar2s");

            migrationBuilder.DropTable(
                name: "Mesajlars");

            migrationBuilder.DropTable(
                name: "Yorums");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Kategoris");

            migrationBuilder.DropTable(
                name: "Yazars");
        }
    }
}
