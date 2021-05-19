using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechArtProfileProject.Lib.Infrastructure.Abstraction;
using TechArtProfileProject.Lib.Model.Models;
using TechArtProfileProject.Models;

namespace TechArtProfileProject.Lib.Infrastructure.Implementations
{
    public class ContactRepository : IContactRepository
    {
        private readonly UserProfileDbContext _ctx;

        public ContactRepository(UserProfileDbContext ctx)
        {
            _ctx = ctx;
        }
        public void Add(Contact model)
        {
            _ctx.Contacts.Add(model);
            _ctx.SaveChanges();
        }

        public Contact CreateContact(string senderName, string senderEmail, string senderMessage)
        {
            var contact = new Contact
            {
                SenderName = senderName,
                SenderMessage = senderMessage,
                SenderEmail = senderEmail
            };
            return contact;
        }

        public void Delete(Contact model)
        {
            var contactToDelete = _ctx.Contacts.FirstOrDefault(x => x.SenderEmail == model.SenderEmail);
            _ctx.Contacts.Remove(contactToDelete);
            _ctx.SaveChanges();
        }

        public Contact GetContact(string email)
        {
            return _ctx.Contacts.FirstOrDefault(x => x.SenderEmail == email);

        }

        public List<string> GetContactsMessages(string email)
        {
            return _ctx.Contacts.Where(x => x.SenderEmail == email).Select(x =>x.SenderMessage).ToList();
        }

        public void Update(Contact oldModel)
        {
            var contactToUpdate = _ctx.Contacts.FirstOrDefault(x => x.SenderId == oldModel.SenderId);
            
            _ctx.Entry(contactToUpdate).CurrentValues.SetValues(oldModel);
            _ctx.SaveChanges();
        }
    }
}
