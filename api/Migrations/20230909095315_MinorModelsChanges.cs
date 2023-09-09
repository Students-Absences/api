using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class MinorModelsChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DAY",
                table: "ABSENCE");

            migrationBuilder.DropColumn(
                name: "HOUR",
                table: "ABSENCE");

            migrationBuilder.DropColumn(
                name: "MONTH",
                table: "ABSENCE");

            migrationBuilder.DropColumn(
                name: "YEAR",
                table: "ABSENCE");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 1,
                column: "Pin",
                value: "$2a$11$ygqXd1sqql8OzY37oHke6eoLN7eKktpLYEuGKqqHACH/KUGecpARm");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 2,
                column: "Pin",
                value: "$2a$11$Ra8AHLb9EJXWsK2ZMaAqyOUBdMsGiq0E7jWtreL2jBxoDPHGH61fm");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 3,
                column: "Pin",
                value: "$2a$11$mZONzxB.AMViQDCEf593bO/PFjOS.9ocwLJJ4YLc181GSDIs1NINW");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 4,
                column: "Pin",
                value: "$2a$11$nTnmKgTAbxWSavhnuLVqUuivevv7ySuI7mq8p3eVj4qOIEeseQoG6");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 5,
                column: "Pin",
                value: "$2a$11$iakd5vOskVLWu8ZjYuXU9.7vQI4TWY86L3VtxdBU1g2B6ifb.jexW");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 6,
                column: "Pin",
                value: "$2a$11$pBTwHbC3nprrmdkcex0zIuaImWJtz/d8ck9aETm9Pcnfdf0BjYYBy");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 7,
                column: "Pin",
                value: "$2a$11$i7KwyW9NlW53nFsTC5jVDObbthh65fHbRnjf3hI4vurLDnl4JFqFa");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 8,
                column: "Pin",
                value: "$2a$11$3o5b1XAf.MRWFxvMOhuBfu8sIy/wyzANPDVr3ofhdB335XSDnOP6u");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DAY",
                table: "ABSENCE",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HOUR",
                table: "ABSENCE",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MONTH",
                table: "ABSENCE",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YEAR",
                table: "ABSENCE",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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
    }
}
