using System;
using Microsoft.AspNetCore.Mvc;
using Uppfinnaren.Data.Entities;

namespace Uppfinnaren.Data.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly AppDbContext _appDbContext;

    public CategoryRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    
    public IEnumerable<Category> List => _appDbContext.Categories.ToList();

    public Category? GetCategoryById(int id)
    {
        return _appDbContext.Categories.FirstOrDefault(i => i.Id == id);
    }
}

