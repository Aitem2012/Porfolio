using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechArtProfileProject.Lib.Core.Abstraction;
using TechArtProfileProject.Lib.Infrastructure.Abstraction;

namespace TechArtProfileProject.Models.Services
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository _userProfileRepository;

        public UserProfileService(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }
        public void Add(UserProfile model)
        {
           
        }

        public UserProfile CreateUser(string firstname, string lastname, string email)
        {
            return _userProfileRepository.CreateUser(firstname, lastname, email);
           
        }

        public void Delete(UserProfile model)
        {
            _userProfileRepository.Delete(model);
        }

        public List<UserProfile> GetAllUserProfiles()
        {
            return _userProfileRepository.GetAllUserProfiles();
        }

        public UserProfile GetUserProfile(string id)
        {
            return _userProfileRepository.GetUserProfile(id);
        }

        public void Update(UserProfile oldModel)
        {
            _userProfileRepository.Update(oldModel);
        }
    }
}
