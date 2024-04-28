using System.ComponentModel.DataAnnotations;

public class Product
{
    [Key]
    public int productId {get; set;}
    [MaxLength(128), Required]
    public string? productName {get; set;}
    public long? productPrice {get; set;}
}