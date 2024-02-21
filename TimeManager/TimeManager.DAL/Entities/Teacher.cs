namespace TimeManager.DAL.Entities;

public record Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public virtual ICollection<ConsultationAppointment> ConsultationAppointments { get; set; } = new List<ConsultationAppointment>();
    public virtual ICollection<EducationalSubject> EducationalSubjects { get; set; } = new List<EducationalSubject>();

}

