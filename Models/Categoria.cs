using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace APIPelicula.Models;

public partial class Categoria
{
    public int IdCategoria { get; set; }

    public string? Nombre { get; set; }
    [JsonIgnore]
    public virtual ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
}
