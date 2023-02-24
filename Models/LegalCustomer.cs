using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;
[Table("LegalCustomer")]
public class LegalCustomer
{
    [Key,ForeignKey("Customer")]
    public int IdCustomer { get; set; }

    [MaxLength(100)]
    [Required(ErrorMessage ="Falta el nombre del Customer")]
    public string Name { get; set; }

    [MaxLength(14,ErrorMessage ="El N° Ruc debe contener 14 carácteres")]
    [Required(ErrorMessage ="Falta el N° Ruc")]
    public string Ruc { get; set; }

    public virtual Customer Customer {get;set;}
}
