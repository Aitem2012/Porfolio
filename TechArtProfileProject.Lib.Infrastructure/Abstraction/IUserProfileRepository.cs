using System;
using System.Collections.Generic;
using System.Text;
using TechArtProfileProject.Models;
using TechArtProfileProject.Models.Services;

namespace TechArtProfileProject.Lib.Infrastructure.Abstraction
{
    public interface IUserProfileRepository : ICRUD<UserProfile>
    {
        public UserProfile CreateUser(string firstname, string lastname, string email, string image, int userId);
        public UserProfile GetUserProfile(int Id);
        public List<UserProfile> GetAllUserProfiles();
    }
}
