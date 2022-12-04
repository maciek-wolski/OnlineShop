using MediatR;
using ShopAPI.Carts.Dtos;

namespace ShopAPI.Carts.Commands;

public class UpdateCommand : IRequest<CreateUpdateCartResponseDto>
{
    public Guid Id { get; set; }
    public DateTime ModificationDate { get; set; }
}
