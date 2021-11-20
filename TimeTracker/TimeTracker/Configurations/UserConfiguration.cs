using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeTracker.Entities;

namespace TimeTracker.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Name)
                 .IsRequired()
                 .HasMaxLength(50);
            builder.Property(r => r.Surname)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(r => r.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(r => r.Role)
                .IsRequired()
                .HasMaxLength(5);
            builder.Property(r => r.Login)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(r => r.Password)
                .IsRequired()
                .HasMaxLength(25);
            builder.HasMany(r => r.ActivityTemplates)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.NoAction); ;
            builder.HasMany(r => r.Activities)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.NoAction); 
        }
    }
}
