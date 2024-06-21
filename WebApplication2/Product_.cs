using System.ComponentModel.DataAnnotations;

namespace WebApplication2
{
    public class Product_
    {
        internal string image;

        [Key]
        public int Id { get; set; }

        [Required]

        public String  Name { get; set; }

        [Required]

        public int Price { get; set; }

        [Required]
        public IFormFile Photo { get; set; }
    }
}
