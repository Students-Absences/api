using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class FixedAbsenceIdMaybe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 1,
                column: "Pin",
                value: "$2a$11$zwQWEc3ewLP0Tj1lkuIEoOXxNfdzPDq68nQMuVafaIw4mfxiRQhJC");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 2,
                column: "Pin",
                value: "$2a$11$ERK4LqZ7Zl0xjWNTG2lZz.DvRBuVST3wSHJ4qdukN7ZEweZ1MObhy");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 3,
                column: "Pin",
                value: "$2a$11$BID3hEkE21Vb4C34BNV6aOlzPq3oud6pQ5KDDd6U038TVHsvz26Iy");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 4,
                column: "Pin",
                value: "$2a$11$VjUE7RRY9Bs.jOWDn100SOfov/45umU/.MvNDBebCEjlc0nzdSASW");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 5,
                column: "Pin",
                value: "$2a$11$a5AEIIpmYuCRWc/5XLLPDeZBN00gBqAeU0v9ExJbAWZLD8N4CN1rK");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 6,
                column: "Pin",
                value: "$2a$11$NdsV6m3YYWDc1zT/H/LRU.PbHWPAsOnyZ1hjgoi.jL2FhJeExYgQu");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 7,
                column: "Pin",
                value: "$2a$11$qWpk3Nn4DcHuyIEsMgUX.emQBAj0vlsS83QF8cKIU6X8/ThKRFRe6");

            migrationBuilder.UpdateData(
                table: "TEACHER",
                keyColumn: "ID",
                keyValue: 8,
                column: "Pin",
                value: "$2a$11$k0VXmjkK9bHx/4dkAfZhg.vbFYVy/J9uZNshv.5eA1jm4p4iLY3lq");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
