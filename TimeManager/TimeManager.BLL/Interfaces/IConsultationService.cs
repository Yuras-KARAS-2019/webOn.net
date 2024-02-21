using TimeManager.DAL.Entities;

namespace TimeManager.BLL.Interfaces;

public interface IConsultationService
{
    Task<ICollection<Consultation>> GetAllConsultatiosAsync();
    Task<ICollection<Consultation>> GetConsultatiosByUsersAsync(int studentId, int teacherId);
}
