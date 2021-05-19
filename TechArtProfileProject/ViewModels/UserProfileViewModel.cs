using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechArtProfileProject.ViewModels
{
    public class UserProfileViewModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string Image { get; set; }
        
        public string Email { get; set; }
        public string Biography { get; set; }
        public string JobTitle { get; set; }
        public int UserProfileId { get; set; }
    }
}
