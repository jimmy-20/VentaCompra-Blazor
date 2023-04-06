using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table("PurchaseDetail")]
public class Purchase_Detail : Transaction_Detail
{
    public int IdPurchase { get; set; }
    public int IdProduct { get; set; }

    public virtual Purchase Purchase { get; set; }
    public virtual Product Product { get; set; }
}
