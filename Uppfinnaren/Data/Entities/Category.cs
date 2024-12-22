using System;

namespace Uppfinnaren.Data.Entities;

public class Category
{
    public int Id {get;set;}
    public string Name {get;set;} = string.Empty;
    public List<ProductInfo> ProductInfos {get;set;}
}
