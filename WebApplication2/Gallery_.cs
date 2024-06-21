using System.ComponentModel.DataAnnotations;

namespace WebApplication2
{
    public class Gallery_
    {
        [Key]

        public int Gallery_Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public IFormFile Photo { get; set; }
    }
}
