using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
   
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Table> Tables { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Server=localhost;Database=dbresto;User ID=MUMU;Password=mumu1234;";
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        
    }
}