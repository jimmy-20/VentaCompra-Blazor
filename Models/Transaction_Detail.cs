namespace Models;

public abstract class Transaction_Detail
{
    public double Price { get; set; }
    public int Quantity { get; set; }
    public float Discount { get; set; }
    public double Iva { get; set; }
}
