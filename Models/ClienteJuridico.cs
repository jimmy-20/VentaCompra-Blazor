using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventarioBlazor.Models;

public class ClienteJuridico
{
    [Key,ForeignKey("Cliente")]
    public int IdCliente { get; set; }

    [MaxLength(100)]
    public string Nombre { get; set; }

    [MaxLength(14)]
    public string Ruc { get; set; }

    public virtual Cliente Cliente {get;set;}
}
