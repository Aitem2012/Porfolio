using System;
using System.Collections.Generic;
using System.Text;
using TechArtProfileProject.Models;
using TechArtProfileProject.Models.Services;

namespace TechArtProfileProject.Lib.Infrastructure.Abstraction
{
    public interface IProjectRepository : ICRUD<Project>
    {
        public Project CreateProject(string projectName, string projectDescription, string projectLink);
        public Project GetProject(int id);
        public List<Project> GetAllProjects(string id);
    }
}
