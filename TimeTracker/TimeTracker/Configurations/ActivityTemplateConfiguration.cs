using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeTracker.Entities;

namespace TimeTracker.Configurations
{
    public class ActivityTemplateConfiguration : IEntityTypeConfiguration<ActivityTemplate>
    {
        public void Configure(EntityTypeBuilder<ActivityTemplate> builder)
        {
            builder.Property(r => r.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            builder.Property(r => r.ModifiedBy)
                .IsRequired();
            builder.Property(r => r.CreatedBy)
                .IsRequired();
            builder.Property(r => r.CategoryId)
                .IsRequired();
            builder.Property(r => r.IsDeleted)
                .IsRequired();
            builder.Property(r => r.UserId)
                .IsRequired();
            builder.Property(r => r.CreationDate)
                .IsRequired();
            builder.Property(r => r.ModificationDate)
                .IsRequired();
            builder.HasMany(p => p.Activities)
                .WithOne(p => p.ActivityTemplate)
                .HasForeignKey(p => p.ActivityTemplateId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
