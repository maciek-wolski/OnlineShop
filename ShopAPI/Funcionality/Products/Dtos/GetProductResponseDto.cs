using ShopAPI.Models.Entity.Enums;

namespace ShopAPI.Funcionality.Products.Dtos;

public class GetProductResponseDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ProductCategory Category { get; set; }
    public decimal Price { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime ModificationDate { get; set; }
}
