using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ShopAPI.Models.Data;
using ShopAPI.Sample.Dtos;
using ShopAPI.Sample.Queries;

namespace ShopAPI.Sample.Handlers;

public class GetAllHandler : IRequestHandler<GetAllQuery, List<SampleResponseDto>>
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetAllHandler(ApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<List<SampleResponseDto>> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        List<Models.SampleModel> samplesFromDb = await _dbContext.Samples.ToListAsync(cancellationToken);
        var samplesDto = _mapper.Map<List<SampleResponseDto>>(samplesFromDb);

        return samplesDto;
    }
}
