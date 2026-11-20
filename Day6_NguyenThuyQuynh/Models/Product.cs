using System.ComponentModel.DataAnnotations;

namespace Day6_NguyenThuyQuynh.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "name must be between 3 and 100")]
        public string Name { get; set; } = String.Empty;
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number")]
        public decimal Price { get; set; }
        public string? Description { get; set; }

    }
}
