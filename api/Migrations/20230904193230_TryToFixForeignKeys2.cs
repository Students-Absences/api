using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class TryToFixForeignKeys2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_STUDENTCLASSROOM_CLASSROOM_CLASSROOMID1",
                table: "STUDENTCLASSROOM");

            migrationBuilder.DropForeignKey(
                name: "FK_STUDENTCLASSROOM_STUDENT_STUDENTID1",
                table: "STUDENTCLASSROOM");

            migrationBuilder.DropIndex(
                name: "IX_STUDENTCLASSROOM_CLASSROOMID1",
                table: "STUDENTCLASSROOM");

            migrationBuilder.DropIndex(
                name: "IX_STUDENTCLASSROOM_STUDENTID1",
                table: "STUDENTCLASSROOM");

            migrationBuilder.DropColumn(
                name: "CLASSROOMID1",
                table: "STUDENTCLASSROOM");

            migrationBuilder.DropColumn(
                name: "STUDENTID1",
                table: "STUDENTCLASSROOM");

            migrationBuilder.CreateIndex(
                name: "IX_STUDENTCLASSROOM_CLASSROOMID",
                table: "STUDENTCLASSROOM",
                column: "CLASSROOMID");

            migrationBuilder.AddForeignKey(
                name: "FK_STUDENTCLASSROOM_CLASSROOM_CLASSROOMID",
                table: "STUDENTCLASSROOM",
                column: "CLASSROOMID",
                principalTable: "CLASSROOM",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_STUDENTCLASSROOM_STUDENT_STUDENTID",
                table: "STUDENTCLASSROOM",
                column: "STUDENTID",
                principalTable: "STUDENT",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_STUDENTCLASSROOM_CLASSROOM_CLASSROOMID",
                table: "STUDENTCLASSROOM");

            migrationBuilder.DropForeignKey(
                name: "FK_STUDENTCLASSROOM_STUDENT_STUDENTID",
                table: "STUDENTCLASSROOM");

            migrationBuilder.DropIndex(
                name: "IX_STUDENTCLASSROOM_CLASSROOMID",
                table: "STUDENTCLASSROOM");

            migrationBuilder.AddColumn<int>(
                name: "CLASSROOMID1",
                table: "STUDENTCLASSROOM",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "STUDENTID1",
                table: "STUDENTCLASSROOM",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 1, 7 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 2, 8 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 2, 9 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 2, 10 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 2, 11 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 2, 12 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 2, 13 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 2, 14 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 3, 15 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 3, 16 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 3, 17 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 3, 18 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 3, 19 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 3, 20 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 3, 21 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 4, 22 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 4, 23 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 4, 24 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 4, 25 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 4, 26 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 4, 27 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 4, 28 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 5, 29 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 5, 30 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 5, 31 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 5, 32 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 5, 33 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 5, 34 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 5, 35 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 6, 36 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 6, 37 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 6, 38 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 6, 39 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 6, 40 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 6, 41 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 6, 42 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 7, 43 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 7, 44 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 7, 45 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 7, 46 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 7, 47 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 7, 48 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 7, 49 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 8, 50 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 8, 51 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 8, 52 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 8, 53 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 8, 54 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 8, 55 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 8, 56 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 9, 57 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 9, 58 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 9, 59 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 9, 60 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 9, 61 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 9, 62 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 9, 63 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 10, 64 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 10, 65 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 10, 66 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 10, 67 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 10, 68 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 10, 69 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 10, 70 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 11, 71 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 11, 72 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 11, 73 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 11, 74 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 11, 75 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 11, 76 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 11, 77 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 12, 78 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 12, 79 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 12, 80 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 12, 81 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 12, 82 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 12, 83 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 12, 84 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 1, 85 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 2, 86 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 3, 87 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 4, 88 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 5, 89 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 6, 90 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 7, 91 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 8, 92 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 9, 93 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 10, 94 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 11, 95 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 12, 96 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "STUDENTCLASSROOM",
                keyColumns: new[] { "CLASSROOMID", "STUDENTID" },
                keyValues: new object[] { 1, 97 },
                columns: new[] { "CLASSROOMID1", "STUDENTID1" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "IX_STUDENTCLASSROOM_CLASSROOMID1",
                table: "STUDENTCLASSROOM",
                column: "CLASSROOMID1");

            migrationBuilder.CreateIndex(
                name: "IX_STUDENTCLASSROOM_STUDENTID1",
                table: "STUDENTCLASSROOM",
                column: "STUDENTID1");

            migrationBuilder.AddForeignKey(
                name: "FK_STUDENTCLASSROOM_CLASSROOM_CLASSROOMID1",
                table: "STUDENTCLASSROOM",
                column: "CLASSROOMID1",
                principalTable: "CLASSROOM",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_STUDENTCLASSROOM_STUDENT_STUDENTID1",
                table: "STUDENTCLASSROOM",
                column: "STUDENTID1",
                principalTable: "STUDENT",
                principalColumn: "ID");
        }
    }
}
