using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeManager.DAL.Entities;

namespace TimeManager.DAL.Configurations;

public class ConsultationConfiguration : IEntityTypeConfiguration<Consultation>
{
    public void Configure(EntityTypeBuilder<Consultation> builder)
    {
        builder.Property(x => x.Priority).IsRequired();

        builder.Property(x => x.Category).IsRequired();

        builder.Property(x => x.ConsultationDate).IsRequired();

        builder.HasOne(x => x.Student)
            .WithMany(y => y.Consultations)
            .HasForeignKey(x => x.StudentId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Teacher)
            .WithMany(y => y.Consultations)
            .HasForeignKey(y => y.TeacherId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Subject)
            .WithMany(y => y.Consultations)
            .HasForeignKey(x => x.SubjectId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
