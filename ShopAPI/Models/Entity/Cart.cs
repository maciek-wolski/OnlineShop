using ShopAPI.Models.Entity.Common;

namespace ShopAPI.Models.Entity;

public class Cart : GuidBaseEntity
{
	public Cart()
	{
		ModificationDate = DateTime.UtcNow;
	}

	public DateTime ModificationDate { get; set; }

}
