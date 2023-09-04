using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddedTeacherPins : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pin",
                table: "TEACHER",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 1,
                column: "Pin",
                value: "$2a$11$dlRodGz8R7Liwc/V4LIRveN97JMDmDKmTSECA2C5a0x0O59VEmgtm");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 2,
                column: "Pin",
                value: "$2a$11$ZJ2P6W31z47Uc6WRzFWLn.8796NRnd6z07ej8wuMMXdlOnhP8q.yy");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 3,
                column: "Pin",
                value: "$2a$11$11JedG6qjYrVhJwSfnnaZOOWGsrGU59HnPH1ELFKx7PYvjSUc62t2");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 4,
                column: "Pin",
                value: "$2a$11$xHoavVB.ELkpAWHYpK.1eeCozM3dfyx6nkK4mlnQPwb1S4QBekgm.");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 5,
                column: "Pin",
                value: "$2a$11$uEf5M4ej6yBgFyDXY4a80OrBpL7t/7NHHYdtcv1jS95xe75HbnMHS");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 6,
                column: "Pin",
                value: "$2a$11$8Hw9FhdeO4NqToVE2z/PpOzQ/nz.We53hR48cQZ7xjbEkb5Zfaxcm");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 7,
                column: "Pin",
                value: "$2a$11$A1x5Jv4c7zW8kznRkoTyCermMzfukekEX7yRIAf01X28B/iXCycQS");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 8,
                column: "Pin",
                value: "$2a$11$W72Db6GLRCduwld.lsWG.OPPgWN5XP77IOTWG9wpaO02FieKYH5ry");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pin",
                table: "TEACHER");
        }
    }
}
