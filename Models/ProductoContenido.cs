using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventarioBlazor.Models;

public class ProductoContenido
{
    [Key]
    public int IdContenido { get; set; }
    public string Modelo { get; set; } //Retornable
    public string Contenido { get; set; } //Litro por ejemplo

    //Propiedad de navegacion
    public List<Producto> Productos { get; set; }
}
