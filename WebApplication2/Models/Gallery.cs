using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Gallery
    {
        [Key]

        public int Gallery_Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public String Gallery_img { get; set; }


    }
}
