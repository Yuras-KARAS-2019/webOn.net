namespace TimeManager.BLL.DTO.User.Student;

public record StudentDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string GroupName { get; set; }
    public string Email { get; set; }
}
