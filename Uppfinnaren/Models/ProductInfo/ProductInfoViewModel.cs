using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Uppfinnaren.Models.Category;
using Uppfinnaren.Data.Entities;

namespace Uppfinnaren.Models.ProductInfo;

public class ProductInfoViewModel
{
    public string Name {get; set;}= string.Empty;
    public string Type {get; set;} = string.Empty;
    public string Material {get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;
    public string Color {get; set;} = string.Empty;
    public string CategoryName {get; set;} = string.Empty;  

}
