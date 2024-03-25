using System.ComponentModel.DataAnnotations;
using System.Drawing;

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

        //public int CategoryId { get; set; }

        //public virtual Category Category { get; set; }


    }
}
