using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventarioBlazor.Models;

public class ProductoBase
{
    [Key]
    public int IdBase { get; set; }

    [ForeignKey("Categoria")]
    public int IdCategoria { get; set; }

    [ForeignKey("Proveedor")]
    public int IdProveedor { get; set; }
    public string Nombre { get; set; }

    //Propiedades de Navegacion
    public Categoria Categoria { get; set; }
    public Proveedor Proveedor { get; set; }
    public List<Producto> Productos { get; set; }
}
