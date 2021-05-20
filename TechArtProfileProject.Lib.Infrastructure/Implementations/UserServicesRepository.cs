using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechArtProfileProject.Lib.Infrastructure.Abstraction;
using TechArtProfileProject.Lib.Model.Models;

namespace TechArtProfileProject.Lib.Infrastructure.Implementations
{
    public class UserServicesRepository : IUserServiceRepository
    {
        private readonly UserProfileDbContext _ctx;

        public UserServicesRepository(UserProfileDbContext ctx)
        {
            _ctx = ctx;
        }
        public void Add(UserServices model)
        {
            _ctx.Services.Add(model);
            _ctx.SaveChanges();
        }

        public UserServices CreateProject(string serviceName, string serviceDescription)
        {
            var service = new UserServices
            {
                ServiceDescription = serviceDescription,
                ServiceName = serviceName,
                
            };

            return service;
        }

        public void Delete(UserServices model)
        {
            var servicesToDelete = _ctx.Services.FirstOrDefault(x => x.ServiceId == model.ServiceId);
            _ctx.Services.Remove(servicesToDelete);
        }

        public List<UserServices> GetAllServices(string id)
        {
            return _ctx.Services.Where(x => x.UserProfileId == id).ToList();
        }

        public UserServices GetUserService(int id)
        {
            return _ctx.Services.FirstOrDefault(x => x.ServiceId == id);
        }

        public void Update(UserServices oldModel)
        {
            var serviceToUpdate = _ctx.Services.FirstOrDefault(x => x.ServiceId == oldModel.ServiceId);
            _ctx.Entry(serviceToUpdate).CurrentValues.SetValues(oldModel);
            _ctx.SaveChanges();
        }
    }
}
