using Microsoft.EntityFrameworkCore;

public class SerieContext: DbContext{

    public DbSet<SeriePeliculasLibro> SeriePeliculasLibros {get; set;} = null;
    public DbSet<Personaje> Personaje {get; set;} = null;

    public SerieContext(DbContextOptions<SerieContext> options)
    : base(options) {}
}