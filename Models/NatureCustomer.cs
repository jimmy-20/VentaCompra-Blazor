using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table("NatureCustomer")]
public class NatureCustomer
{
    [Key,ForeignKey("Customer")]
    public int IdCustomer { get; set; }

    [MaxLength(50)]
    [Required(ErrorMessage ="Introduzca un nombre")]
    public string FirstName { get; set; }

    [MaxLength(50)]
    public string SecondName { get; set; }

    [MaxLength(50)]
    [Required(ErrorMessage ="Introduzca un apellido")]
    public string FirstLastName { get; set; }

    [MaxLength(50)]
    public string SecondLastName { get; set; }

    [MaxLength(14,ErrorMessage ="La cédula debe tener 14 carácteres")]
    [Required(ErrorMessage ="Falta el número de identidad")]
    public string Identification { get; set; }        

    public virtual Customer Customer { get; set; }
}
