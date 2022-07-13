using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace games_webapi.Models
{
    public class Developer
    {
        public Developer()
        {
            Games = new Collection<Game>();
        }

        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
