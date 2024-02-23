using TimeManager.BLL.DTO.EducationalSubject;

namespace TimeManager.BLL.Interfaces;

public interface IEducationalSubjectService
{
    Task<EducationalSubjectDto> GetEducationalSubjectByIdAsync(int subjectId);
    Task<ICollection<EducationalSubjectDto>> GetEducationalSubjectsByNameAsync(string name);
    Task<ICollection<EducationalSubjectDto>> GetAllEducationalSubjectsAsync();
    Task<EducationalSubjectDto> CreateEducationalSubjectAsync(CreateEducationalSubjectDto dto);
}
