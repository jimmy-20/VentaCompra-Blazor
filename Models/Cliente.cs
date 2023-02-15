using System.ComponentModel.DataAnnotations;

namespace InventarioBlazor.Models;

public class Cliente{
    [Key]
    public int IdCliente { get; set; }

    [MaxLength(8)]
    public string Telefono { get; set; }

    [MaxLength(150)]
    public string Direccion { get; set; }

    [MaxLength(50)]
    public string Correo { get; set; }

    public virtual ClienteNatural Natural { get; set; }
    public virtual ClienteJuridico Juridico { get; set; }
}