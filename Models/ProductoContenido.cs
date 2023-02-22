using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table("ContentProduct")]
public class ProductoContenido
{
    [Key]
    public int IdContenido { get; set; }
    [MaxLength(30)]
    [Required(ErrorMessage ="Ingrese el tipo de presentación del producto")]
    public string Modelo { get; set; } //Retornable
    [MaxLength(30)]
    [Required(ErrorMessage ="Falta la unidad de medida(Litro, gramos, etc)")]
    public string Contenido { get; set; } //Litro por ejemplo

    //Propiedad de navegacion
    public List<Producto> Productos { get; set; }
}
