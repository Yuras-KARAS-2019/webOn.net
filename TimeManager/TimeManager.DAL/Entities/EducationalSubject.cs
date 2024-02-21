namespace TimeManager.DAL.Entities;

public record EducationalSubject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;

    public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; } = new List<TeacherSubject>();
    public virtual ICollection<Consultation> Consultations { get; set; } = new List<Consultation>();
}
