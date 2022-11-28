using MediatR;
using ShopAPI.Sample.Dtos;

namespace ShopAPI.Sample.Queries;

public class GetAllQuery : IRequest<List<SampleResponseDto>>
{
    public GetAllQuery()
    { }
}
