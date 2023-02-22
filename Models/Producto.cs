using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Enums;

namespace Models;

[Table("Product")]
public class Producto
{
    [Key]
    public int IdProducto { get; set; }

    [ForeignKey("ProductoBase")]
    public int IdBase { get; set; }

    [ForeignKey("ProductoContenido")]
    public int IdContainer { get; set; }
    
    [Required(ErrorMessage ="Falta el volumen del producto")]
    public double Medida { get; set; } //cantidad de volumen
    [Required(ErrorMessage ="Introduzca el precio del producto")]
    public double Precio { get; set; }
    public string UrlImagen { get; set; }
    public int Existencia { get; set; } = 0;
    
    public EstadoCatalogo Estado { get; set; } = EstadoCatalogo.Registrado;

    //Propiedades de navegacion
    public ProductoBase ProductoBase { get; set; }
    public ProductoContenido ProductoContenido { get; set; }

    [NotMapped]
    public string Nombre{
        get{
            return $"{ProductoBase.Nombre} {ProductoContenido.Modelo} {Medida} {ProductoContenido.Contenido}";
        }
    }
}
