using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddedSupervisor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 1,
                column: "Pin",
                value: "$2a$11$go22cnyir4OD1s08g5E3ceWmqbRGa.Q21QCN7bKjZjHM5aQ0NmKd2");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 2,
                column: "Pin",
                value: "$2a$11$VB3Lcn5KezcBuEbFF3OaT.vJ2nGJ/ytIalBgalD/.n//Lxg0vhzqG");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 3,
                column: "Pin",
                value: "$2a$11$BTexGZ6Hb1ldSFtS1zYIPudDV3nFIpqX.jDea1e7bM63uYOZ9yH5S");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 4,
                column: "Pin",
                value: "$2a$11$0t1d2L1ker6/CoSPDsQazu9Yd2gcPKCOgvTwPM4D3zJGiTjCaZnpu");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 5,
                column: "Pin",
                value: "$2a$11$Xr/0M3tkGFb/zB08NBF.iORNoL06czvtfuC0.c3Txo2mF.O/TyJ.y");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 6,
                column: "Pin",
                value: "$2a$11$zedntRtjHbiKApFgbmheKurUEuvfSE6.K5MY9LoO9aB2Lr0oC8qDm");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 7,
                column: "Pin",
                value: "$2a$11$Jl1BjpsKQtLhrzi/P6fc0uyFEfRlLJuOze36.8h16wyDMKxqJjJQ6");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 8,
                column: "Pin",
                value: "$2a$11$DjcJkTJPIoXvkjw//3.rROXwppQhG0pX/hGojxYOqc.KgWJnpe/8K");

            migrationBuilder.InsertData(
                table: "TEACHER",
                columns: new[] { "ID", "FIRSTNAME", "LASTNAME", "Pin" },
                values: new object[] { 1000000, "Supervisor", "-", "$2a$11$QWpE5M7SQcmX97w5HLt8IOAZu9ca6P2j9cRMSnSICyHEc8Y5kxluC" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 1000000);

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 1,
                column: "Pin",
                value: "$2a$11$SwgkjZDwDHlKqAEvuXWjeuFZQZHyHWuD3M2IC9jNT/bEZcGc0OPHu");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 2,
                column: "Pin",
                value: "$2a$11$2r6WVLhss7NJ6iZQ9hDtLu9DMxNTJGXEAXHB76iP0p3b1QqmbKTqi");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 3,
                column: "Pin",
                value: "$2a$11$7Koy3olyzfoRtSY7ujfFA.ARLzxEAVGnHkkzWvZSpqHHyMUjxAR.u");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 4,
                column: "Pin",
                value: "$2a$11$lCkp850wRAgnDRtm9YArP.bhz38VXMSDMYUJZC.wTljSp.mi31xju");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 5,
                column: "Pin",
                value: "$2a$11$RbeBIuCBd0PsOHoEpJ26XOwrWC8lDmawHuE7rzIhhMksUX0OkFzXK");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 6,
                column: "Pin",
                value: "$2a$11$V26oPc7mt35VYAJjG706.eWfyzcFP4je64p.3PcUgo3dU0mGRPZjC");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 7,
                column: "Pin",
                value: "$2a$11$NEf6GQ0S00oU2lq7KOR9Leyjvq9a3fFJ/3ZaNpFafoe5KVZyM2CV.");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 8,
                column: "Pin",
                value: "$2a$11$0wp2Icd4cIF3YKR1aardP.tbmEsl3t8Jd0yR.I71ALFSc4szn3ASK");
        }
    }
}
