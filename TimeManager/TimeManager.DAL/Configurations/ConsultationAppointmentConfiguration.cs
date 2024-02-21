using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeManager.DAL.Entities;

namespace TimeManager.DAL.Configurations;

public class ConsultationAppointmentConfiguration : IEntityTypeConfiguration<ConsultationAppointment>
{
    public void Configure(EntityTypeBuilder<ConsultationAppointment> builder)
    {
        builder.Property(x => x.Priority).IsRequired();

        builder.Property(x => x.ConsultationCategory).IsRequired();

        builder.HasOne(x => x.Student)
            .WithMany(y => y.ConsultationAppointments)
            .HasForeignKey(x => x.StudentId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Teacher)
            .WithMany(y => y.ConsultationAppointments)
            .HasForeignKey(y => y.TeacherId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
