using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class CreateSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "APPSETTINGS",
                columns: table => new
                {
                    SCHOOLNAME = table.Column<string>(type: "TEXT", nullable: false),
                    SCHOOLLOGOURL = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APPSETTINGS");
        }
    }
}
