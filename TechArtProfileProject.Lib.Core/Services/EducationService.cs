using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechArtProfileProject.Lib.Infrastructure.Abstraction;
using TechArtProfileProject.Lib.Model.Models;

namespace TechArtProfileProject.Lib.Infrastructure.Implementations
{
    public class EducationService : IEducationsService
    {
        
        private readonly IEducationRepository _education;

        public EducationService(IEducationRepository education)
        {
            _education = education;
        }
        public void Add(Education model)
        {
            _education.Add(model);
        }

        public Education CreateEducation(string degreeObtained, string schoolName, string discipline, DateTime startDate, DateTime endDate, string userProfileId, int userId)
        {
            return _education.CreateEducation(degreeObtained, schoolName, discipline, startDate, endDate, userProfileId, userId);
        }

        public void Delete(Education model)
        {
            _education.Delete(model);
        }

        public List<Education> GetAllEducation(int id)
        {
            return _education.GetAllEducation(id);
        }

        public Education GetEducation(int id)
        {
            return _education.GetEducation(id);
        }

        public void Update(Education oldModel)
        {
            _education.Update(oldModel);
        }
    }
}
