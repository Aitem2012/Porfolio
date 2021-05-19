using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TechArtProfileProject.Models;

namespace TechArtProfileProject.Lib.Model.Models
{
    public class UserServices
    {
        [Key]
        public int ServiceId { get; set; }
        [Required]
        public string ServiceName { get; set; }
        [Required]
        public string ServiceDescription { get; set; }
        public string UserProfileId { get; set; }
        public int UserId { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
