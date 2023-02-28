using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table("Order")]
public class Order : Transaction
{
    [ForeignKey("Customer")]
    public int IdCustomer { get; set; }
    [ForeignKey("Employee")]
    public int IdEmployee { get; set; }
    public OrderState OrderState { get; set; } = OrderState.Registrado;

    public virtual Customer Customer { get; set; }
    public virtual Employee Employee { get; set; }
}
