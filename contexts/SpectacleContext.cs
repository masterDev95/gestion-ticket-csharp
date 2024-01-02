using Microsoft.EntityFrameworkCore;

public class SpectacleContext : DbContext
{
    public DbSet<Spectacle> Spectacles { get; set; }
    public DbSet<Utilisateur> Utilisateurs { get; set; }
    public DbSet<Billet> Billets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=ProjetEntityFramework;TrustServerCertificate=True;User Id=sa;Password=Alexis95110!");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Spectacle>().ToTable("Spectacles");
        modelBuilder.Entity<Utilisateur>().ToTable("Utilisateurs");
        modelBuilder.Entity<Billet>().ToTable("Billets");

        modelBuilder.Entity<Spectacle>()
            .HasKey(s => s.ID);

        modelBuilder.Entity<Utilisateur>()
            .HasKey(u => u.ID);

        modelBuilder.Entity<Billet>()
            .HasKey(b => b.ID);

        modelBuilder.Entity<Billet>()
            .HasOne(b => b.Spectacle)
            .WithMany(s => s.Billets);

        modelBuilder.Entity<Billet>()
            .HasOne(b => b.Utilisateur)
            .WithMany(u => u.HistoriqueReservations);
    }
}
