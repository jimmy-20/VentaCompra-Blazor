using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Enums;

namespace Models;

[Table("Customer")]
public abstract class Customer{
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

    public CatalogState State { get; set; } = CatalogState.Register;
    public DateTime DateUpdate { get; set; } = DateTime.Now;


    public virtual NatureCustomer NatureCustomer { get; set; }
    public virtual LegalCustomer LegalCustomer { get; set; }
}