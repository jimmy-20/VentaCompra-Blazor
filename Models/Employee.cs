using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Enums;

namespace Models;

[Table("Employee")]
public class Employee : Person
{
    public string Observation { get; set; }
    public CatalogState CatalogState { get; set; }
    public DateTime DateUpdate { get; set; } = DateTime.Now;
}
