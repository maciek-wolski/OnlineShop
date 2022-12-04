using MediatR;
using ShopAPI.Funcionality.Carts.Dtos;

namespace ShopAPI.Funcionality.Carts.Commands;

public class CreateCommand : IRequest<CreateUpdateCartResponseDto>
{
    public CreateCommand() { }
}
