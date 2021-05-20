using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechArtProfileProject.ViewModels
{
    public class EditProjectViewModel
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string UserProfileId { get; set; }
        public int UserId { get; set; }
        public string ProjectLink { get; set; }
    }
}
