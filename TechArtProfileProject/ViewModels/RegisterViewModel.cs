using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechArtProfileProject.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress][Required]
        public string Email { get; set; }
        [Required][DataType(DataType.Password, ErrorMessage ="Alpha Numeric")]
        public string Password { get; set; }
    }
}
