using System.ComponentModel.DataAnnotations;
using InventarioBlazor.Models.Enums;

namespace InventarioBlazor.Models;
public class Proveedor
{
    [Key]
    public int IdProveedor { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string? Direccion { get; set; }
    public string? Correo { get; set; }
    public EstadoCatalogo Estado { get; set; }

    //Propiedad de navegacion
    public List<ProductoBase> ProductoBases { get; set; }
}
