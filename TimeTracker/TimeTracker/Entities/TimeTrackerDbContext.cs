using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Entities
{
    public class TimeTrackerDbContext: DbContext
    {
        private string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=TimeTrackerDb;Trusted_Connection=True;";
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityTemplate> ActivityTemplates { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Activity
            modelBuilder.Entity<Activity>()
                .Property(r => r.DateFrom)
                .IsRequired();
            modelBuilder.Entity<Activity>()
                .Property(r => r.DateTo)
                .IsRequired();
            modelBuilder.Entity<Activity>()
               .Property(r => r.ModifiedBy)
               .IsRequired();
            modelBuilder.Entity<Activity>()
                .Property(r => r.CreatedBy)
                .IsRequired();
            modelBuilder.Entity<Activity>()
                .Property(r => r.ActivityTemplateId)
                .IsRequired();
            #endregion

            #region ActivityTemplate
            modelBuilder.Entity<ActivityTemplate>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<ActivityTemplate>()
                .Property(r => r.ModifiedBy)
                .IsRequired();
            modelBuilder.Entity<ActivityTemplate>()
                .Property(r => r.CreatedBy)
                .IsRequired();
            modelBuilder.Entity<ActivityTemplate>()
                .Property(r => r.CategoryId)
                .IsRequired();
            #endregion

            #region Category
            modelBuilder.Entity<Category>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(50);
            #endregion

            #region User
            modelBuilder.Entity<User>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(r => r.Surname)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(r => r.Email)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(r => r.Role)
                .IsRequired().HasMaxLength(5);
            modelBuilder.Entity<User>()
                .Property(r => r.Login)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(r => r.Password)
                .IsRequired()
                .HasMaxLength(25);
            #endregion
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
