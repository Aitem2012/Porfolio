using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechArtProfileProject.Lib.Model.Models;

namespace TechArtProfileProject.Models
{
    public class UserProfile : IdentityUser
    {
        
        public int UserId { get; set; }
        [Required]
        [StringLength(15)]

        public string FirstName { get; set; }
        [Required]
        [StringLength(15)]
        public string LastName { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        //public string Email { get; set; }
        //[Required]
        public string Biography { get; set; }
        [Required]
        public string JobTitle { get; set; }

        public ICollection<Project> Projects { get; set; }
        public ICollection<UserServices> Services { get; set; }
        public ICollection<Education> Educations { get; set; }

        
    }
}
