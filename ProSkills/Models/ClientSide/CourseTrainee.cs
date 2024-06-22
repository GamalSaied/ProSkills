using ProSkills.Models.ClientSide.Enumerators;
using System.ComponentModel.DataAnnotations.Schema;

public class CourseTrainee
{
    public int Id { get; set; }

    [ForeignKey("Trainee")]
    public int TraineeId { get; set; }
    public Trainee Trainee { get; set; }

    [ForeignKey("Course")]
    public int CourseId { get; set; }
    public Course Course { get; set; }

    public decimal? Result { get; set; }
    public List<ActivityLog>? ActivitylogList { get; set; }
    public Level Level { get; set; } = Level.Beginner;
    public int Points { get; set; } = 0;
    public double CompletionRatio { get; set; } = 0;
}
