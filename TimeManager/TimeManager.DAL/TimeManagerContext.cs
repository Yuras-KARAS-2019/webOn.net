using Microsoft.EntityFrameworkCore;
using TimeManager.DAL.Entities;
using TimeManager.DAL.Extensions;

namespace TimeManager.DAL
{
    public class TimeManagerContext : DbContext
    {
        public virtual DbSet<Student> Students { get; private set; }
        public virtual DbSet<EducationalSubject> EducationalSubjects { get; private set; }
        public virtual DbSet<ConsultationAppointment> ConsultationAppointments { get; private set; }

        public TimeManagerContext(DbContextOptions<TimeManagerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Configure();
            modelBuilder.Seed();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

    }
}
