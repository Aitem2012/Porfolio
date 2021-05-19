using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechArtProfileProject.Lib.Model.Models;
using TechArtProfileProject.Models;

namespace TechArtProfileProject.ViewModels
{
    public class AllUserProfileViewModel
    {
        public IEnumerable<UserProfile> Profiles { get; set; }

        public UserProfile UserProfile { get; set; }
        public List<Project> GetProjects { get; set; }
        public List<Education> GetEducations { get; set; }
        public List<UserServices> GetUserServices { get; set; }
        public Project GetProject { get; set; }
        public UserServices GetUserService { get; set; }
    }
}
