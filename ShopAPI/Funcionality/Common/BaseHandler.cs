using AutoMapper;
using ShopAPI.Models.Data;

namespace ShopAPI.Funcionality.Common;

public abstract class BaseHandler
{
    protected readonly ApplicationDbContext _dbContext;
    protected readonly IMapper _mapper;

    public BaseHandler(ApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }
}
