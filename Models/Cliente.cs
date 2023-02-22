using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table("Customer")]
public class Cliente{
    [Key]
    public int IdCliente { get; set; }

    [MaxLength(8)]
    [Required(ErrorMessage ="Falta el número de contacto")]
    public string Telefono { get; set; }

    [MaxLength(300)]
    [Required(ErrorMessage ="Introduzca la dirección del cliente")]
    public string Direccion { get; set; }

    [MaxLength(50)]
    public string Correo { get; set; }

    public virtual ClienteNatural Natural { get; set; }
    public virtual ClienteJuridico Juridico { get; set; }
}