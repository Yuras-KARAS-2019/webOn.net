namespace TimeManager.BLL.DTO.User.Teacher;

public record TeacherDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}
