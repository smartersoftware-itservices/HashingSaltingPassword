using Microsoft.EntityFrameworkCore;

public class AppDataContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=HashingApp;Integrated Security=True;");
    }

    public DbSet<User> Users { get; set; }
}