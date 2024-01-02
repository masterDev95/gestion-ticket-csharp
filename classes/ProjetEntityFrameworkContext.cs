using Microsoft.EntityFrameworkCore;

namespace projet_entity_framework.classes;

public partial class ProjetEntityFrameworkContext : DbContext
{
    public DbSet<Spectacle> Spectacles { get; set; }
    
    public ProjetEntityFrameworkContext()
    {
    }

    public ProjetEntityFrameworkContext(DbContextOptions<ProjetEntityFrameworkContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost;Database=ProjetEntityFramework;TrustServerCertificate=True;User Id=sa;Password=Alexis95110!");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        => OnModelCreatingPartial(modelBuilder);

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
