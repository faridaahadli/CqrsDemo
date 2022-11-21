using CqrsDemo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CqrsDemo.Configurations
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Price).IsRequired().HasColumnName("price");
            builder.Property(x => x.UserId).IsRequired().HasColumnName("user_id");
           

            builder.ToTable("orders");
        }
    }
}
