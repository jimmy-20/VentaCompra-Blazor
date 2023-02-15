using System.ComponentModel.DataAnnotations;

namespace InventarioBlazor.Models;

public class Categoria
{
    [Key]
    public int IdCategoria { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    
    //Propiedades de navegacion
    public List<ProductoBase> ProductoBases { get; set; }
}
