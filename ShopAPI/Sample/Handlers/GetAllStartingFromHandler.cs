using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ShopAPI.Models.Data;
using ShopAPI.Sample.Dtos;
using ShopAPI.Sample.Queries;

namespace ShopAPI.Sample.Handlers;

public class GetAllStartingFromHandler : IRequestHandler<GetAllStartingFromQuery, List<SampleResponseDto>>
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetAllStartingFromHandler(ApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<List<SampleResponseDto>> Handle(GetAllStartingFromQuery request, CancellationToken cancellationToken)
    {
        var entities = await _dbContext.Samples.Where(x => x.Name.StartsWith(request.StartingPart)).ToListAsync(cancellationToken);

        var responsesDto = _mapper.Map<List<SampleResponseDto>>(entities);
        return responsesDto;
    }
}
