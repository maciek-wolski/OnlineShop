using MediatR;
using ShopAPI.Funcionality.Products.Dtos;

namespace ShopAPI.Funcionality.Products.Queries;

public class GetByIdQuery : IRequest<GetProductResponseDto>
{
	public GetByIdQuery() { }
	public Guid Id { get; set; }
}
