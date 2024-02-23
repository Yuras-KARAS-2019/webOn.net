using TimeManager.BLL.DTO.Consultation;

namespace TimeManager.BLL.Interfaces;

public interface IConsultationService
{
    Task<ICollection<ConsultationDto>> GetAllConsultationsAsync();
    Task<ConsultationDto> GetConsultationByUsersIdsAsync(int studentId, int teacherId);

}
