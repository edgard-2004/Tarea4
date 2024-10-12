using Microsoft.EntityFrameworkCore;

public class SeriesContext : DbContext
{
    public DbSet<SeriePeliculaLibro> SeriePeliculaLibros {get;set;}
    public DbSet<Personaje> Personajes {get;set;}

    public SeriesContext(DbContextOptions<SeriesContext>options) : base(options){}
    
}