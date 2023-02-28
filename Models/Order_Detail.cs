using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[Table("OrderDetail")]
public class Order_Detail : Movement_Detail
{
    public int IdOrder { get; set; }
    public int IdProduct { get; set; }

    public virtual Order Order { get; set; }

    public virtual Product Product { get; set; }
}
