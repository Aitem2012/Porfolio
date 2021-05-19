using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TechArtProfileProject.Lib.Model.Models
{
    public class Contact
    {
        [Key]
        public int SenderId { get; set; }
        [Required][MaxLength(50)]
        public string SenderName { get; set; }
        [Required]
        public string SenderMessage { get; set; }
        [Required]
        public string SenderEmail { get; set; }
        public DateTime TimeSent { get; set; } = DateTime.Now;
    }
}
