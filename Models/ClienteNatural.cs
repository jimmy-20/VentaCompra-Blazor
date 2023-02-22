using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table("CustomerNature")]
public class ClienteNatural
{
    [Key,ForeignKey("Cliente")]
    public int IdCliente { get; set; }

    [MaxLength(50)]
    [Required(ErrorMessage ="Introduzca un nombre")]
    public string PrimerNombre { get; set; }

    [MaxLength(50)]
    public string SegundoNombre { get; set; }

    [MaxLength(50)]
    [Required(ErrorMessage ="Introduzca un apellido")]
    public string PrimerApellido { get; set; }

    [MaxLength(50)]
    public string SegundoApellido { get; set; }

    [MaxLength(14,ErrorMessage ="La cédula debe tener 14 carácteres")]
    [Required(ErrorMessage ="Falta el número de identidad")]
    public string Cedula { get; set; }        

    public virtual Cliente Cliente { get; set; }
}
