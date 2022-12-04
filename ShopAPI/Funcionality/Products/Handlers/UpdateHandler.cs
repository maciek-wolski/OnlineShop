using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ShopAPI.Funcionality.Common;
using ShopAPI.Funcionality.Products.Commands;
using ShopAPI.Funcionality.Products.Dtos;
using ShopAPI.Models.Data;

namespace ShopAPI.Funcionality.Products.Handlers;

public class UpdateHandler : BaseHandler, IRequestHandler<UpdateCommand, GetProductResponseDto>
{
    public UpdateHandler(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

    public async Task<GetProductResponseDto> Handle(UpdateCommand request, CancellationToken cancellationToken)
    {
        var entity = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == request.Id);

        if (entity is not null)
        {
            entity.ModificationDate = DateTime.UtcNow;
            entity.Category = request.Category;
            entity.Description = request.Description;
            entity.Price = request.Price;
            entity.Name = request.Name;

            await _dbContext.SaveChangesAsync();
        }

        var response = _mapper.Map<GetProductResponseDto>(entity);
        return response;
    }
}
