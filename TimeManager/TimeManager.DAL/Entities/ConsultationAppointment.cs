using TimeManager.DAL.Enums;

namespace TimeManager.DAL.Entities;

public record ConsultationAppointment
{
    public int Id { get; set; }
    public StudentPriority Priority { get; set; }
    public ConsultationCategory ConsultationCategory { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime Consultation { get; set; }

    public int StudentId { get; set; }
    public int TeacherId { get; set; }

    public virtual Student Student { get; set; }
    public virtual Teacher Teacher { get; set; }

}
