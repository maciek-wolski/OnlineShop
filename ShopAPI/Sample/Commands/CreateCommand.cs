using MediatR;
using ShopAPI.Sample.Dtos;

namespace ShopAPI.Sample.Commands;

public class CreateCommand : IRequest<SampleResponseDto>
{
    public CreateCommand()
    { }
}
