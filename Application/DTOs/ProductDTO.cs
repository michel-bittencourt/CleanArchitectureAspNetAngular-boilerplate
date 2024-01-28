using System.ComponentModel.DataAnnotations;

namespace Application.DTOs;

public class ProductDTO
{
    public int Id { get; set; }

    [Required(ErrorMessage = "The name is required")]
    [MinLength(3)]
    [MaxLength(50)]
    public string Name { get; set; }

    [MinLength(3)]
    [MaxLength(150)]
    public string? Description { get; set; }

    [Required(ErrorMessage = "The Selling price is required")]
    public decimal PurchasePrice { get; set; }

    [Required(ErrorMessage = "The Selling price is required")]
    public decimal SellingPrice { get; set; }

    [Required(ErrorMessage = "The stoke quantity is required")]
    public int StokeQuantity { get; set; }
}
