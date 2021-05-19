using System;
using System.Collections.Generic;
using System.Text;
using TechArtProfileProject.Lib.Model.Models;

namespace TechArtProfileProject.Lib.Core.Abstraction
{
    public interface IUserServicesService : ICRUDService<UserServices>
    {
        public UserServices CreateProject(string ServiceName, string serviceDescription, int userId);
        public UserServices GetUserService(int id);
        public List<UserServices> GetAllServices(int id);
    }
}
