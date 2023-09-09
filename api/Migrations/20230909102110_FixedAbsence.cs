using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class FixedAbsence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "$2a$11$yzg6BBdFIx79/qfFyJQLle5dUYVg2L56865VKyKFdl2gGBoMHk.iK");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 2,
                column: "Pin",
                value: "$2a$11$tEPbPDUJw7.Wr0OSDPgZmOgZFa4qssTcUBigR20rlEIiCVnyo1cq2");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 3,
                column: "Pin",
                value: "$2a$11$bPoeWK7FynW9cR66eZkfgegPp/DUhi2KHDxM58rUjIdHAWemlxsbW");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 4,
                column: "Pin",
                value: "$2a$11$jAPRFcQOyp.JJAs3reHxCe0vTaI6JSp/urVEAyDjvhOn3ZqiS9WmC");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 5,
                column: "Pin",
                value: "$2a$11$y2UvAt0o6yWcX0AbN.ex1eYHglwQ6fdpSJbOfNE9kze7.DpBA/Ed2");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 6,
                column: "Pin",
                value: "$2a$11$Qg/tjR9BvV3hAIBspBlfG.hdEGTS9bULq5Z2Zl8KoR/t52GazIMCK");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 7,
                column: "Pin",
                value: "$2a$11$ChnsFcgGBJwG7ltJqBdrA.0fifN5hwFchncHDvHXDAONiykKqMShu");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 8,
                column: "Pin",
                value: "$2a$11$COQhCsyBxxOv1kpN5ly/5.FmdakC5nhrC6PSNp50uKBXj3VkfJc5i");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
