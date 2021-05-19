using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechArtProfileProject.Models;

namespace TechArtProfileProject.Lib.Core.Abstraction
{
    public interface IUserProfileService : ICRUDService<UserProfile>
    {
        public UserProfile CreateUser(string firstname, string lastname, string email, string image, int userId);
        public UserProfile GetUserProfile(int email);
        public List<UserProfile> GetAllUserProfiles();
    }
}
