using System;
using Uppfinnaren.Data.Entities;

namespace Uppfinnaren.Data.Repositories;

public class MockProductInfoRepository : IProductInfoRepository
{
    public IEnumerable<ProductInfo> List =>
    [
        new ProductInfo {Id=1, Type="Stol", Color="Natur", Material="Trä", Description="En stol jag byggde ifrån en stubbe", Name = "Stol"},
        new ProductInfo {Id=2, Type="Bord", Color="Grå", Material="Gjutjärn", Description="Ett bord jag byggde ifrån en massa gjutjärnsgrytor", Name = "Bord"},
        new ProductInfo {Id=3, Type="Datorchassi", Color="Svart", Material="Gummi", Description="Ett Datorchassi som är byggt av ett traktordäck", Name = "Chassi"}
    ];
}
