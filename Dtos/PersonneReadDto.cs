using System.ComponentModel.DataAnnotations;

namespace Template.Dtos
{
    public class PersonneReadDto
    {

        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public int Age { get; set; }
    }
}