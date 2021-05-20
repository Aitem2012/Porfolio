using System;
using System.Collections.Generic;
using System.Text;
using TechArtProfileProject.Lib.Core.Abstraction;
using TechArtProfileProject.Lib.Infrastructure.Abstraction;
using TechArtProfileProject.Models;

namespace TechArtProfileProject.Lib.Core.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public void Add(Project model)
        {
            _projectRepository.Add(model);
        }

        public Project CreateProject(string projectName, string projectDescription, string projectLink)
        {
            return _projectRepository.CreateProject(projectName, projectDescription, projectLink);
        }

        public void Delete(Project model)
        {
            _projectRepository.Delete(model);
        }

        public List<Project> GetAllProjects(string id)
        {
            return _projectRepository.GetAllProjects(id);
        }

        public Project GetProject(int id)
        {
            return _projectRepository.GetProject(id);
        }

        public void Update(Project oldModel)
        {
            _projectRepository.Update(oldModel);
        }
    }
}
