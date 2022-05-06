using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository;

public class RepositoryContext : IdentityDbContext<User>
{
	public RepositoryContext(DbContextOptions options)
		: base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<User>(e =>
		{
			e.HasMany(p => p.Meals)
			.WithOne(p => p.User)
			.HasForeignKey(p => p.UserId);  // inherited from IdentityUserLogin
		});
		modelBuilder.Entity<Meal>(e =>
		{
			e.HasMany(p => p.Ingredients)
			.WithOne(p => p.Meal)
			.HasForeignKey(p => p.MealId)
			.OnDelete(DeleteBehavior.Cascade);// inherited from IdentityUserLogin
		});


		modelBuilder.ApplyConfiguration(new CompanyConfiguration());
		modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
		modelBuilder.ApplyConfiguration(new RoleConfiguration());
	}

	public DbSet<Company>? Companies { get; set; }
	public DbSet<Employee>? Employees { get; set; }

	public DbSet<Meal>? Meals { get; set; }
	public DbSet<Ingredient>? Ingredients { get; set; }
}
