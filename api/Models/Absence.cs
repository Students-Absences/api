using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api.Models;

[Table("ABSENCE")]
class Absence
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [JsonIgnore]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [JsonIgnore]
    [Column("HOUR")]
    [Range(1, 31, MinimumIsExclusive = false, MaximumIsExclusive = false)]
    public int Hour {
        //? src = http://2lyk-pallin.att.sch.gr/?page_id=80
        get {
            if (this.DateIn.Hour == 8 || this.DateIn.Hour == 9 && this.DateIn.Minute <= 5)
                return 1;

            if (this.DateIn.Hour == 9 && this.DateIn.Minute > 5 || this.DateIn.Hour == 10 && this.DateIn.Minute == 0)
                return 2;

            if (this.DateIn.Hour == 10 && this.DateIn.Minute <= 55)
                return 3;

            if (this.DateIn.Hour == 10 && this.DateIn.Minute > 56 || this.DateIn.Hour == 11 && this.DateIn.Minute <= 50)
                return 4;

            if (this.DateIn.Hour == 11 && this.DateIn.Minute > 50 || this.DateIn.Hour == 12 && this.DateIn.Minute <= 40)
                return 5;

            if (this.DateIn.Hour == 12 && this.DateIn.Minute > 40 || this.DateIn.Hour == 13 && this.DateIn.Minute <= 30)
                return 6;

            return 7;
        }
        set {}
    }

    [Required]
    [JsonIgnore]
    [Column("DAY")]
    [Range(1, 31, MinimumIsExclusive = false, MaximumIsExclusive = false)]
    public int Day {
        get { return this.DateIn.Day; }
        set { }
    }

    [Required]
    [JsonIgnore]
    [Column("MONTH")]
    [Range(1, 12, MinimumIsExclusive = false, MaximumIsExclusive = false)]
    public int Month {
        get { return this.DateIn.Month; }
        set { }
    }

    [Required]
    [JsonIgnore]
    [Column("YEAR")]
    [Range(1970, 2024, MinimumIsExclusive = false, MaximumIsExclusive = false)]
    public int Year {
        get { return this.DateIn.Year; }
        set { }
    }

    [Required]
    [Column("ASSIGNMENTID")]
    public required int AssignmentId { get; set; }

    [Required]
    [Column("STUDENTID")]
    public required int StudentId { get; set;}

    [NotMapped]
    public required DateTime DateIn { get; set; }
}