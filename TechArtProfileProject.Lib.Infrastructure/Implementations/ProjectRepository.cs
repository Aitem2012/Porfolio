using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechArtProfileProject.Lib.Infrastructure.Abstraction;
using TechArtProfileProject.Models;

namespace TechArtProfileProject.Lib.Infrastructure.Implementations
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly UserProfileDbContext _ctx;

        public ProjectRepository(UserProfileDbContext ctx)
        {
            _ctx = ctx;
        }
        public void Add(Project model)
        {
            _ctx.Projects.Add(model);
        }

        public Project CreateProject(string projectName, string projectDescription, string projectLink)
        {
            var project = new Project
            {
                ProjectName = projectName,
                ProjectDescription = projectDescription,
                ProjectLink = projectLink,
                
                
            };
            return project;
        }

        public void Delete(Project model)
        {
            var projectToDelete = _ctx.Projects.FirstOrDefault(x => x.ProjectName == model.ProjectName);
            _ctx.Projects.Remove(projectToDelete);
            _ctx.SaveChanges();
        }

        public List<Project> GetAllProjects(string id)
        {
            return _ctx.Projects.Where(x => x.UserProfileId == id).ToList();
        }

        public Project GetProject(int id)
        {
            return _ctx.Projects.FirstOrDefault(x => x.ProjectId == id);
        }

        public void Update(Project oldModel)
        {
            var projectToUpdate = _ctx.Projects.FirstOrDefault(x => x.ProjectId == oldModel.ProjectId);
           
            _ctx.Entry(projectToUpdate).CurrentValues.SetValues(oldModel);
            _ctx.SaveChanges();
        }
    }
}
