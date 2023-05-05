using System.ComponentModel.DataAnnotations;

namespace Template.Models
{
    public class Personne : EntityBase
    {
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public int Age { get; set; }
        public DateTime CreationTimeUtc { get; set; } = DateTime.UtcNow;
    }

}