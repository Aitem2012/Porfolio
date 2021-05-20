using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechArtProfileProject.ViewModels
{
    public class EducationViewModel
    {
        public int EducationId { get; set; }
        
        public string DegreeObtained { get; set; }
        
        public string SchoolName { get; set; }

        public string Discipline { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime GraduationDate { get; set; }

        public string UserProfileId { get; set; }
        public int UserId { get; set; }
    }
}
