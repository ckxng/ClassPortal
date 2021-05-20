using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassPortal.Migrations
{
    public partial class CollegeBannerURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BannerURL",
                table: "Colleges",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerURL",
                table: "Colleges");
        }
    }
}
