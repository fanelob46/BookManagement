using System.ComponentModel.DataAnnotations;

namespace BooksMvc.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public int Price { get; set; }
        public int LendingPrice { get; set; }

    }
}
