using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table("Category")]
public class Categoria
{
    [Key]
    public int IdCategoria { get; set; }
    [MaxLength(50)]
    [Required(ErrorMessage ="Introduzca el nombre de la categoria")]
    public string Nombre { get; set; }
    [MaxLength(300)]
    public string Descripcion { get; set; }
    
    //Propiedades de navegacion
    public List<ProductoBase> ProductoBases { get; set; }
}
