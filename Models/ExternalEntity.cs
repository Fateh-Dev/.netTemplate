using System.ComponentModel.DataAnnotations;

namespace Template.Models
{
    public class ExternalEntity
    {
        [Key]
        public string? ServerName { get; set; }
        public string? ServerUrl { get; set; }
        public string? Address { get; set; }
        public int? Port { get; set; }
    }


}