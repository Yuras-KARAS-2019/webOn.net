using TimeManager.BLL.DTO.User;
using TimeManager.BLL.DTO.User.Teacher;

namespace TimeManager.BLL.Interfaces;

public interface ITeacherService
{
    Task<ICollection<TeacherDto>> GetAllTeachersAsync();
    Task<TeacherDto> GetTeacherByIdAsync(int id);
    Task<TeacherDto> GetTeacherByCredentialsAsync(CredentialsDto dto);
    Task<TeacherDto> CreateTeacherAsync(CreateTeacherDto dto);

}
