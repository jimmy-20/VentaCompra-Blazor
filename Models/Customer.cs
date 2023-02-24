using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table("Customer")]
public class Customer{
    [Key]
    public int IdCustomer { get; set; }

    [MaxLength(8)]
    [Required(ErrorMessage ="Falta el número de contacto")]
    public string Phone { get; set; }

    [MaxLength(300)]
    [Required(ErrorMessage ="Introduzca la dirección del Customer")]
    public string Address { get; set; }

    [MaxLength(50)]
    public string Email { get; set; }

    public virtual NatureCustomer Natural { get; set; }
    public virtual LegalCustomer Juridico { get; set; }
}