namespace TimeManager.BLL.DTO.User.Student;

public record CreateStudentDto
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string GroupName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
