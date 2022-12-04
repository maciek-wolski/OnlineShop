using MediatR;
using ShopAPI.Funcionality.Products.Dtos;
using ShopAPI.Models.Entity.Enums;

namespace ShopAPI.Funcionality.Products.Commands;

public class UpdateCommand : IRequest<GetProductResponseDto>
{
    public UpdateCommand() { }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ProductCategory Category { get; set; }
    public decimal Price { get; set; }
}
