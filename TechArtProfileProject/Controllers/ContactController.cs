using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechArtProfileProject.Lib.Core.Abstraction;
using TechArtProfileProject.Lib.Model.Models;
using TechArtProfileProject.ViewModels;

namespace TechArtProfileProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly ContactViewModel _contactViewModel;
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger, IContactService contactService)
        {
            _contactService = contactService;
            _contactViewModel = new ContactViewModel();
            _logger = logger;
        }
        public IActionResult Index()
        {
            
            return View(_contactViewModel);
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            var contactToCreate = _contactService.CreateContact(contact.SenderName, contact.SenderEmail, contact.SenderMessage);

            _contactService.Add(contactToCreate);

            return View(_contactViewModel);
        }
    }
}
