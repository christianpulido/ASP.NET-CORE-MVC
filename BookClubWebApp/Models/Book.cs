using System.ComponentModel.DataAnnotations;

namespace BookClubWebApp.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Author { get; set; }

        [Required]
        public string? Info { get; set; }

        [Required]
        public string? Link { get; set; }

    }
}
