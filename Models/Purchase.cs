using System.ComponentModel.DataAnnotations.Schema;
using Models.Enums;

namespace Models;

[Table("Purchase")]
public class Purchase : Transaction
{
    [ForeignKey("Provider")]
    public int IdProvider { get; set; }
    public PurchaseState PurchaseState { get; set; } = PurchaseState.Registrado;
    public virtual Provider Provider { get; set; }
}
