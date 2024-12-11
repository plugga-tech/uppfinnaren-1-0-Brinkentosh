using System;
using Uppfinnaren.Data.Entities;

namespace Uppfinnaren.Data.Repositories;

public class MockProductInfoRepository : IProductInfoRepository
{
    public IEnumerable<ProductInfo> List =>
    [
        new ProductInfo {Id=1, Type="Stol", Color="Natur", Material="Trä", Description="En stol jag byggde ifrån en stubbe"},
        new ProductInfo {Id=2, Type="Bord", Color="Grå", Material="gjutjärn", Description="Ett bord jag byggde ifrån en massa gjutjärnsgrytor"}
    ];
}
