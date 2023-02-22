using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;
[Table("LegalCustomer")]
public class ClienteJuridico
{
    [Key,ForeignKey("Cliente")]
    public int IdCliente { get; set; }

    [MaxLength(100)]
    [Required(ErrorMessage ="Falta el nombre del cliente")]
    public string Nombre { get; set; }

    [MaxLength(14,ErrorMessage ="El N° Ruc debe contener 14 carácteres")]
    [Required(ErrorMessage ="Falta el N° Ruc")]
    public string Ruc { get; set; }

    public virtual Cliente Cliente {get;set;}
}
