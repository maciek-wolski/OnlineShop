using MediatR;
using ShopAPI.Sample.Dtos;

namespace ShopAPI.Sample.Queries;

public class GetAllStartingFromQuery : IRequest<List<SampleResponseDto>>
{
    public string StartingPart { get; set; }
}
