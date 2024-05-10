using System.ComponentModel.DataAnnotations;

namespace ProniaApp.viewModels.Slider
{
    public class CreateSliderVM
    {
        [MaxLength(25,ErrorMessage="25-den coxdur"), Required]
        public string Title { get; set; }
        [Range(0, 100)]
        public int Discount { get; set; }
        [MaxLength(40), Required]
        public string Subtitle { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
