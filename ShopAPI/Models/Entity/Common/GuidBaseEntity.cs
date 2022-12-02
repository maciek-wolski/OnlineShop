using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopAPI.Models.Entity.Common;

public abstract class GuidBaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public Guid Id { get; set; }
    public DateTime CreationDate { get; set; }

    protected GuidBaseEntity()
    {
        CreationDate = DateTime.UtcNow;
    }

    protected GuidBaseEntity(GuidBaseEntity guidBaseEntity) : this()
    {
        Id = guidBaseEntity.Id;
    }
}
