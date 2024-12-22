using System;
using Microsoft.AspNetCore.SignalR;
using Uppfinnaren.Data.Entities;

namespace Uppfinnaren.Data.Repositories;

public interface ICategoryRepository
{
    IEnumerable<Category> List {get;}
    Category? GetCategoryById(int id);

}
