using ShopAPI.Models.Entity.Common;
using ShopAPI.Models.Entity.Enums;

namespace ShopAPI.Models.Entity;

public class Product : GuidBaseEntity
{
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public ProductCategory Category { get; set; }
}
