using System.Security.Authentication;
using Microsoft.EntityFrameworkCore;
using TimeManager.BLL.DTO.User;
using TimeManager.BLL.DTO.User.Teacher;
using TimeManager.BLL.Interfaces;
using TimeManager.DAL;
using TimeManager.DAL.Entities;

namespace TimeManager.BLL.Services;

public class TeacherService : ITeacherService
{
    private readonly TimeManagerContext _context;

    public TeacherService(TimeManagerContext context)
    {
        _context = context ?? throw new NullReferenceException(nameof(context));
    }
    public async Task<ICollection<TeacherDto>> GetAllTeachersAsync()
    {
        return await _context.Teachers
            .Select(x => new TeacherDto
            {
                Id = x.Id,
                Name = x.Name,
                LastName = x.LastName,
                Email = x.Email,
            }).ToListAsync();
    }

    public async Task<TeacherDto> GetTeacherByIdAsync(int id)
    {
        var teacher = await _context.Teachers.FirstOrDefaultAsync(x => x.Id == id) ??
            throw new KeyNotFoundException($"Teacher with id: {id} does not exist");
        var resultTeacher = new TeacherDto
        {
            Id = teacher.Id,
            Name = teacher.Name,
            LastName = teacher.LastName,
            Email = teacher.Email,
        };
        return resultTeacher;
    }

    public async Task<TeacherDto> GetTeacherByCredentialsAsync(CredentialsDto dto)
    {
        var teacher = await _context.Teachers
            .FirstOrDefaultAsync(x => x.Email == dto.Email && x.Password == dto.Password) ??
            throw new AuthenticationException("Incorrect login or password");

        var resultTeacher = new TeacherDto
        {
            Id = teacher.Id,
            Name = teacher.Name,
            LastName = teacher.LastName,
            Email = teacher.Email,
        };
        return resultTeacher;
    }

    public async Task<TeacherDto> CreateTeacherAsync(CreateTeacherDto dto)
    {
        var newTeacher = new Teacher
        {
            Name = dto.Name,
            LastName = dto.LastName,
            Email = dto.Email,
            Password = dto.Password,
        };
        await _context.Teachers.AddAsync(newTeacher);
        await _context.SaveChangesAsync();

        var resultTeacher = new TeacherDto
        {
            Id = newTeacher.Id,
            Name = newTeacher.Name,
            LastName = newTeacher.LastName,
            Email = newTeacher.Email,
        };
        return resultTeacher;
    }
}
