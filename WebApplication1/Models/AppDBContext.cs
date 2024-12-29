using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;


namespace WebApplication1.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasMany(h => h.Habits)
                .WithOne(u => u.User)
                .HasForeignKey(j => j.UserIDD);

            modelBuilder.Entity<HabitCategory>()
                .HasMany(h => h.Habitss)
                .WithOne(c => c.Category)
                .HasForeignKey(g => g.HabitID);

            modelBuilder.Entity<UserReward>()
                .HasOne(r => r.reward)
                .WithMany(u => u.userRewards)
                .HasForeignKey(f => f.Rewarddid);

            modelBuilder.Entity<UserReward>()
                .HasOne(u => u.user)
                .WithMany(r => r.userRewards)
                .HasForeignKey(k => k.UserIDd);

            modelBuilder.Entity<UserReward>()
                   .HasKey(l => new { l.UserIDd, l.Rewarddid });
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Habit> Habits { get; set; }
        public DbSet<HabitCategory> HabitCategories { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<UserReward> userRewards { get; set; }
    }
}
