using System;
using System.Collections.Generic;
using System.Text;
using TechArtProfileProject.Lib.Core.Abstraction;
using TechArtProfileProject.Lib.Infrastructure.Abstraction;
using TechArtProfileProject.Lib.Model.Models;

namespace TechArtProfileProject.Lib.Core.Services
{
    public class UserServicesService : IUserServicesService
    {
        private readonly IUserServiceRepository _userService;

        public UserServicesService(IUserServiceRepository userServicesRepository)
        {
            _userService = userServicesRepository;
        }
        public void Add(UserServices model)
        {
            _userService.Add(model);
        }

        public UserServices CreateProject(string ServiceName, string serviceDescription)
        {
            return _userService.CreateProject(ServiceName, serviceDescription);
        }

        public void Delete(UserServices model)
        {
            _userService.Delete(model);
        }

        public List<UserServices> GetAllServices(string id)
        {
            return _userService.GetAllServices(id);
        }

        public UserServices GetUserService(int id)
        {
            return _userService.GetUserService(id);
        }

        public void Update(UserServices oldModel)
        {
            _userService.Update(oldModel);
        }
    }
}
