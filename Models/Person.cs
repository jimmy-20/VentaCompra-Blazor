using System.ComponentModel.DataAnnotations;

namespace Models;

public abstract class Person
{
    [Key]
    public int Id { get; set; }

    [MaxLength(50)]
    [Required(ErrorMessage ="Introduzca un nombre")]
    public string FirstName { get; set; }

    [MaxLength(50)]
    public string SecondName { get; set; }

    public string FirstLastName { get; set; }

    [MaxLength(50)]
    public string SecondLastName { get; set; }

    public string Identification { get; set; }

    public string Phone { get; set; }

    public string Address { get; set; }
}
