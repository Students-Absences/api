using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddedKeyToSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "APPSETTINGS",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_APPSETTINGS",
                table: "APPSETTINGS",
                column: "ID");

            migrationBuilder.InsertData(
                table: "APPSETTINGS",
                columns: new[] { "ID", "SCHOOLLOGOURL", "SCHOOLNAME" },
                values: new object[] { 1, "https://5lykeiovyrona.gr/img/logo-mobile.png", "5ο Λύκειο Βύρωνα" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_APPSETTINGS",
                table: "APPSETTINGS");

            migrationBuilder.DeleteData(
                table: "APPSETTINGS",
                keyColumn: "ID",
                keyColumnType: "INTEGER",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "ID",
                table: "APPSETTINGS");
        }
    }
}
