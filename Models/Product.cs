using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Enums;

namespace Models;

[Table("Product")]
public class Product
{
    [Key]
    public int IdProduct { get; set; }

    [ForeignKey("BaseProduct")]
    public int IdBase { get; set; }

    [ForeignKey("ContentProduct")]
    public int IdContent { get; set; }
    
    [Required(ErrorMessage ="Falta el volumen del Product")]
    public double Volume { get; set; } //cantidad de volumen

    [Required(ErrorMessage ="Introduzca el precio del Product")]
    public double Price { get; set; }

    [MaxLength()]
    public string UrlImage { get; set; }
    public int Quantity { get; set; } = 0;
    
    public CatalogState State { get; set; } = CatalogState.Register;

    //Propiedades de navegacion
    public BaseProduct BaseProduct { get; set; }
    public ContentProduct ContentProduct { get; set; }

    [NotMapped]
    public string Nombre{
        get{
            return $"{BaseProduct.Name} {ContentProduct.Model} {Volume} {ContentProduct.Content}";
        }
    }
}
