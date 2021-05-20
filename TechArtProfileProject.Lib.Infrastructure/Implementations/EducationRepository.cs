using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechArtProfileProject.Lib.Infrastructure.Abstraction;
using TechArtProfileProject.Lib.Model.Models;

namespace TechArtProfileProject.Lib.Infrastructure.Implementations
{
    public class EducationRepository : IEducationRepository
    {
        private readonly UserProfileDbContext _ctx;

        public EducationRepository(UserProfileDbContext ctx)
        {
            _ctx = ctx;
        }
        public void Add(Education model)
        {
            _ctx.Educations.Add(model);
            _ctx.SaveChanges();
        }

        public Education CreateEducation(string degreeObtained, string schoolName, string discipline, DateTime startDate, DateTime endDate)
        {
            var service = new Education
            {
                DegreeObtained = degreeObtained,
                SchoolName = schoolName,
                Discipline = discipline,
                StartDate = startDate,
                GraduationDate = endDate,
                
            };

            return service;
        }

        public void Delete(Education model)
        {
            var educationToDelete = _ctx.Educations.FirstOrDefault(x => x.EducationId == model.EducationId);
            _ctx.Educations.Remove(educationToDelete);
        }

        public List<Education> GetAllEducation(string id)
        {
            return _ctx.Educations.Where(x => x.UserProfileId == id).ToList();
        }

        public Education GetEducation(int id)
        {
            return _ctx.Educations.FirstOrDefault(x => x.EducationId == id);
        }

        public void Update(Education oldModel)
        {
            var educationToUpdate = _ctx.Educations.FirstOrDefault(x => x.EducationId == oldModel.EducationId);
            
            _ctx.Entry(educationToUpdate).CurrentValues.SetValues(oldModel);
            _ctx.SaveChanges();
        }
    }
}
