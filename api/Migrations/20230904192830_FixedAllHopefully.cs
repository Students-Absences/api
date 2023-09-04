using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class FixedAllHopefully : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddPrimaryKey(
                name: "PK_APPSETTINGS",
                table: "APPSETTINGS",
                columns: new[] { "SCHOOLNAME", "SCHOOLLOGOURL" });

            migrationBuilder.CreateTable(
                name: "CLASSROOM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LABEL = table.Column<string>(type: "TEXT", nullable: false),
                    LABELEN = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLASSROOM", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "STUDENT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FIRSTNAME = table.Column<string>(type: "TEXT", nullable: false),
                    LASTNAME = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STUDENT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SUBJECT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LABEL = table.Column<string>(type: "TEXT", nullable: false),
                    LABELEN = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUBJECT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TEACHER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FIRSTNAME = table.Column<string>(type: "TEXT", nullable: false),
                    LASTNAME = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEACHER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "STUDENTCLASSROOM",
                columns: table => new
                {
                    STUDENTID = table.Column<int>(type: "INTEGER", nullable: false),
                    CLASSROOMID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STUDENTCLASSROOM", x => new { x.STUDENTID, x.CLASSROOMID });
                    table.ForeignKey(
                        name: "FK_STUDENTCLASSROOM_CLASSROOM_CLASSROOMID",
                        column: x => x.CLASSROOMID,
                        principalTable: "CLASSROOM",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_STUDENTCLASSROOM_STUDENT_STUDENTID",
                        column: x => x.STUDENTID,
                        principalTable: "STUDENT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ASSIGNMENT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CLASSROOMID = table.Column<int>(type: "INTEGER", nullable: false),
                    SUBJECTID = table.Column<int>(type: "INTEGER", nullable: false),
                    TEACHERID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASSIGNMENT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ASSIGNMENT_CLASSROOM_CLASSROOMID",
                        column: x => x.CLASSROOMID,
                        principalTable: "CLASSROOM",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ASSIGNMENT_SUBJECT_SUBJECTID",
                        column: x => x.SUBJECTID,
                        principalTable: "SUBJECT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ASSIGNMENT_TEACHER_TEACHERID",
                        column: x => x.TEACHERID,
                        principalTable: "TEACHER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ABSENCE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HOUR = table.Column<int>(type: "INTEGER", nullable: false),
                    DAY = table.Column<int>(type: "INTEGER", nullable: false),
                    MONTH = table.Column<int>(type: "INTEGER", nullable: false),
                    YEAR = table.Column<int>(type: "INTEGER", nullable: false),
                    ASSIGNMENTID = table.Column<int>(type: "INTEGER", nullable: false),
                    STUDENTID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABSENCE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ABSENCE_ASSIGNMENT_ASSIGNMENTID",
                        column: x => x.ASSIGNMENTID,
                        principalTable: "ASSIGNMENT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ABSENCE_STUDENT_STUDENTID",
                        column: x => x.STUDENTID,
                        principalTable: "STUDENT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "APPSETTINGS",
                columns: new[] { "SCHOOLLOGOURL", "SCHOOLNAME" },
                values: new object[] { "https://5lykeiovyrona.gr/img/logo-mobile.png", "5ο Λύκειο Βύρωνα" });

            migrationBuilder.InsertData(
                table: "CLASSROOM",
                columns: new[] { "ID", "LABEL", "LABELEN" },
                values: new object[,]
                {
                    { 1, "Α1", "A1" },
                    { 2, "Α2", "A2" },
                    { 3, "Α3", "A3" },
                    { 4, "Α4", "A4" },
                    { 5, "Β1", "B1" },
                    { 6, "Β2", "B2" },
                    { 7, "Β3", "B3" },
                    { 8, "Β4", "B4" },
                    { 9, "Γ1", "C1" },
                    { 10, "Γ2", "C2" },
                    { 11, "Γ3", "C3" },
                    { 12, "Γ4", "C4" }
                });

            migrationBuilder.InsertData(
                table: "STUDENT",
                columns: new[] { "ID", "FIRSTNAME", "LASTNAME" },
                values: new object[,]
                {
                    { 1, "Στρατής", "Δερμανούτσος" },
                    { 2, "Κάποιο", "Άτομο" },
                    { 3, "Δεύτερο", "Πρόσωπο" },
                    { 4, "Παρασκευάς", "Παναγιωτόπουλος" },
                    { 5, "Παναγιώτης", "Παρασκευόπουλος" },
                    { 6, "Μαρία", "Εκατερίνη" },
                    { 7, "Κατερίνα", "Μαριέτα" },
                    { 8, "Νίκος", "Παπαδόπουλος" },
                    { 9, "Ελένη", "Γεωργίου" },
                    { 10, "Γιώργος", "Ιωάννου" },
                    { 11, "Σοφία", "Χριστοπούλου" },
                    { 12, "Δημήτρης", "Κοντός" },
                    { 13, "Αναστασία", "Σπυρόπουλος" },
                    { 14, "Θανάσης", "Σταυρόπουλος" },
                    { 15, "Βασίλης", "Βασιλείου" },
                    { 16, "Αγγελική", "Στεφανίδου" },
                    { 17, "Κώστας", "Λεωνίδας" },
                    { 18, "Μαρίνα", "Κυριακού" },
                    { 19, "Αλέξης", "Τσίπρας" },
                    { 20, "Δέσποινα", "Μάρκου" },
                    { 21, "Πέτρος", "Γεωργακόπουλος" },
                    { 22, "Ευαγγελία", "Μήτσου" },
                    { 23, "Χρήστος", "Ανδρόπουλος" },
                    { 24, "Ελισάβετ", "Μακρή" },
                    { 25, "Φώτης", "Κολοκοτρώνης" },
                    { 26, "Αικατερίνη", "Μπαλτά" },
                    { 27, "Στέλιος", "Σταματόπουλος" },
                    { 28, "Μαργαρίτα", "Μανώλης" },
                    { 29, "Ανδρέας", "Δημητρίου" },
                    { 30, "Χρυσάνθη", "Παπαγιάννη" },
                    { 31, "Λεωνίδας", "Μαρινάκης" },
                    { 32, "Φιλίππα", "Τσιάρα" },
                    { 33, "Μανώλης", "Στεφανάκης" },
                    { 34, "Βικτώρια", "Σαρρή" },
                    { 35, "Ευθύμης", "Κουτσούρης" },
                    { 36, "Πολυξένη", "Κοκκίνη" },
                    { 37, "Σπύρος", "Μητσότακης" },
                    { 38, "Ευάγγελος", "Βενιζέλος" },
                    { 39, "Ιωάννα", "Παπανδρέου" },
                    { 40, "Χριστίνα", "Καραμανλής" },
                    { 41, "Ελπίδα", "Σαμαράς" },
                    { 42, "Απόστολος", "Κυριάκος" },
                    { 43, "Ειρήνη", "Σολωμού" },
                    { 44, "Φαίδων", "Τσόγκας" },
                    { 45, "Χαρά", "Φραγκούλη" },
                    { 46, "Παντελής", "Παπαδημητρίου" },
                    { 47, "Σταυρούλα", "Αλεξίου" },
                    { 48, "Γεράσιμος", "Βλάχος" },
                    { 49, "Ολία", "Δανιηλίδου" },
                    { 50, "Λουκάς", "Παπαϊωάννου" },
                    { 51, "Νεφέλη", "Καλογεροπούλου" },
                    { 52, "Αντώνης", "Ρέμος" },
                    { 53, "Ζωή", "Κωνσταντόπουλος" },
                    { 54, "Διονύσης", "Σχοινάς" },
                    { 55, "Μελίνα", "Κανάκης" },
                    { 56, "Άρης", "Μπελονιάς" },
                    { 57, "Αγλαΐα", "Τσελίκα" },
                    { 58, "Κλέαρχος", "Σπυρόπουλος" },
                    { 59, "Δάφνη", "Φωκά" },
                    { 60, "Ηλίας", "Σκούφος" },
                    { 61, "Λαμπρινή", "Βιτσιλάκη" },
                    { 62, "Βαγγέλης", "Καπάτος" },
                    { 63, "Ναυσικά", "Πασχαλίδου" },
                    { 64, "Φοίβος", "Δεληβοριάς" },
                    { 65, "Μυρτώ", "Φράγκου" },
                    { 66, "Σπυρίδων", "Κολοκοτρώνης" },
                    { 67, "Φωτεινή", "Παπακωνσταντίνου" },
                    { 68, "Κώστας", "Λειβαδάς" },
                    { 69, "Φρόσω", "Πετράκη" },
                    { 70, "Ηλιάνα", "Τσακίρη" },
                    { 71, "Εμμανουήλ", "Κοτσόβος" },
                    { 72, "Βασιλική", "Σπυρίδη" },
                    { 73, "Ορέστης", "Ανδρούτσος" },
                    { 74, "Ελένη", "Κουτσούμπα" },
                    { 75, "Μάνος", "Χατζηδάκις" },
                    { 76, "Γλυκερία", "Μητσοτάκη" },
                    { 77, "Νίκος", "Παπαδόπουλος" },
                    { 78, "Αρτέμης", "Σώρρας" },
                    { 79, "Ευαγγελία", "Παπαθανασίου" },
                    { 80, "Γιάννης", "Φουντουλάκης" },
                    { 81, "Χρυσάνθη", "Σταυροπούλου" },
                    { 82, "Φανούρης", "Βεζυρτζόγλου" },
                    { 83, "Λένα", "Ζευγαρά" },
                    { 84, "Αχιλλέας", "Μιχαηλίδης" },
                    { 85, "Γεωργία", "Καραγιάννη" },
                    { 86, "Δημήτρης", "Μαυρογένης" },
                    { 87, "Ελευθερία", "Τσιάμη" },
                    { 88, "Χάρης", "Γεωργιάδης" },
                    { 89, "Πέγκυ", "Σιδηροπούλου" },
                    { 90, "Νεκτάριος", "Τσαμισόπουλος" },
                    { 91, "Αργυρώ", "Παπαστεργίου" },
                    { 92, "Σάκης", "Ρουβάς" },
                    { 93, "Αναστασία", "Καρανίκα" },
                    { 94, "Στέφανος", "Λάζαρος" },
                    { 95, "Νατάσσα", "Κωνσταντινίδη" },
                    { 96, "Μακάριος", "Χριστοδούλου" },
                    { 97, "Ζωζώ", "Σαπουντζάκη" }
                });

            migrationBuilder.InsertData(
                table: "SUBJECT",
                columns: new[] { "ID", "LABEL", "LABELEN" },
                values: new object[,]
                {
                    { 1, "Πληροφορική", "Informatics" },
                    { 2, "Μαθηματικά", "Mathematics" },
                    { 3, "Βιολογία", "Biology" },
                    { 4, "Φυσική", "Physics" },
                    { 5, "Χημεία", "Chemistry" },
                    { 6, "Πολιτική Οικονομία", "Political Economy" },
                    { 7, "Ιστορία", "History" },
                    { 8, "Φιλοσοφία", "Philosophy" },
                    { 9, "Ψυχολογία", "Psychology" },
                    { 10, "Γλωσσολογία", "Linguistics" },
                    { 11, "Αρχαιολογία", "Archaeology" },
                    { 12, "Πολιτικές Επιστήμες", "Political Science" },
                    { 13, "Κοινωνιολογία", "Sociology" }
                });

            migrationBuilder.InsertData(
                table: "TEACHER",
                columns: new[] { "ID", "FIRSTNAME", "LASTNAME" },
                values: new object[,]
                {
                    { 1, "Ελένη", "Ρόμπολα" },
                    { 2, "Ευθύμιος", "Αλέπης" },
                    { 3, "Ευστράτιος", "Δερμανούτσος" },
                    { 4, "Δημήτρης", "Φώτης" },
                    { 5, "Γεώργιος", "Μιχαλόπουλος" },
                    { 6, "Αθανάσιος", "Κατσαρός" },
                    { 7, "Κωνσταντίνος", "Κουτρούμπας" },
                    { 8, "Σοφία", "Πετρίδου" }
                });

            migrationBuilder.InsertData(
                table: "ASSIGNMENT",
                columns: new[] { "ID", "CLASSROOMID", "SUBJECTID", "TEACHERID" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 2, 1 },
                    { 3, 3, 3, 2 },
                    { 4, 4, 4, 2 },
                    { 5, 5, 5, 3 },
                    { 6, 6, 6, 3 },
                    { 7, 7, 7, 4 },
                    { 8, 8, 8, 4 },
                    { 9, 9, 9, 5 },
                    { 10, 10, 10, 5 },
                    { 11, 11, 11, 6 },
                    { 12, 12, 12, 6 },
                    { 13, 1, 13, 7 },
                    { 14, 2, 1, 7 },
                    { 15, 3, 2, 8 },
                    { 16, 4, 3, 8 },
                    { 17, 5, 4, 1 },
                    { 18, 6, 5, 2 },
                    { 19, 7, 6, 3 },
                    { 20, 8, 7, 4 },
                    { 21, 9, 8, 5 },
                    { 22, 10, 9, 6 },
                    { 23, 11, 10, 7 }
                });

            migrationBuilder.InsertData(
                table: "STUDENTCLASSROOM",
                columns: new[] { "CLASSROOMID", "STUDENTID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 3, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 3, 19 },
                    { 3, 20 },
                    { 3, 21 },
                    { 4, 22 },
                    { 4, 23 },
                    { 4, 24 },
                    { 4, 25 },
                    { 4, 26 },
                    { 4, 27 },
                    { 4, 28 },
                    { 5, 29 },
                    { 5, 30 },
                    { 5, 31 },
                    { 5, 32 },
                    { 5, 33 },
                    { 5, 34 },
                    { 5, 35 },
                    { 6, 36 },
                    { 6, 37 },
                    { 6, 38 },
                    { 6, 39 },
                    { 6, 40 },
                    { 6, 41 },
                    { 6, 42 },
                    { 7, 43 },
                    { 7, 44 },
                    { 7, 45 },
                    { 7, 46 },
                    { 7, 47 },
                    { 7, 48 },
                    { 7, 49 },
                    { 8, 50 },
                    { 8, 51 },
                    { 8, 52 },
                    { 8, 53 },
                    { 8, 54 },
                    { 8, 55 },
                    { 8, 56 },
                    { 9, 57 },
                    { 9, 58 },
                    { 9, 59 },
                    { 9, 60 },
                    { 9, 61 },
                    { 9, 62 },
                    { 9, 63 },
                    { 10, 64 },
                    { 10, 65 },
                    { 10, 66 },
                    { 10, 67 },
                    { 10, 68 },
                    { 10, 69 },
                    { 10, 70 },
                    { 11, 71 },
                    { 11, 72 },
                    { 11, 73 },
                    { 11, 74 },
                    { 11, 75 },
                    { 11, 76 },
                    { 11, 77 },
                    { 12, 78 },
                    { 12, 79 },
                    { 12, 80 },
                    { 12, 81 },
                    { 12, 82 },
                    { 12, 83 },
                    { 12, 84 },
                    { 1, 85 },
                    { 2, 86 },
                    { 3, 87 },
                    { 4, 88 },
                    { 5, 89 },
                    { 6, 90 },
                    { 7, 91 },
                    { 8, 92 },
                    { 9, 93 },
                    { 10, 94 },
                    { 11, 95 },
                    { 12, 96 },
                    { 1, 97 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ABSENCE_ASSIGNMENTID",
                table: "ABSENCE",
                column: "ASSIGNMENTID");

            migrationBuilder.CreateIndex(
                name: "IX_ABSENCE_STUDENTID",
                table: "ABSENCE",
                column: "STUDENTID");

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
                name: "IX_STUDENTCLASSROOM_CLASSROOMID",
                table: "STUDENTCLASSROOM",
                column: "CLASSROOMID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ABSENCE");

            migrationBuilder.DropTable(
                name: "STUDENTCLASSROOM");

            migrationBuilder.DropTable(
                name: "ASSIGNMENT");

            migrationBuilder.DropTable(
                name: "STUDENT");

            migrationBuilder.DropTable(
                name: "CLASSROOM");

            migrationBuilder.DropTable(
                name: "SUBJECT");

            migrationBuilder.DropTable(
                name: "TEACHER");

            migrationBuilder.DropPrimaryKey(
                name: "PK_APPSETTINGS",
                table: "APPSETTINGS");

            migrationBuilder.DeleteData(
                table: "APPSETTINGS",
                keyColumns: new[] { "SCHOOLLOGOURL", "SCHOOLNAME" },
                keyValues: new object[] { "https://5lykeiovyrona.gr/img/logo-mobile.png", "5ο Λύκειο Βύρωνα" });

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
    }
}
