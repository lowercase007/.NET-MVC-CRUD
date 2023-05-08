

public class AppDbContext : DbContext

{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}
   