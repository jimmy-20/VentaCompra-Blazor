namespace Inventario.Models;

public class ProductoBase
{
    public int IdBase { get; set; }
    public int IdCategoria { get; set; }
    public int IdProveedor { get; set; }
    public string Nombre { get; set; }

    //Propiedades de Navegacion
    public Categoria Categoria { get; set; }
    public Proveedor Proveedor { get; set; }
    public List<Producto> Productos { get; set; }
}
