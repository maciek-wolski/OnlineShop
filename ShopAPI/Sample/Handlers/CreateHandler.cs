using AutoMapper;
using MediatR;
using ShopAPI.Models;
using ShopAPI.Models.Data;
using ShopAPI.Sample.Commands;
using ShopAPI.Sample.Dtos;

namespace ShopAPI.Sample.Handlers;

public class CreateHandler : IRequestHandler<CreateCommand, SampleResponseDto>
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IMapper _mapper;

    public CreateHandler(ApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<SampleResponseDto> Handle(CreateCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<SampleModel>(request);
        _dbContext.Samples.Add(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);

        var entityDto = _mapper.Map<SampleResponseDto>(entity);
        return entityDto;
    }
}
