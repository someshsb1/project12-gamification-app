using Gamification.UI.Configurations.Entities;
using Gamification.UI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gamification.UI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
        {

        }
  

        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<TasksResponse> Responses { get; set; }
        public DbSet<Scores> Scores { get; set; }
        public DbSet<LeaderBoader> LeaderBoaders { get; set; }

        public DbSet<Message> Messages { get; set; } // Add the Messages DbSet

		 public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      builder.ApplyConfiguration(new RoleSeedConfiguration());
      builder.ApplyConfiguration(new UserSeedConfiguration());
      builder.ApplyConfiguration(new UserRoleSeedConfiguration());

        // Configure foreign key constraints
      builder.Entity<Message>()
            .HasOne(m => m.Receiver)
            .WithMany()
            .HasForeignKey(m => m.ReceiverID)
            .OnDelete(DeleteBehavior.Restrict); // Disable cascading delete

      builder.Entity<Message>()
            .HasOne(m => m.Sender)
            .WithMany()
            .HasForeignKey(m => m.SenderID)
            .OnDelete(DeleteBehavior.Restrict); // Disable cascading delete
      
    
    }

  }


}
