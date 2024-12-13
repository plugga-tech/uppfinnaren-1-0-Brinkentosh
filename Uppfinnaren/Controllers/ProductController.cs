using System;
using Microsoft.AspNetCore.Mvc;
using Uppfinnaren.Data.Repositories;
using Uppfinnaren.Models.ProductInfo;

namespace Uppfinnaren.Controllers;

public class ProductController : Controller
{
    private readonly IProductInfoRepository _productInfoRepository;

    public ProductController (IProductInfoRepository productInfoRepository)
    {
        _productInfoRepository = productInfoRepository;
    }

    public IActionResult Index()
    {
        var productInfos = _productInfoRepository.List.ToList();
        var productInfoViewModels = new List<ProductInfoViewModel>();

        foreach (var productInfo in productInfos)
        {
            productInfoViewModels.Add(new ProductInfoViewModel
            {
                Name = productInfo.Name,
                Type = productInfo.Type,
                Color = productInfo.Color,
                Description = productInfo.Description,
                Material = productInfo.Material
            });  
        }
        return View(productInfoViewModels);
    }
}