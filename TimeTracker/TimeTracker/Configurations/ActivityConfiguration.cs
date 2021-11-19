﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeTracker.Entities;

namespace TimeTracker.Configurations
{
    public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.Property(r => r.DateFrom)
                .IsRequired();
            builder.Property(r => r.DateTo)
                .IsRequired();
            builder.Property(r => r.ModifiedBy)
               .IsRequired();
            builder.Property(r => r.CreatedBy)
                .IsRequired();
            builder.Property(r => r.ActivityTemplateId)
                .IsRequired();
            builder.Property(r => r.IsDeleted)
                .IsRequired();
            builder.Property(r => r.UserId)
                .IsRequired();
            builder.Property(r => r.CreationDate)
                .IsRequired();
            builder.Property(r => r.ModificationDate)
                .IsRequired();
        }
    }
}