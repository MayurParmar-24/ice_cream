﻿
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class feedback
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required] 
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }

    }
}
