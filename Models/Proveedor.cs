using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Enums;

namespace Models;
[Table("Provider")]
public class Proveedor
{
    [Key]
    public int IdProveedor { get; set; }
    [MaxLength(50)]
    [Required(ErrorMessage ="Ingrese el nombre")]
    public string Nombre { get; set; }
    [MaxLength(8,ErrorMessage ="El teléfono debe tener 8 carácteres")]
    [Required(ErrorMessage ="Ingrese el número de contacto")]
    public string Telefono { get; set; }
    [MaxLength(150)]
    [Required(ErrorMessage ="Ingrese la dirección")]
    [Column(TypeName ="varchar")]
    public string? Direccion { get; set; }
    [MaxLength(100)]
    public string? Correo { get; set; }
    public EstadoCatalogo Estado { get; set; } = EstadoCatalogo.Registrado;

    //Propiedad de navegacion
    public List<ProductoBase> ProductoBases { get; set; }
}
