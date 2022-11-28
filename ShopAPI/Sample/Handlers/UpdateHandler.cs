using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ShopAPI.Models.Data;
using ShopAPI.Sample.Commands;
using ShopAPI.Sample.Dtos;

namespace ShopAPI.Sample.Handlers;

public class UpdateHandler : IRequestHandler<UpdateCommand, SampleResponseDto>
{
    private readonly IMapper _mapper;
    private readonly ApplicationDbContext _dbContext;

    public UpdateHandler(IMapper mapper, ApplicationDbContext dbContext)
    {
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public async Task<SampleResponseDto> Handle(UpdateCommand request, CancellationToken cancellationToken)
    {
        var entity = await _dbContext.Samples.FirstOrDefaultAsync(x => x.Id.Equals(request.Id), cancellationToken);
        if (entity is null)
            throw new KeyNotFoundException();

        entity = _mapper.Map<Models.SampleModel>(request);

        _dbContext.Samples.Update(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);

        var responseDto = _mapper.Map<SampleResponseDto>(entity);
        return responseDto;
    }
}
