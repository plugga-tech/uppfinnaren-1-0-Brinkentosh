using System;
using Microsoft.AspNetCore.Mvc;
using Uppfinnaren.Data.Repositories;
using Uppfinnaren.Models.ContactInfo;

namespace Uppfinnaren.Controllers;

public class ContactController : Controller
{
    private readonly IContactInfoRepository _contactInfoRepository;

    public ContactController (IContactInfoRepository contactInfoRepository)
    {
        _contactInfoRepository = contactInfoRepository;
    }

    public IActionResult Index()
    {
        var contactInfos = _contactInfoRepository.List.ToList();
        var contactInfoViewModels = new List<ContactInfoViewModel>();

        foreach(var contactInfo in contactInfos)
        {
            contactInfoViewModels.Add(new ContactInfoViewModel
            {
                Email = contactInfo.Email,
                City = contactInfo.City,
                ZipCode = contactInfo.ZipCode,
                StreetAddress = contactInfo.StreetAddress
            });
        }
        return View(contactInfoViewModels);
    }
}