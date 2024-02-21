using TimeManager.DAL.Enums;

namespace TimeManager.DAL.Entities;

public record Consultation
{
    public int Id { get; set; }
    public PriorityLevel Priority { get; set; }
    public ConsultationCategory Category { get; set; }
    public DateTime ConsultationDate { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;

    public int StudentId { get; set; }
    public int TeacherId { get; set; }
    public int SubjectId { get; set; }

    public virtual Student Student { get; set; }
    public virtual Teacher Teacher { get; set; }
    public virtual EducationalSubject Subject { get; set; }

}
