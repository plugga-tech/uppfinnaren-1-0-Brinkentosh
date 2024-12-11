using System;
using Uppfinnaren.Data.Entities;

namespace Uppfinnaren.Data.Repositories;

public interface IProductInfoRepository
{
    IEnumerable<ProductInfo> List {get;}
}
