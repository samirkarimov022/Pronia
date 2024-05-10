using System.ComponentModel.DataAnnotations;

namespace ProniaApp.Models
{
    public class Slider:BaseEntity
    {
        [MaxLength(25),Required]
        public string Title {  get; set; }
        [Range(0,100)]
        public int Discount { get; set; }
        [MaxLength(40),Required]
        public string Subtitle { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
