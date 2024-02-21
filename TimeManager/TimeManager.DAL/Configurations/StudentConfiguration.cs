using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeManager.DAL.Entities;

namespace TimeManager.DAL.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired();

        builder.Property(x => x.LastName)
            .IsRequired();

        builder.Property(x => x.GroupName)
            .IsRequired();

        builder.Property(x => x.Email)
            .IsRequired();

        builder.HasAlternateKey(x => x.Email);

        builder.Property(x => x.Password)
            .IsRequired();
    }
}
