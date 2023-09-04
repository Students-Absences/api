using api.Models;
using Microsoft.EntityFrameworkCore;

class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppSettings>().HasData(
            new {
                SchoolName = "5ο Λύκειο Βύρωνα",
                SchoolLogoUrl = "https://5lykeiovyrona.gr/img/logo-mobile.png"
            }
        );

        modelBuilder.Entity<Assignment>().HasData(
            new { Id = 1, ClassroomId = 1, SubjectId = 1, TeacherId = 1 },
            new { Id = 2, ClassroomId = 2, SubjectId = 2, TeacherId = 1 },
            new { Id = 3, ClassroomId = 3, SubjectId = 3, TeacherId = 2 },
            new { Id = 4, ClassroomId = 4, SubjectId = 4, TeacherId = 2 },
            new { Id = 5, ClassroomId = 5, SubjectId = 5, TeacherId = 3 },
            new { Id = 6, ClassroomId = 6, SubjectId = 6, TeacherId = 3 },
            new { Id = 7, ClassroomId = 7, SubjectId = 7, TeacherId = 4 },
            new { Id = 8, ClassroomId = 8, SubjectId = 8, TeacherId = 4 },
            new { Id = 9, ClassroomId = 9, SubjectId = 9, TeacherId = 5 },
            new { Id = 10, ClassroomId = 10, SubjectId = 10, TeacherId = 5 },
            new { Id = 11, ClassroomId = 11, SubjectId = 11, TeacherId = 6 },
            new { Id = 12, ClassroomId = 12, SubjectId = 12, TeacherId = 6 },
            new { Id = 13, ClassroomId = 1, SubjectId = 13, TeacherId = 7 },
            new { Id = 14, ClassroomId = 2, SubjectId = 1, TeacherId = 7 },
            new { Id = 15, ClassroomId = 3, SubjectId = 2, TeacherId = 8 },
            new { Id = 16, ClassroomId = 4, SubjectId = 3, TeacherId = 8 },
            new { Id = 17, ClassroomId = 5, SubjectId = 4, TeacherId = 1 },
            new { Id = 18, ClassroomId = 6, SubjectId = 5, TeacherId = 2 },
            new { Id = 19, ClassroomId = 7, SubjectId = 6, TeacherId = 3 },
            new { Id = 20, ClassroomId = 8, SubjectId = 7, TeacherId = 4 },
            new { Id = 21, ClassroomId = 9, SubjectId = 8, TeacherId = 5 },
            new { Id = 22, ClassroomId = 10, SubjectId = 9, TeacherId = 6 },
            new { Id = 23, ClassroomId = 11, SubjectId = 10, TeacherId = 7 }
        );

        modelBuilder.Entity<Classroom>().HasData(
            new { Id = 1, Label = "Α1", LabelEn = "A1" },
            new { Id = 2, Label = "Α2", LabelEn = "A2" },
            new { Id = 3, Label = "Α3", LabelEn = "A3" },
            new { Id = 4, Label = "Α4", LabelEn = "A4" },
            new { Id = 5, Label = "Β1", LabelEn = "B1" },
            new { Id = 6, Label = "Β2", LabelEn = "B2" },
            new { Id = 7, Label = "Β3", LabelEn = "B3" },
            new { Id = 8, Label = "Β4", LabelEn = "B4" },
            new { Id = 9, Label = "Γ1", LabelEn = "C1" },
            new { Id = 10, Label = "Γ2", LabelEn = "C2" },
            new { Id = 11, Label = "Γ3", LabelEn = "C3" },
            new { Id = 12, Label = "Γ4", LabelEn = "C4" }
        );

        modelBuilder.Entity<Student>().HasData(
            new { Id = 1, FirstName = "Στρατής", LastName = "Δερμανούτσος" },
            new { Id = 2, FirstName = "Κάποιο", LastName = "Άτομο" },
            new { Id = 3, FirstName = "Δεύτερο", LastName = "Πρόσωπο" },
            new { Id = 4, FirstName = "Παρασκευάς", LastName = "Παναγιωτόπουλος" },
            new { Id = 5, FirstName = "Παναγιώτης", LastName = "Παρασκευόπουλος" },
            new { Id = 6, FirstName = "Μαρία", LastName = "Εκατερίνη" },
            new { Id = 7, FirstName = "Κατερίνα", LastName = "Μαριέτα" },
            new { Id = 8, FirstName = "Νίκος", LastName = "Παπαδόπουλος" },
            new { Id = 9, FirstName = "Ελένη", LastName = "Γεωργίου" },
            new { Id = 10, FirstName = "Γιώργος", LastName = "Ιωάννου" },
            new { Id = 11, FirstName = "Σοφία", LastName = "Χριστοπούλου" },
            new { Id = 12, FirstName = "Δημήτρης", LastName = "Κοντός" },
            new { Id = 13, FirstName = "Αναστασία", LastName = "Σπυρόπουλος" },
            new { Id = 14, FirstName = "Θανάσης", LastName = "Σταυρόπουλος" },
            new { Id = 15, FirstName = "Βασίλης", LastName = "Βασιλείου" },
            new { Id = 16, FirstName = "Αγγελική", LastName = "Στεφανίδου" },
            new { Id = 17, FirstName = "Κώστας", LastName = "Λεωνίδας" },
            new { Id = 18, FirstName = "Μαρίνα", LastName = "Κυριακού" },
            new { Id = 19, FirstName = "Αλέξης", LastName = "Τσίπρας" },
            new { Id = 20, FirstName = "Δέσποινα", LastName = "Μάρκου" },
            new { Id = 21, FirstName = "Πέτρος", LastName = "Γεωργακόπουλος" },
            new { Id = 22, FirstName = "Ευαγγελία", LastName = "Μήτσου" },
            new { Id = 23, FirstName = "Χρήστος", LastName = "Ανδρόπουλος" },
            new { Id = 24, FirstName = "Ελισάβετ", LastName = "Μακρή" },
            new { Id = 25, FirstName = "Φώτης", LastName = "Κολοκοτρώνης" },
            new { Id = 26, FirstName = "Αικατερίνη", LastName = "Μπαλτά" },
            new { Id = 27, FirstName = "Στέλιος", LastName = "Σταματόπουλος" },
            new { Id = 28, FirstName = "Μαργαρίτα", LastName = "Μανώλης" },
            new { Id = 29, FirstName = "Ανδρέας", LastName = "Δημητρίου" },
            new { Id = 30, FirstName = "Χρυσάνθη", LastName = "Παπαγιάννη" },
            new { Id = 31, FirstName = "Λεωνίδας", LastName = "Μαρινάκης" },
            new { Id = 32, FirstName = "Φιλίππα", LastName = "Τσιάρα" },
            new { Id = 33, FirstName = "Μανώλης", LastName = "Στεφανάκης" },
            new { Id = 34, FirstName = "Βικτώρια", LastName = "Σαρρή" },
            new { Id = 35, FirstName = "Ευθύμης", LastName = "Κουτσούρης" },
            new { Id = 36, FirstName = "Πολυξένη", LastName = "Κοκκίνη" },
            new { Id = 37, FirstName = "Σπύρος", LastName = "Μητσότακης" },
            new { Id = 38, FirstName = "Ευάγγελος", LastName = "Βενιζέλος" },
            new { Id = 39, FirstName = "Ιωάννα", LastName = "Παπανδρέου" },
            new { Id = 40, FirstName = "Χριστίνα", LastName = "Καραμανλής" },
            new { Id = 41, FirstName = "Ελπίδα", LastName = "Σαμαράς" },
            new { Id = 42, FirstName = "Απόστολος", LastName = "Κυριάκος" },
            new { Id = 43, FirstName = "Ειρήνη", LastName = "Σολωμού" },
            new { Id = 44, FirstName = "Φαίδων", LastName = "Τσόγκας" },
            new { Id = 45, FirstName = "Χαρά", LastName = "Φραγκούλη" },
            new { Id = 46, FirstName = "Παντελής", LastName = "Παπαδημητρίου" },
            new { Id = 47, FirstName = "Σταυρούλα", LastName = "Αλεξίου" },
            new { Id = 48, FirstName = "Γεράσιμος", LastName = "Βλάχος" },
            new { Id = 49, FirstName = "Ολία", LastName = "Δανιηλίδου" },
            new { Id = 50, FirstName = "Λουκάς", LastName = "Παπαϊωάννου" },
            new { Id = 51, FirstName = "Νεφέλη", LastName = "Καλογεροπούλου" },
            new { Id = 52, FirstName = "Αντώνης", LastName = "Ρέμος" },
            new { Id = 53, FirstName = "Ζωή", LastName = "Κωνσταντόπουλος" },
            new { Id = 54, FirstName = "Διονύσης", LastName = "Σχοινάς" },
            new { Id = 55, FirstName = "Μελίνα", LastName = "Κανάκης" },
            new { Id = 56, FirstName = "Άρης", LastName = "Μπελονιάς" },
            new { Id = 57, FirstName = "Αγλαΐα", LastName = "Τσελίκα" },
            new { Id = 58, FirstName = "Κλέαρχος", LastName = "Σπυρόπουλος" },
            new { Id = 59, FirstName = "Δάφνη", LastName = "Φωκά" },
            new { Id = 60, FirstName = "Ηλίας", LastName = "Σκούφος" },
            new { Id = 61, FirstName = "Λαμπρινή", LastName = "Βιτσιλάκη" },
            new { Id = 62, FirstName = "Βαγγέλης", LastName = "Καπάτος" },
            new { Id = 63, FirstName = "Ναυσικά", LastName = "Πασχαλίδου" },
            new { Id = 64, FirstName = "Φοίβος", LastName = "Δεληβοριάς" },
            new { Id = 65, FirstName = "Μυρτώ", LastName = "Φράγκου" },
            new { Id = 66, FirstName = "Σπυρίδων", LastName = "Κολοκοτρώνης" },
            new { Id = 67, FirstName = "Φωτεινή", LastName = "Παπακωνσταντίνου" },
            new { Id = 68, FirstName = "Κώστας", LastName = "Λειβαδάς" },
            new { Id = 69, FirstName = "Φρόσω", LastName = "Πετράκη" },
            new { Id = 70, FirstName = "Ηλιάνα", LastName = "Τσακίρη" },
            new { Id = 71, FirstName = "Εμμανουήλ", LastName = "Κοτσόβος" },
            new { Id = 72, FirstName = "Βασιλική", LastName = "Σπυρίδη" },
            new { Id = 73, FirstName = "Ορέστης", LastName = "Ανδρούτσος" },
            new { Id = 74, FirstName = "Ελένη", LastName = "Κουτσούμπα" },
            new { Id = 75, FirstName = "Μάνος", LastName = "Χατζηδάκις" },
            new { Id = 76, FirstName = "Γλυκερία", LastName = "Μητσοτάκη" },
            new { Id = 77, FirstName = "Νίκος", LastName = "Παπαδόπουλος" },
            new { Id = 78, FirstName = "Αρτέμης", LastName = "Σώρρας" },
            new { Id = 79, FirstName = "Ευαγγελία", LastName = "Παπαθανασίου" },
            new { Id = 80, FirstName = "Γιάννης", LastName = "Φουντουλάκης" },
            new { Id = 81, FirstName = "Χρυσάνθη", LastName = "Σταυροπούλου" },
            new { Id = 82, FirstName = "Φανούρης", LastName = "Βεζυρτζόγλου" },
            new { Id = 83, FirstName = "Λένα", LastName = "Ζευγαρά" },
            new { Id = 84, FirstName = "Αχιλλέας", LastName = "Μιχαηλίδης" },
            new { Id = 85, FirstName = "Γεωργία", LastName = "Καραγιάννη" },
            new { Id = 86, FirstName = "Δημήτρης", LastName = "Μαυρογένης" },
            new { Id = 87, FirstName = "Ελευθερία", LastName = "Τσιάμη" },
            new { Id = 88, FirstName = "Χάρης", LastName = "Γεωργιάδης" },
            new { Id = 89, FirstName = "Πέγκυ", LastName = "Σιδηροπούλου" },
            new { Id = 90, FirstName = "Νεκτάριος", LastName = "Τσαμισόπουλος" },
            new { Id = 91, FirstName = "Αργυρώ", LastName = "Παπαστεργίου" },
            new { Id = 92, FirstName = "Σάκης", LastName = "Ρουβάς" },
            new { Id = 93, FirstName = "Αναστασία", LastName = "Καρανίκα" },
            new { Id = 94, FirstName = "Στέφανος", LastName = "Λάζαρος" },
            new { Id = 95, FirstName = "Νατάσσα", LastName = "Κωνσταντινίδη" },
            new { Id = 96, FirstName = "Μακάριος", LastName = "Χριστοδούλου" },
            new { Id = 97, FirstName = "Ζωζώ", LastName = "Σαπουντζάκη" }
        );

        modelBuilder.Entity<StudentClassroom>().HasData(
            new { StudentId = 1, ClassroomId = 1 },
            new { StudentId = 2, ClassroomId = 1 },
            new { StudentId = 3, ClassroomId = 1 },
            new { StudentId = 4, ClassroomId = 1 },
            new { StudentId = 5, ClassroomId = 1 },
            new { StudentId = 6, ClassroomId = 1 },
            new { StudentId = 7, ClassroomId = 1 },
            new { StudentId = 8, ClassroomId = 2 },
            new { StudentId = 9, ClassroomId = 2 },
            new { StudentId = 10, ClassroomId = 2 },
            new { StudentId = 11, ClassroomId = 2 },
            new { StudentId = 12, ClassroomId = 2 },
            new { StudentId = 13, ClassroomId = 2 },
            new { StudentId = 14, ClassroomId = 2 },
            new { StudentId = 15, ClassroomId = 3 },
            new { StudentId = 16, ClassroomId = 3 },
            new { StudentId = 17, ClassroomId = 3 },
            new { StudentId = 18, ClassroomId = 3 },
            new { StudentId = 19, ClassroomId = 3 },
            new { StudentId = 20, ClassroomId = 3 },
            new { StudentId = 21, ClassroomId = 3 },
            new { StudentId = 22, ClassroomId = 4 },
            new { StudentId = 23, ClassroomId = 4 },
            new { StudentId = 24, ClassroomId = 4 },
            new { StudentId = 25, ClassroomId = 4 },
            new { StudentId = 26, ClassroomId = 4 },
            new { StudentId = 27, ClassroomId = 4 },
            new { StudentId = 28, ClassroomId = 4 },
            new { StudentId = 29, ClassroomId = 5 },
            new { StudentId = 30, ClassroomId = 5 },
            new { StudentId = 31, ClassroomId = 5 },
            new { StudentId = 32, ClassroomId = 5 },
            new { StudentId = 33, ClassroomId = 5 },
            new { StudentId = 34, ClassroomId = 5 },
            new { StudentId = 35, ClassroomId = 5 },
            new { StudentId = 36, ClassroomId = 6 },
            new { StudentId = 37, ClassroomId = 6 },
            new { StudentId = 38, ClassroomId = 6 },
            new { StudentId = 39, ClassroomId = 6 },
            new { StudentId = 40, ClassroomId = 6 },
            new { StudentId = 41, ClassroomId = 6 },
            new { StudentId = 42, ClassroomId = 6 },
            new { StudentId = 43, ClassroomId = 7 },
            new { StudentId = 44, ClassroomId = 7 },
            new { StudentId = 45, ClassroomId = 7 },
            new { StudentId = 46, ClassroomId = 7 },
            new { StudentId = 47, ClassroomId = 7 },
            new { StudentId = 48, ClassroomId = 7 },
            new { StudentId = 49, ClassroomId = 7 },
            new { StudentId = 50, ClassroomId = 8 },
            new { StudentId = 51, ClassroomId = 8 },
            new { StudentId = 52, ClassroomId = 8 },
            new { StudentId = 53, ClassroomId = 8 },
            new { StudentId = 54, ClassroomId = 8 },
            new { StudentId = 55, ClassroomId = 8 },
            new { StudentId = 56, ClassroomId = 8 },
            new { StudentId = 57, ClassroomId = 9 },
            new { StudentId = 58, ClassroomId = 9 },
            new { StudentId = 59, ClassroomId = 9 },
            new { StudentId = 60, ClassroomId = 9 },
            new { StudentId = 61, ClassroomId = 9 },
            new { StudentId = 62, ClassroomId = 9 },
            new { StudentId = 63, ClassroomId = 9 },
            new { StudentId = 64, ClassroomId = 10 },
            new { StudentId = 65, ClassroomId = 10 },
            new { StudentId = 66, ClassroomId = 10 },
            new { StudentId = 67, ClassroomId = 10 },
            new { StudentId = 68, ClassroomId = 10 },
            new { StudentId = 69, ClassroomId = 10 },
            new { StudentId = 70, ClassroomId = 10 },
            new { StudentId = 71, ClassroomId = 11 },
            new { StudentId = 72, ClassroomId = 11 },
            new { StudentId = 73, ClassroomId = 11 },
            new { StudentId = 74, ClassroomId = 11 },
            new { StudentId = 75, ClassroomId = 11 },
            new { StudentId = 76, ClassroomId = 11 },
            new { StudentId = 77, ClassroomId = 11 },
            new { StudentId = 78, ClassroomId = 12 },
            new { StudentId = 79, ClassroomId = 12 },
            new { StudentId = 80, ClassroomId = 12 },
            new { StudentId = 81, ClassroomId = 12 },
            new { StudentId = 82, ClassroomId = 12 },
            new { StudentId = 83, ClassroomId = 12 },
            new { StudentId = 84, ClassroomId = 12 },
            new { StudentId = 85, ClassroomId = 1 },
            new { StudentId = 86, ClassroomId = 2 },
            new { StudentId = 87, ClassroomId = 3 },
            new { StudentId = 88, ClassroomId = 4 },
            new { StudentId = 89, ClassroomId = 5 },
            new { StudentId = 90, ClassroomId = 6 },
            new { StudentId = 91, ClassroomId = 7 },
            new { StudentId = 92, ClassroomId = 8 },
            new { StudentId = 93, ClassroomId = 9 },
            new { StudentId = 94, ClassroomId = 10 },
            new { StudentId = 95, ClassroomId = 11 },
            new { StudentId = 96, ClassroomId = 12 },
            new { StudentId = 97, ClassroomId = 1 }
        );

        modelBuilder.Entity<Subject>().HasData(
            new { Id = 1, Label = "Πληροφορική", LabelEn = "Informatics" },
            new { Id = 2, Label = "Μαθηματικά", LabelEn = "Mathematics" },
            new { Id = 3, Label = "Βιολογία", LabelEn = "Biology" },
            new { Id = 4, Label = "Φυσική", LabelEn = "Physics" },
            new { Id = 5, Label = "Χημεία", LabelEn = "Chemistry" },
            new { Id = 6, Label = "Πολιτική Οικονομία", LabelEn = "Political Economy" },
            new { Id = 7, Label = "Ιστορία", LabelEn = "History" },
            new { Id = 8, Label = "Φιλοσοφία", LabelEn = "Philosophy" },
            new { Id = 9, Label = "Ψυχολογία", LabelEn = "Psychology" },
            new { Id = 10, Label = "Γλωσσολογία", LabelEn = "Linguistics" },
            new { Id = 11, Label = "Αρχαιολογία", LabelEn = "Archaeology" },
            new { Id = 12, Label = "Πολιτικές Επιστήμες", LabelEn = "Political Science" },
            new { Id = 13, Label = "Κοινωνιολογία", LabelEn = "Sociology" }
        );

        modelBuilder.Entity<Teacher>().HasData(
            new { Id = 1, FirstName = "Ελένη", LastName = "Ρόμπολα" },
            new { Id = 2, FirstName = "Ευθύμιος", LastName = "Αλέπης" },
            new { Id = 3, FirstName = "Ευστράτιος", LastName = "Δερμανούτσος" },
            new { Id = 4, FirstName = "Δημήτρης", LastName = "Φώτης" },
            new { Id = 5, FirstName = "Γεώργιος", LastName = "Μιχαλόπουλος" },
            new { Id = 6, FirstName = "Αθανάσιος", LastName = "Κατσαρός" },
            new { Id = 7, FirstName = "Κωνσταντίνος", LastName = "Κουτρούμπας" },
            new { Id = 8, FirstName = "Σοφία", LastName = "Πετρίδου" }
        );
    }

    public DbSet<Absence> Absences => Set<Absence>();
    public DbSet<AppSettings> AppSettings => Set<AppSettings>();
    public DbSet<Assignment> Assignments => Set<Assignment>();
    public DbSet<Classroom> Classrooms => Set<Classroom>();
    public DbSet<Student> Students => Set<Student>();
    public DbSet<StudentClassroom> StudentClassrooms => Set<StudentClassroom>();
    public DbSet<Subject> Subjects => Set<Subject>();
    public DbSet<Teacher> Teachers => Set<Teacher>();
}