using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechArtProfileProject.Lib.Infrastructure;
using TechArtProfileProject.Lib.Infrastructure.Abstraction;

namespace TechArtProfileProject.Models.Services
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly UserProfileDbContext _ctx;

        public UserProfileRepository(UserProfileDbContext ctx)
        {
            _ctx = ctx;
        }
        public void Add(UserProfile model)
        {
            _ctx.UserProfiles.Add(model);
            _ctx.SaveChanges();
        }

        public UserProfile CreateUser(string firstname, string lastname, string email)
        {
            var user = new UserProfile
            {
                FirstName = firstname,
                LastName = lastname,
                Email = email,
            };

            return user;
        }

        public void Delete(UserProfile model)
        {
            var userToRemove = _ctx.UserProfiles.FirstOrDefault(x => x.Id == model.Id);
            _ctx.UserProfiles.Remove(userToRemove);
            _ctx.SaveChanges();
        }

        public List<UserProfile> GetAllUserProfiles()
        {
            return _ctx.UserProfiles.Select(x => x).ToList();
        }

        public UserProfile GetUserProfile(string id)
        {
            var userToReturn = _ctx.UserProfiles.FirstOrDefault(x => x.Id == id);
            return userToReturn;
        }

        public void Update(UserProfile oldModel)
        {
            var userToUpdate = _ctx.UserProfiles.FirstOrDefault(x => x.Id == oldModel.Id);
            _ctx.Entry(userToUpdate).CurrentValues.SetValues(oldModel);
            _ctx.SaveChanges();
        }
    }
}
