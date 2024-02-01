using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace APIPelicula.Models;

public partial class Pelicula
{
    public int IdPelicula { get; set; }

    public int? IdCategoria { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Imagen { get; set; }
    [JsonIgnore]
    public virtual Categoria? IdCategoriaNavigation { get; set; }
}
