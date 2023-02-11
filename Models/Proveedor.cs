using Inventario.Models.Enums;

namespace Inventario.Models;
public class Proveedor
{
    public int IdProveedor { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public string Correo { get; set; }
    public EstadoCatalogo Estado { get; set; }

    //Propiedad de navegacion
    public List<ProductoBase> ProductoBases { get; set; }
}
