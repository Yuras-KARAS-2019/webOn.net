﻿namespace TimeManager.BLL.DTO.User.Teacher;

public record CreateTeacherDto
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
