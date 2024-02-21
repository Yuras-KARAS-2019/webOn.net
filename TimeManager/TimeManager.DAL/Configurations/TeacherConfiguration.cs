using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeManager.DAL.Entities;

namespace TimeManager.DAL.Configurations;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.Property(x => x.Name).IsRequired();

        builder.Property(x => x.LastName).IsRequired();

        builder.Property(x => x.Email).IsRequired();

        builder.HasAlternateKey(x => x.Email);

        builder.Property(x => x.Password).IsRequired();
    }
}
