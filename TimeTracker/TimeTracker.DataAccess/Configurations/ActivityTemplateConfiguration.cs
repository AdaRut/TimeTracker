using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeTracker.DataAccess.Entities;

namespace TimeTracker.DataAccess.Configurations
{
    public class ActivityTemplateConfiguration : IEntityTypeConfiguration<ActivityTemplate>
    {
        public void Configure(EntityTypeBuilder<ActivityTemplate> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            builder.Property(r => r.ModifiedBy)
                .IsRequired(false);
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
                .IsRequired(false);
            builder.HasMany(r => r.Activities)
                .WithOne(r => r.ActivityTemplate)
                .HasForeignKey(r => r.ActivityTemplateId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
