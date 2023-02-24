using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table("ContentProduct")]
public class ContentProduct
{
    [Key]
    public int IdContent { get; set; }
    [MaxLength(30)]
    [Required(ErrorMessage ="Ingrese el tipo de presentación del Product")]
    public string Model { get; set; } //Retornable
    [MaxLength(30)]
    [Required(ErrorMessage ="Falta la unidad de medida(Litro, gramos, etc)")]
    public string Content { get; set; } //Litro por ejemplo

    //Propiedad de navegacion
    public List<Product> Products { get; set; }
}
