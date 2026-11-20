using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day6_NguyenThuyQuynh.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; } // Duration in minutes
        [ForeignKey("Grenre")]
        public int GenreId { get; set; }
        public Grenre? Genre { get; set; }
    }
}
