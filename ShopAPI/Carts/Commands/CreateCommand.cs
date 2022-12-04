using MediatR;
using ShopAPI.Carts.Dtos;

namespace ShopAPI.Carts.Commands;

public class CreateCommand : IRequest<CreateUpdateCartResponseDto>
{
    public CreateCommand() { }
}
