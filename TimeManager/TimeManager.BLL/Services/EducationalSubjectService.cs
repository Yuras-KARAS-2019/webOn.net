using Microsoft.EntityFrameworkCore;
using TimeManager.BLL.DTO.EducationalSubject;
using TimeManager.BLL.Interfaces;
using TimeManager.DAL;
using TimeManager.DAL.Entities;

namespace TimeManager.BLL.Services;

public class EducationalSubjectService : IEducationalSubjectService
{
    private readonly TimeManagerContext _context;

    public EducationalSubjectService(TimeManagerContext context)
    {
        _context = context ?? throw new NullReferenceException(nameof(context));
    }

    public async Task<ICollection<EducationalSubjectDto>> GetAllEducationalSubjectsAsync()
    {
        return await _context.EducationalSubjects
            .Select(x => new EducationalSubjectDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
            }).ToListAsync();
    }

    public async Task<EducationalSubjectDto> GetEducationalSubjectByIdAsync(int subjectId)
    {
        var subject = await _context.EducationalSubjects.FirstOrDefaultAsync(x => x.Id == subjectId) ??
             throw new KeyNotFoundException($"Educational subject with id: {subjectId} does not exist");
        var resultSubject = new EducationalSubjectDto
        {
            Id = subject.Id,
            Name = subject.Name,
            Description = subject.Description,
        };
        return resultSubject;
    }

    public async Task<ICollection<EducationalSubjectDto>> GetEducationalSubjectsByNameAsync(string name)
    {
        var subjects = await _context.EducationalSubjects
            .Where(x => x.Name.Contains(name))
            .Select(x => new EducationalSubjectDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
            })
            .ToListAsync();
        return subjects;
    }

    public async Task<EducationalSubjectDto> CreateEducationalSubjectAsync(CreateEducationalSubjectDto dto)
    {
        var subject = new EducationalSubject
        {
            Name = dto.Name,
            Description = dto.Description,
        };
        await _context.EducationalSubjects.AddAsync(subject);
        await _context.SaveChangesAsync();
        var resultSubject = new EducationalSubjectDto
        {
            Id = subject.Id,
            Name = subject.Name,
            Description = subject.Description,
        };
        return resultSubject;
    }
}
