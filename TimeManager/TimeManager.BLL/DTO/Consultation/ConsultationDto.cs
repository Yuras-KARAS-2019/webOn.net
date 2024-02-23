using TimeManager.DAL.Enums;

namespace TimeManager.BLL.DTO.Consultation;

public class ConsultationDto
{
    public int Id { get; set; }
    public PriorityLevel Priority { get; set; }
    public ConsultationCategory Category { get; set; }
    public DateTime ConsultationDate { get; set; }

}
