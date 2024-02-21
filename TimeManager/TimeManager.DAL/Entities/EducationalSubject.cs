namespace TimeManager.DAL.Entities;

public record EducationalSubject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
