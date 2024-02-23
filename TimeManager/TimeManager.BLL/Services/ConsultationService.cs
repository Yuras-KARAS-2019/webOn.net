using Microsoft.EntityFrameworkCore;
using TimeManager.BLL.DTO.Consultation;
using TimeManager.BLL.Interfaces;
using TimeManager.DAL;

namespace TimeManager.BLL.Services;

public class ConsultationService : IConsultationService
{
    private readonly TimeManagerContext _context;
    public ConsultationService(TimeManagerContext context)
    {
        _context = context ?? throw new NullReferenceException(nameof(context));
    }
    public async Task<ICollection<ConsultationDto>> GetAllConsultationsAsync()
    {
        return await _context.Consultations
            .Select(x => new ConsultationDto
                {
                    Id = x.Id,
                    Priority = x.Priority,
                    Category = x.Category,
                    ConsultationDate = x.ConsultationDate
                })
            .ToListAsync();
    }

    public async Task<ConsultationDto> GetConsultationByUsersIdsAsync(int studentId, int teacherId)
    {
        var temp_consultation = await _context.Consultations
            .FirstOrDefaultAsync(x => 
                x.StudentId == studentId &&
                x.TeacherId == teacherId) ?? 
                throw new KeyNotFoundException($"Consultation does not exist");

        var result_consultation = new ConsultationDto
        {
            Id = temp_consultation.Id,
            Priority = temp_consultation.Priority,
            Category = temp_consultation.Category,
            ConsultationDate = temp_consultation.ConsultationDate

        };
        return result_consultation;
    }
}
