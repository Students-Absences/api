using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api.Models;

[Table("ABSENCE")]
class Absence
{
    [Key]
    [Column("ID")]
    public required int Id { get; set; }

    [Required]
    [JsonIgnore]
    [Column("HOUR")]
    public int Hour => this.DateIn.Hour; // TODO: Get the school hour from this

    [Required]
    [JsonIgnore]
    [Column("DAY")]
    public int Day => this.DateIn.Day;

    [Required]
    [JsonIgnore]
    [Column("MONTH")]
    public int Month => this.DateIn.Month;

    [Required]
    [JsonIgnore]
    [Column("YEAR")]
    public int Year => this.DateIn.Year;

    [Required]
    [Column("ASSIGNMENTID")]
    public required int AssignmentId { get; set; }

    [Required]
    [Column("STUDENTID")]
    public required int StudentId { get; set;}

    [NotMapped]
    public required DateTime DateIn { get; set; }
}