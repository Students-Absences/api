namespace api.Models;

class SyncOut
{
    public required AppSettings AppSettings { get; set; }
    public required List<Assignment> Assignments { get; set; }
    public required List<ListItem> Classrooms { get; set; }
    public required List<Student> Students { get; set; }
    public required List<StudentClassroom> StudentClassrooms { get; set; }
    public required List<ListItem> Subjects { get; set; }
    public required List<ListItem> Teachers { get; set; }
}