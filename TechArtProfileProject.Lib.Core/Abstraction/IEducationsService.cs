using System;
using System.Collections.Generic;
using System.Text;
using TechArtProfileProject.Lib.Core.Abstraction;
using TechArtProfileProject.Lib.Model.Models;
using TechArtProfileProject.Models.Services;

namespace TechArtProfileProject.Lib.Infrastructure.Abstraction
{
    public interface IEducationsService : ICRUDService<Education>
    {
        public Education CreateEducation(string degreeObtained, string schoolName, string discipline, DateTime startDate, DateTime endDate, string userProfileId, int userId);
        public List<Education> GetAllEducation(int id);
        public Education GetEducation(int id);
    }
}
