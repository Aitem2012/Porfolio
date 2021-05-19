using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechArtProfileProject.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage ="Name is required")]
        public string SenderName { get; set; }
        [Required(ErrorMessage ="Message body cannot be empty")]
        public string SenderMessage { get; set; }
        [EmailAddress]
        [Required(ErrorMessage ="Please Enter a valid email")]
        public string SenderEmail { get; set; }
    }
}
