using System.ComponentModel.DataAnnotations;

namespace TechArtProfileProject.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [Required][MaxLength(300)]
        public string ProjectDescription { get; set; }

        [Required][MaxLength(50)]
        public string ProjectName { get; set; }
        [Required]
        public string ProjectLink { get; set; }

        public int UserId { get; set; }
        public string UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}