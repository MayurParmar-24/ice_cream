using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class addtocart
    {
        [Key]
        public int Id { get; set; }

        [Required]

        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public string ProductName { get; set; }


        [Required]
        public string Product_Quantity { get; set; }

       

    }
}
