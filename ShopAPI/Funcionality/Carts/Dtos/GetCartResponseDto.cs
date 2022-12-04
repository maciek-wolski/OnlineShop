namespace ShopAPI.Funcionality.Carts.Dtos;

public class GetCartResponseDto
{
    public Guid Id { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime ModificationDate { get; set; }
}
