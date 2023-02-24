using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table("CategoryProduct")]
public class Category
{
    [Key]
    public int IdCategory { get; set; }
    [MaxLength(50)]
    [Required(ErrorMessage ="Introduzca el nombre de la Category")]
    public string Name { get; set; }
    [MaxLength(300)]
    public string Description { get; set; }
    
    //Propiedades de navegacion
    public List<BaseProduct> BaseProducts { get; set; }
}
