using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenimBlogCore.Migrations
{
    public partial class mig_appuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdıSoyadı",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ResimUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdıSoyadı",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ResimUrl",
                table: "AspNetUsers");
        }
    }
}
