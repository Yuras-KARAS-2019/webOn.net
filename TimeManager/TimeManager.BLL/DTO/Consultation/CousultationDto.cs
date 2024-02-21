using TimeManager.DAL.Enums;

namespace TimeManager.BLL.DTO.Consultation;

public class CousultationDto
{
    public int Id { get; set; }
    public PriorityLevel Priority { get; set; }
    public ConsultationCategory Category { get; set; }
    public DateTime ConsultationDate { get; set; }

}
