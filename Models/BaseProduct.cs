using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table("BaseProduct")]
public class BaseProduct
{
    [Key]
    public int IdBase { get; set; }

    [ForeignKey("Category")]
    public int IdCategory { get; set; }

    [ForeignKey("Provider")]
    public int IdProvider { get; set; }
    [MaxLength(50)]
    [Required(ErrorMessage ="Ingrese el tipo de Product")]
    public string Name { get; set; }

    //Propiedades de Navegacion
    public Category Category { get; set; }
    public Provider Provider { get; set; }
    public List<Product> Products { get; set; }
}
