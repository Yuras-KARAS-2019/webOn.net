using TimeManager.BLL.DTO.User;
using TimeManager.BLL.DTO.User.Student;

namespace TimeManager.BLL.Interfaces;

public interface IStudentService
{
    Task<ICollection<StudentDto>> GetAllStudentsAsync();
    Task<StudentDto> GetStudentByIdAsync(int studentId);
    Task<StudentDto> GetStudentByCredentialsAsync(CredentialsDto dto);
    Task<StudentDto> CreateStudentAsync(CreateStudentDto dto);
}
