using System.ComponentModel.DataAnnotations;

namespace Models;
public abstract class Transaction
{
    [Key]
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public MovementType MovementType { get; set; }
    public double SubAmount { get; set; }
    public double Discount { get; set; }
    public double Iva { get; set; }
    public double Amount { get; set; }
}
