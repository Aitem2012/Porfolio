using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TechArtProfileProject.Models;

namespace TechArtProfileProject.Lib.Model.Models
{
    public class Education
    {
        [Key]
        public int EducationId { get; set; }
        [Required]
        public string DegreeObtained { get; set; }
        [Required]
        public string SchoolName { get; set; }

        public string Discipline { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime GraduationDate { get; set; }
        public int UserId { get; set; }
        public string UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }

    }
}
