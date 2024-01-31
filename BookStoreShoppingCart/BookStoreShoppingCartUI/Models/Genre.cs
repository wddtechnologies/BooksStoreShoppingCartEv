using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStoreShoppingCartUI.Models
{
    [Table("Genre")]
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string? GenreName { get; set; }
        public List<Book> Books { get; set; }

    }
}