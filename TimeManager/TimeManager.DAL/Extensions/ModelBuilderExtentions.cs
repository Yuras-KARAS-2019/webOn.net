using Microsoft.EntityFrameworkCore;
using TimeManager.DAL.Entities;

namespace TimeManager.DAL.Extensions
{
    public static class ModelBuilderExtentions
    {
        public static void Configure(this ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(TimeManagerContext).Assembly);
        }

        public static void Seed(this ModelBuilder builder)
        {
            var users = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Name = "Roma",
                    LastName = "Durda",
                    GroupName = "IO-03",
                    Email = "Sniper2001@gmail.com",
                    Password = "QWERTY1234",
                },

                new Student
                {
                    Id = 2,
                    Name = "Nadia",
                    LastName = "Durda",
                    GroupName = "IO-04",
                    Email = "Killer1995@gmail.com",
                    Password = "QWERTY1234",
                }
            };

            var consultations = new List<Consultation>
            {

            };
            builder.Entity<Student>()
                .HasData(users);
            builder.Entity<Consultation>()
                .HasData(consultations);
        }
    }
}
