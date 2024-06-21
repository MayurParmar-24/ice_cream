using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Product
    {

        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

        [Required]

        public String Name { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]

        public String Product_image { get; set; }

        


    }
}
