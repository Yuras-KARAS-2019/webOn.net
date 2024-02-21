namespace TimeManager.DAL.Entities;

public record Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; } = new List<TeacherSubject>();
    public virtual ICollection<Consultation> Consultations { get; set; } = new List<Consultation>();

}

