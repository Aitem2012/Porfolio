using System;
using System.Collections.Generic;
using System.Text;
using TechArtProfileProject.Lib.Model.Models;

namespace TechArtProfileProject.Lib.Infrastructure.Abstraction
{
    public interface IUserServiceRepository: ICRUD<UserServices>
    {
        public UserServices CreateProject(string ServiceName, string serviceDescription);
        public UserServices GetUserService(int id);
        public List<UserServices> GetAllServices(string id);
    }
}
