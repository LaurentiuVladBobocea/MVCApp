using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StaticWebsite.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        [Required,MaxLength(50)]
        //[RegularExpression("^[A-Z][a-zA-Z]*$")]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Intro { get; set; }
        public SocialMedia socialMedia { get; set; }
        
    }
}