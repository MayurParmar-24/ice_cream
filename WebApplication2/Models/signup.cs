

using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class signup
    {

        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string Re_Password { get; set; }
    }
}
