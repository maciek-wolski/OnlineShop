using MediatR;
using ShopAPI.Carts.Dtos;

namespace ShopAPI.Carts.Queries;

public class GetByIdQuery : IRequest<GetCartResponseDto>
{
    public Guid Id { get; set; }
    public GetByIdQuery() { }
}
