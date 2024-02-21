namespace TimeManager.DAL.Entities;

public record TeacherSubject
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public int TeacherId { get; set; }
    public int SubjectId { get; set; }

    public virtual Teacher Teacher { get; set; }
    public virtual EducationalSubject Subject { get; set; }

}
