using CodigoHincha.Domain.Auth;
using CodigoHincha.Domain.FileSystem;
using CodigoHincha.Domain.Post;
using CodigoHincha.Domain.Social;
using Microsoft.EntityFrameworkCore;
using File = CodigoHincha.Domain.FileSystem.File;

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
    public DbSet<Post> Posts => Set<Post>();
    public DbSet<File> Files => Set<File>();
    public DbSet<Image> Images => Set<Image>();

    public DbSet <Club> Clubs => Set<Club>();

    public DbSet <Follow> Follows => Set<Follow>();

    public DbSet <Ban> Bans => Set<Ban>();
    

}
