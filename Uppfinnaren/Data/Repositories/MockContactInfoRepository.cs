using System;
using Uppfinnaren.Data.Entities;

namespace Uppfinnaren.Data.Repositories;

public class MockContactInfoRepository : IContactInfoRepository
{
    public IEnumerable<ContactInfo> List =>
    [
        new ContactInfo {Id=1, Email = "robinbrink@skola.se", City = "Forserum", StreetAddress = "Nässjövägen 15", ZipCode = 57177},
        new ContactInfo {Id=2, Email = "micaelbrink@best.se", City = "Forserum", StreetAddress = "Liljevägen 19", ZipCode = 57178},
        new ContactInfo {Id=3, Email = "addec@csharp.se", City = "Habo", StreetAddress = "habovägen 2", ZipCode = 22233}
    ];
}
