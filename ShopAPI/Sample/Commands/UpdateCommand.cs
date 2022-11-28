using MediatR;
using ShopAPI.Sample.Dtos;

namespace ShopAPI.Sample.Commands;

public class UpdateCommand : IRequest<SampleResponseDto>
{
    public int Id { get; set; }
    public string Name { get; set; }
}
