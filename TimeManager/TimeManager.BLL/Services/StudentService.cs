using System.Security.Authentication;
using Microsoft.EntityFrameworkCore;
using TimeManager.BLL.DTO.User;
using TimeManager.BLL.DTO.User.Student;
using TimeManager.BLL.Interfaces;
using TimeManager.DAL;
using TimeManager.DAL.Entities;

namespace TimeManager.BLL.Services;

public class StudentService : IStudentService
{
    private readonly TimeManagerContext _context;

    public StudentService(TimeManagerContext context)
    {
        _context = context ?? throw new NullReferenceException(nameof(context));
    }

    public async Task<ICollection<StudentDto>> GetAllStudentsAsync()
    {
        return await _context.Students
            .Select(x => new StudentDto
            {
                Id = x.Id,
                Name = x.Name,
                LastName = x.LastName,
                GroupName = x.GroupName,
                Email = x.Email
            }).ToListAsync();
    }

    public async Task<StudentDto> GetStudentByIdAsync(int studentId)
    {
        var temp = await _context.Students.FirstOrDefaultAsync(x => x.Id == studentId) ??
             throw new KeyNotFoundException($"Student with id: {studentId} does not exist");
        var resultStudent = new StudentDto
        {
            Id = temp.Id,
            Name = temp.Name,
            LastName = temp.LastName,
            GroupName = temp.GroupName,
            Email = temp.Email
        };
        return resultStudent;
    }

    public async Task<StudentDto> GetStudentByCredentialsAsync(CredentialsDto dto)
    {
        var student = await _context.Students
            .FirstOrDefaultAsync(x => x.Email == dto.Email && x.Password == dto.Password) ??
            throw new AuthenticationException("Incorrect login or password");
        var resultStudent = new StudentDto
        {
            Id = student.Id,
            Name = student.Name,
            LastName = student.LastName,
            GroupName = student.GroupName,
            Email = student.Email
        };
        return resultStudent;
    }

    public async Task<StudentDto> CreateStudentAsync(CreateStudentDto dto)
    {
        var student = new Student
        {
            Name = dto.Name,
            LastName = dto.LastName,
            GroupName = dto.GroupName,
            Email = dto.Email,
            Password = dto.Password
        };
        await _context.Students.AddAsync(student);
        await _context.SaveChangesAsync();
        return new StudentDto
        {
            Id = student.Id,
            Name = student.Name,
            LastName = student.LastName,
            GroupName = student.GroupName,
            Email = student.Email
        };
    }
}
