namespace api.Models;

class SyncIn
{
    public required int TeacherId { get; set; }
    public required string TeacherPin { get; set; }
    public required Absence[] Absences { get; set; }
}