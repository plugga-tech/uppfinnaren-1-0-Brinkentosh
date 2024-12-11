using System;
using Uppfinnaren.Data.Entities;

namespace Uppfinnaren.Data.Repositories;

public interface IContactInfoRepository
{
    IEnumerable<ContactInfo> List {get;}
    
}
