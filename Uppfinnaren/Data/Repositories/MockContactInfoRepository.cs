using System;
using Uppfinnaren.Data.Entities;

namespace Uppfinnaren.Data.Repositories;

public class MockContactInfoRepository : IContactInfoRepository
{
    public IEnumerable<ContactInfo> List =>
    [
        new ContactInfo {Id=1, Email = "uppfinnaren@snickare.se", City = "Forserum", StreetAddress = "Kyrkogatan", ZipCode = 57178}
    ];
}
