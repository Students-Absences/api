using api.Models;

namespace api.Services;

static class Services
{
    public static List<Absence> GetAbsences(AppDbContext context)
        => context.Absences.ToList();

    public static AppSettings GetAppSettings(AppDbContext context)
        => context.AppSettings.First();

    public static List<Assignment> GetAssignments(AppDbContext context)
        => context.Assignments.ToList();

    public static List<Student> GetStudents(AppDbContext context)
        => context.Students.ToList();

    public static List<StudentClassroom> GetStudentClassrooms(AppDbContext context)
        => context.StudentClassrooms.ToList();

    public static List<ListItem> GetTeachers(AppDbContext context)
        => context.Teachers.Select(t => new ListItem {
            Id = t.Id,
            Label = $"{t.FirstName} {t.LastName}",
            LabelEn = $"{t.FirstName} {t.LastName}"
        }).ToList();
}