using Microsoft.EntityFrameworkCore;
using SocialHackApi.Models;

namespace SocialHackApi
{
    public class SocialHackContext : DbContext
    {
        public SocialHackContext(DbContextOptions<SocialHackContext> options) : base(options)
        {
            
        }

        public DbSet<CityObject> CityObjects { get; set; }
        public DbSet<CityTask> CityTasks { get; set; }
        public DbSet<DisabilityType> DisabilityTypes { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<FeedbackType> FeedbackTypes { get; set; }
        public DbSet<ObjectAttributeSatisfaction> ObjectAttributeSatisfactions { get; set; }
        public DbSet<ObjectCategory> ObjectCategories { get; set; }
        public DbSet<ObjectFeedback> ObjectFeedbacks { get; set; }
        public DbSet<ObjectScore> ObjectScores { get; set; }
        public DbSet<PlaceCategory> PlaceCategories { get; set; }
        public DbSet<PlaceElement> PlaceElements { get; set; }
        public DbSet<PlaceElementAttribute> PlaceElementAttributes { get; set; }
        public DbSet<TaskPlaceElement> TaskPlaceElements { get; set; }
        public DbSet<TaskStatus> TaskStatuses { get; set; }
        public DbSet<User> Users { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
            // modelBuilder.Entity<CityTask>().HasOne<CityObject>().WithMany().HasPrincipalKey(x => x.Id)
                // .HasForeignKey(x => x.ObjectId);
            // modelBuilder.Entity<CityTask>().HasMany(x=>x.TaskPlaceElements).WithOne().HasPrincipalKey(x => x.Id)
                // .HasForeignKey(x => x.TaskId);
        // }
    }
}