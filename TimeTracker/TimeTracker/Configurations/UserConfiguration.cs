using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeTracker.Entities;

namespace TimeTracker.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
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
                .IsRequired().HasMaxLength(5);
            builder.Property(r => r.Login)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(r => r.Password)
                .IsRequired()
                .HasMaxLength(25);
            builder.HasMany(p => p.ActivityTemplates)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction); ;
            builder.HasMany(p => p.Activities)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction); 
        }
    }
}
