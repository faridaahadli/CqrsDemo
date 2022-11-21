using CqrsDemo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CqrsDemo.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Name).IsRequired().HasMaxLength(25).HasColumnName("name");
            builder.Property(x => x.Surname).IsRequired().HasMaxLength(15).HasColumnName("surname");
            builder.Property(x => x.Age).IsRequired().HasColumnName("age");

            builder.ToTable("users");   
        }
    }
}
