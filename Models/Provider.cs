using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Enums;

namespace Models;
[Table("Provider")]
public class Provider
{
    [Key]
    public int IdProvider { get; set; }
    [MaxLength(50)]
    [Required(ErrorMessage ="Ingrese el nombre")]
    public string Name { get; set; }

    [MaxLength(14,ErrorMessage ="El ruc debe contener 14 caracteres")]
    [Required]
    public string Ruc { get; set; }
    
    [MaxLength(8,ErrorMessage ="El teléfono debe tener 8 caracteres")]
    [Required(ErrorMessage ="Ingrese el número de contacto")]
    public string Phone { get; set; }
    [MaxLength(150)]
    [Required(ErrorMessage ="Ingrese la dirección")]
    public string? Address { get; set; }
    [MaxLength(100)]
    public string? Email { get; set; }
    public CatalogState State { get; set; } = CatalogState.Register;

    //Propiedad de navegacion
    public List<BaseProduct> BaseProducts { get; set; }
}
