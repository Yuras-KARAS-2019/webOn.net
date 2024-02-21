using TimeManager.DAL.Enums;

namespace TimeManager.BLL.DTO.Consultation;

public class CreateConsultationDto
{
    public PriorityLevel Priority { get; set; }
    public ConsultationCategory Category { get; set; }
    public DateTime ConsultationDate { get; set; }
    public int StudentId { get; set; }
    public int TeacherId { get; set; }
    public int SubjectId { get; set; }
}
