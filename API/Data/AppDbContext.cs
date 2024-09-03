using Microsoft.EntityFrameworkCore;
using UserSkillsAPI.Models;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

	public DbSet<User> Users { get; set; }
	public DbSet<Skill> Skills { get; set; }
	public DbSet<Project> Projects { get; set; }
	public DbSet<UserSkill> UserSkills { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<UserSkill>()
			.HasKey(us => new { us.UserId, us.SkillId });

		modelBuilder.Entity<UserSkill>()
			.HasOne(us => us.User)
			.WithMany(u => u.UserSkills)
			.HasForeignKey(us => us.UserId);

		modelBuilder.Entity<UserSkill>()
			.HasOne(us => us.Skill)
			.WithMany(s => s.UserSkills)
			.HasForeignKey(us => us.SkillId);
	}
}
