public enum TipoEntidad
{
    Serie = 'S',
    Pelicula = 'P',
    Libro = 'L'
}

public class Personaje
{
    public int Id {get;set;}
    public string Nombre {get;set;} = string.Empty;
    public int Edad {get;set;}
    public string Apodo {get;set;} = string.Empty;
    public string Raza {get;set;} = string.Empty;
    public string Signozodiacal {get;set;} = string.Empty;
    public string FotoUrl{get;set;} = string.Empty;
    public string PoderCaracteristico {get;set;} = string.Empty;
    public int SeriePeliculaLibroId {get;set;}
    public SeriePeliculaLibro SeriePeliculaLibro{get;set;} = null!;
}

public class SeriePeliculaLibro
{
    public int Id {get;set;}
    public string Nombre {get;set;} = string.Empty;
    public TipoEntidad Tipo {get;set;} = TipoEntidad.Serie;
    public string Pais {get;set;} = string.Empty;
    public string Idioma {get;set;} = string.Empty;
    public string FotoUrl {get;set;} = string.Empty;
    public string Resumen {get;set;} = string.Empty;
    public List<Personaje> personajes {get;set;} = new List<Personaje>();
}