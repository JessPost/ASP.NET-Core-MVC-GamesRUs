using System.ComponentModel.DataAnnotations;

namespace GamingStore.Models
{
    public class Game
    {
        //add games to database
        [Required]
        public int Id { get; set; }
        [Required (ErrorMessage="Please enter Game Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter Game Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter Game Developer")]
        public string Developer { get; set; }
        [Required(ErrorMessage = "Please enter Game Price")]
        public decimal Price { get; set; }
    }
}
