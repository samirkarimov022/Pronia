using System.ComponentModel.DataAnnotations;

namespace ProniaApp.viewModels.Slider
{
    public class GetSlidersVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Discount { get; set; }
        public string Subtitle { get; set; }
        public string ImageUrl { get; set; }
    }
}
