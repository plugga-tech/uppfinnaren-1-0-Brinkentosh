using System;

namespace Uppfinnaren.Data.Entities;

public class ProductInfo
{
    public int Id {get; set;}
    public string Name {get; set;} = string.Empty;
    public string Type {get; set;} = string.Empty;
    public string Material {get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;
    public string Color {get; set;} = string.Empty;

}
