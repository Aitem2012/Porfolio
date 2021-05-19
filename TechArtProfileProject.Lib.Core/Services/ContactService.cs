using System;
using System.Collections.Generic;
using System.Text;
using TechArtProfileProject.Lib.Core.Abstraction;
using TechArtProfileProject.Lib.Infrastructure.Abstraction;
using TechArtProfileProject.Lib.Model.Models;

namespace TechArtProfileProject.Lib.Core.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public void Add(Contact model)
        {
            _contactRepository.Add(model);
        }

        public Contact CreateContact(string senderName, string senderEmail, string senderMessage)
        {
            return _contactRepository.CreateContact(senderName, senderEmail, senderMessage);
        }

        public void Delete(Contact model)
        {
            _contactRepository.Delete(model);
        }

        public Contact GetContact(string email)
        {
            return _contactRepository.GetContact(email);
        }

        public List<string> GetContactsMessages(string email)
        {
            return _contactRepository.GetContactsMessages(email);
        }

        public void Update(Contact oldModel)
        {
            _contactRepository.Update(oldModel);
        }
    }
}
