using System;
using System.Collections.Generic;
using System.Text;
using TechArtProfileProject.Lib.Model.Models;
using TechArtProfileProject.Models.Services;

namespace TechArtProfileProject.Lib.Infrastructure.Abstraction
{
    public interface IContactRepository : ICRUD<Contact>
    {
        public Contact CreateContact(string senderName, string senderEmail, string senderMessage);
        public List<string> GetContactsMessages(string email);
        public Contact GetContact(string email);
    }
}
