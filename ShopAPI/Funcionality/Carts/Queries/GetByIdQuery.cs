using MediatR;
using ShopAPI.Funcionality.Carts.Dtos;

namespace ShopAPI.Funcionality.Carts.Queries;

public class GetByIdQuery : IRequest<GetCartResponseDto>
{
    public GetByIdQuery() { }
    public Guid Id { get; set; }

}
