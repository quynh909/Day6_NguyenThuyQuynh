using System.ComponentModel.DataAnnotations;

namespace Day6_NguyenThuyQuynh.Models
{
    public class Grenre
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "phai nhap ten movie")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "name must be between 3 and 100")]
        public string? Name { get; set; }
        public string? Description { get; set; }= String.Empty;
        public List<Movie>? Movies { get; set; }
    }
}
