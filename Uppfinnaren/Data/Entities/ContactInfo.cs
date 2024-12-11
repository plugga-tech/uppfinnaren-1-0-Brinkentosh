using System;

namespace Uppfinnaren.Data.Entities;

public class ContactInfo
{
    public int Id {get; set;}
    public string Email {get; set;} = string.Empty;
    public string StreetAddress { get; set; } = string.Empty;
    public string City {get; set;} = string.Empty;
    public int ZipCode { get; set; }

}
