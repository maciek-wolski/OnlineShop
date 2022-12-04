using MediatR;
using ShopAPI.Funcionality.Products.Dtos;

namespace ShopAPI.Funcionality.Products.Commands;

public class CreateCommand : IRequest<CreateUpdateProductResponseDto>
{
	public CreateCommand() { }
}
