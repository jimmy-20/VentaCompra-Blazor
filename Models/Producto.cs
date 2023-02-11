using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Inventario.Models.Enums;

namespace Inventario.Models;

public class Producto
{
    [Key]
    public int IdProducto { get; set; }
    public int IdBase { get; set; }
    public int IdContainer { get; set; }
    public double Medida { get; set; }
    public double Precio { get; set; }
    public int Existencia { get; set; }
    public EstadoCatalogo Estado { get; set; }

    //Propiedades de navegacion
    public ProductoBase ProductoBase { get; set; }
    public ProductoContenido ProductoContenido { get; set; }
}
