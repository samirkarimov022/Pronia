using System.ComponentModel.DataAnnotations;

namespace ProniaApp.viewModels.Slider
{
    public class UpdateSliderVM
    {

        [MaxLength(25), Required]
        public string Title { get; set; }


        [Range(0, 100), Required]
        public int Discount { get; set; }


        [MaxLength(100), Required]
        public string Subtitle { get; set; }


        [Required]
        public string ImageUrl { get; set; }
    }
}
