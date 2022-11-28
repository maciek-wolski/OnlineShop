using MediatR;

namespace ShopAPI.Sample.Dtos;

public class StartingFromSampleRequestDto : IRequest<List<SampleResponseDto>>
{
    public string StartingPart { get; set; }
}
