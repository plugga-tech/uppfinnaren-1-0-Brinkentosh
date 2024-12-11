using System;

namespace Uppfinnaren.Models.ContactInfo;

public class ContactInfoViewModel 
{
    public string Email {get; set;} = string.Empty;
    public string StreetAddress { get; set; } = string.Empty;
    public string City {get; set;} = string.Empty;
    public int ZipCode { get; set; }
}
