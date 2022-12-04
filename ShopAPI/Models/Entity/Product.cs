using ShopAPI.Models.Entity.Common;
using ShopAPI.Models.Entity.Enums;
using System.ComponentModel.DataAnnotations;

namespace ShopAPI.Models.Entity;

public class Product : GuidBaseEntity
{
    public Product()
    {
        ModificationDate = DateTime.UtcNow;
    }
    public string Name { get; set; }
    public decimal Price { get; set; }
    [MaxLength(200)]
    public string Description { get; set; }
    public ProductCategory Category { get; set; }
    public DateTime ModificationDate { get; set; }
}
