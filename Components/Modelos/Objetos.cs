public enum Tipo_Entidad{
    Serie = 'S',
    Pelicula = 'P',
    Libro = 'L'
}

public class SeriePeliculasLibro{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string Pais { get; set; }= "";
    public string Lenguage { get; set; }="";
     public Tipo_Entidad Tipo {get; set;} = Tipo_Entidad.Serie;
    public string PhotoUrl { get; set; }= "";
    public string Resumen { get; set; }= "";
    public List<Personaje> personajes { get; set; } = new List<Personaje>();
}


public class Personaje{
    public int Id {get; set;}
    public string Nombre {get; set;} = "";
    public string Apodo {get; set;} = "";
    public string Raza {get; set;} = "";
    public string? Foto {get; set;}
    public int Edad {get; set;} = 0;
    public string Poder_caracteristico {get; set;} = "";
    public int Serie_Libro_Pelicula_Id {get; set;}
    public SeriePeliculasLibro SeriesPeliculasLibros {get; set;} = null;
}