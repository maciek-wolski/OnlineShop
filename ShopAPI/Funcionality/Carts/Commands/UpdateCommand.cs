using MediatR;
using ShopAPI.Funcionality.Carts.Dtos;

namespace ShopAPI.Funcionality.Carts.Commands;

public class UpdateCommand : IRequest<GetCartResponseDto>
{
    public UpdateCommand() { }
    public Guid Id { get; set; }
}
