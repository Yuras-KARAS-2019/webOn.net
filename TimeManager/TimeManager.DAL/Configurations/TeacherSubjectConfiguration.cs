using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeManager.DAL.Entities;

namespace TimeManager.DAL.Configurations;

public class TeacherSubjectConfiguration : IEntityTypeConfiguration<TeacherSubject>
{
    public void Configure(EntityTypeBuilder<TeacherSubject> builder)
    {
        builder.Property(x => x.TeacherId).IsRequired();
        builder.Property(x => x.SubjectId).IsRequired();

        builder.HasOne(x => x.Teacher)
            .WithMany(y => y.TeacherSubjects)
            .HasForeignKey(x => x.TeacherId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Subject)
            .WithMany(y => y.TeacherSubjects)
            .HasForeignKey(y => y.SubjectId)
            .OnDelete(DeleteBehavior.NoAction);

    }
}
