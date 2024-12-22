using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uppfinnaren.Data.Entities;
using Uppfinnaren.Models;
using Uppfinnaren.Models.Category;
using Uppfinnaren.Data.Repositories;

namespace Uppfinnaren.Controllers;

public class HomeController : Controller
{
    //private readonly ILogger<HomeController> _logger;
    private readonly ICategoryRepository _categoryRepository;

    public HomeController(ICategoryRepository categoryRepository)
    {
        //_logger = logger;
        _categoryRepository = categoryRepository;
    }

    public IActionResult Index()
    {
        var categories = _categoryRepository.List.ToList();
        var categoryViewModels = new List<CategoryViewModel>();

        foreach (var category in categories)
        {
            categoryViewModels.Add(new CategoryViewModel
            {
                Id = category.Id,
                Name = category.Name
            });  
        }

        return View(categoryViewModels);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
