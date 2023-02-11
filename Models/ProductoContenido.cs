using System.Collections.Generic;

namespace Inventario.Models;

public class ProductoContenido
{
    public int IdContenido { get; set; }
    public string Modelo { get; set; }
    public string Contenido { get; set; }

    //Propiedad de navegacion
    public List<Producto> Productos { get; set; }
}
