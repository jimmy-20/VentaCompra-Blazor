using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventarioBlazor.Models;

public class ClienteNatural
{
    [Key,ForeignKey("Cliente")]
    public int IdCliente { get; set; }

    [MaxLength(50)]
    public string PrimerNombre { get; set; }

    [MaxLength(50)]
    public string SegundoNombre { get; set; }

    [MaxLength(50)]
    public string PrimerApellido { get; set; }

    [MaxLength(50)]
    public string SegundoApellido { get; set; }

    [MaxLength(14)]
    public string Cedula { get; set; }        

    public virtual Cliente Cliente { get; set; }
}
