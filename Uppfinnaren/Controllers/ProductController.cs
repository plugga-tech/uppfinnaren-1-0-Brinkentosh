using System;
using Microsoft.AspNetCore.Mvc;
using Uppfinnaren.Data.Entities;
using Uppfinnaren.Data.Repositories;
using Uppfinnaren.Models.ProductInfo;

namespace Uppfinnaren.Controllers;

public class ProductController : Controller
{
    private readonly IProductInfoRepository _productInfoRepository;
    private readonly ICategoryRepository _categoryRepository;

    public ProductController (IProductInfoRepository productInfoRepository, ICategoryRepository categoryRepository)
    {
        _productInfoRepository = productInfoRepository;
        _categoryRepository = categoryRepository;
    }

    public IActionResult Index(int categoryId)
    {
        var productInfos = _productInfoRepository.List.ToList();
        var productsInCatergory = productInfos.Where(p => p.CategoryId == categoryId).ToList();
        var productInfoViewModels = new List<ProductInfoViewModel>();



        foreach (var productInfo in productsInCatergory)
        {
            productInfoViewModels.Add(new ProductInfoViewModel
            {
                 Name = productInfo.Name,
                 Type = productInfo.Type,
                 Color = productInfo.Color,
                 Description = productInfo.Description,
                 Material = productInfo.Material,
                 CategoryName = _categoryRepository.GetCategoryById(productInfo.CategoryId).Name
            });
        }
        return View(productInfoViewModels);
        
    }   
}