using CodigoHincha.Domain.Auth;
using CodigoHincha.Domain.FileSystem;
using CodigoHincha.Domain.Social;
using Microsoft.EntityFrameworkCore;

namespace CodigoHincha.DAL.EntityFramework;

public class CodigoHinchaDbContext(DbContextOptions<CodigoHinchaDbContext> options)
    : DbContext(options)
{
    // Agregar DbSet<T> aquí a medida que se creen las entidades.
    // Ejemplo:
    // public DbSet<Usuario> Usuarios => Set<Usuario>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    
    }
    public DbSet<Comment> Comments => Set<Comment>();
    public DbSet<Reaction> Reactions => Set<Reaction>();
    public DbSet<User> Users => Set<User>();
    public DbSet<CodigoHincha.Domain.Post.Post> Posts => Set<CodigoHincha.Domain.Post.Post>();
    public DbSet<CodigoHincha.Domain.FileSystem.File> Files => Set<CodigoHincha.Domain.FileSystem.File>();
    public DbSet<CodigoHincha.Domain.FileSystem.Image> Images => Set<CodigoHincha.Domain.FileSystem.Image>();

    public DbSet <Club> Clubs => Set<Club>();

    public DbSet <Follow> Follows => Set<Follow>();

    public DbSet <Ban> Bans => Set<Ban>();
    

}
