using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название обязательно для заполнения")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Автор обязателен для заполнения")]
        public string Author { get; set; } = string.Empty;

        [Required(ErrorMessage = "Жанр обязателен для заполнения")]
        public string Genre { get; set; } = string.Empty;

        public bool IsAvailable { get; set; } = true;
    }
}
