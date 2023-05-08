using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    public Category? ProductName { get; set; }

    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    
    public Category? Category { get; set; }
}