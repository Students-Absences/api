using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class RemovedForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ABSENCE_ASSIGNMENT_ASSIGNMENTID",
                table: "ABSENCE");

            migrationBuilder.DropForeignKey(
                name: "FK_ABSENCE_STUDENT_STUDENTID",
                table: "ABSENCE");

            migrationBuilder.DropForeignKey(
                name: "FK_ASSIGNMENT_CLASSROOM_CLASSROOMID",
                table: "ASSIGNMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_ASSIGNMENT_SUBJECT_SUBJECTID",
                table: "ASSIGNMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_ASSIGNMENT_TEACHER_TEACHERID",
                table: "ASSIGNMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_STUDENTCLASSROOM_CLASSROOM_CLASSROOMID",
                table: "STUDENTCLASSROOM");

            migrationBuilder.DropForeignKey(
                name: "FK_STUDENTCLASSROOM_STUDENT_STUDENTID",
                table: "STUDENTCLASSROOM");

            migrationBuilder.DropIndex(
                name: "IX_STUDENTCLASSROOM_CLASSROOMID",
                table: "STUDENTCLASSROOM");

            migrationBuilder.DropIndex(
                name: "IX_ASSIGNMENT_CLASSROOMID",
                table: "ASSIGNMENT");

            migrationBuilder.DropIndex(
                name: "IX_ASSIGNMENT_SUBJECTID",
                table: "ASSIGNMENT");

            migrationBuilder.DropIndex(
                name: "IX_ASSIGNMENT_TEACHERID",
                table: "ASSIGNMENT");

            migrationBuilder.DropIndex(
                name: "IX_ABSENCE_ASSIGNMENTID",
                table: "ABSENCE");

            migrationBuilder.DropIndex(
                name: "IX_ABSENCE_STUDENTID",
                table: "ABSENCE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_STUDENTCLASSROOM_CLASSROOMID",
                table: "STUDENTCLASSROOM",
                column: "CLASSROOMID");

            migrationBuilder.CreateIndex(
                name: "IX_ASSIGNMENT_CLASSROOMID",
                table: "ASSIGNMENT",
                column: "CLASSROOMID");

            migrationBuilder.CreateIndex(
                name: "IX_ASSIGNMENT_SUBJECTID",
                table: "ASSIGNMENT",
                column: "SUBJECTID");

            migrationBuilder.CreateIndex(
                name: "IX_ASSIGNMENT_TEACHERID",
                table: "ASSIGNMENT",
                column: "TEACHERID");

            migrationBuilder.CreateIndex(
                name: "IX_ABSENCE_ASSIGNMENTID",
                table: "ABSENCE",
                column: "ASSIGNMENTID");

            migrationBuilder.CreateIndex(
                name: "IX_ABSENCE_STUDENTID",
                table: "ABSENCE",
                column: "STUDENTID");

            migrationBuilder.AddForeignKey(
                name: "FK_ABSENCE_ASSIGNMENT_ASSIGNMENTID",
                table: "ABSENCE",
                column: "ASSIGNMENTID",
                principalTable: "ASSIGNMENT",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ABSENCE_STUDENT_STUDENTID",
                table: "ABSENCE",
                column: "STUDENTID",
                principalTable: "STUDENT",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ASSIGNMENT_CLASSROOM_CLASSROOMID",
                table: "ASSIGNMENT",
                column: "CLASSROOMID",
                principalTable: "CLASSROOM",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ASSIGNMENT_SUBJECT_SUBJECTID",
                table: "ASSIGNMENT",
                column: "SUBJECTID",
                principalTable: "SUBJECT",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ASSIGNMENT_TEACHER_TEACHERID",
                table: "ASSIGNMENT",
                column: "TEACHERID",
                principalTable: "TEACHER",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

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
    }
}
