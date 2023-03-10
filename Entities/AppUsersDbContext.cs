using Microsoft.EntityFrameworkCore;

namespace WAITSAdminPanelExercise.Entities;

public class AppUsersDbContext : DbContext
{
	public DbSet<AppUsers>? AppUsers { set; get; }

	public AppUsersDbContext(DbContextOptions options) : 
        base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
	}
}