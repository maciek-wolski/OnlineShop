using ShopAPI.Models.Entity.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopAPI.Models.Entity;

public class CartProduct : GuidBaseEntity
{
    public CartProduct()
    {
        ModificationDate = DateTime.UtcNow;
    }
    public int Quantity { get; set; }
    public DateTime ModificationDate { get; set; }

    public Guid ProductId { get; set; }
    [ForeignKey("ProductId")]
    public Product Product { get; set; }

    public Guid CartId { get; set; }
    [ForeignKey("CartId")]
    public Cart Cart { get; set; }

}
