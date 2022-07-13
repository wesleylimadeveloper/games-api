using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace games_webapi.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required]
        public int Year { get; set; }

        [JsonIgnore]
        public Developer? Developer { get; set; }
        
        [Required]
        public int DeveloperId { get; set; }
    }
}
