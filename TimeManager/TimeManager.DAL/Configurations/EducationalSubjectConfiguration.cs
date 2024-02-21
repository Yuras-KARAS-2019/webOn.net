using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeManager.DAL.Entities;

namespace TimeManager.DAL.Configurations;

public class EducationalSubjectConfiguration : IEntityTypeConfiguration<EducationalSubject>
{
    public void Configure(EntityTypeBuilder<EducationalSubject> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired();

        builder.Property(x => x.Description)
            .IsRequired();

    }
}
