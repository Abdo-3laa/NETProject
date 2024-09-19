using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Price { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [Range(0, 1000)]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "The ImagePath is required.")]
        public string? ImagePath { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
     
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
