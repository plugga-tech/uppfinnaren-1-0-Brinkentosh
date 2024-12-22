using System;
using Uppfinnaren.Data.Entities;

namespace Uppfinnaren.Data.Repositories;

public class ProductInfoRepository : IProductInfoRepository
{
    private readonly AppDbContext _appDbContext;

    public ProductInfoRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    
    public IEnumerable<ProductInfo> List => _appDbContext.ProductInfos.ToList();

}
