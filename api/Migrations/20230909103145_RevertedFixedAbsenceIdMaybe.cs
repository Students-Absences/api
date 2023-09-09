using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class RevertedFixedAbsenceIdMaybe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
