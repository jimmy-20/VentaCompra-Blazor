using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Inventario.Models.Enums;

namespace Inventario.Models;

public class Producto
{
    [Key]
    public int IdProducto { get; set; }

    [ForeignKey("ProductoBase")]
    public int IdBase { get; set; }

    [ForeignKey("ProductoContenido")]
    public int IdContainer { get; set; }
    
    public double Medida { get; set; } //cantidad de volumen
    public double Precio { get; set; }
    public string UrlImagen { get; set; }
    public int Existencia { get; set; }
    public EstadoCatalogo Estado { get; set; }

    //Propiedades de navegacion
    public ProductoBase ProductoBase { get; set; }
    public ProductoContenido ProductoContenido { get; set; }

    public string Nombre{
        get{
            return $"{ProductoBase.Nombre} {ProductoContenido.Modelo} {Medida} {ProductoContenido.Contenido}";
        }
    }
}
