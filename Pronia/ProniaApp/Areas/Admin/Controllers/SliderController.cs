using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProniaApp.Models;
using ProniaApp.viewModels.Slider;

namespace ProniaApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController(ProniaAppContext _context) : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
     
        public async Task<IActionResult> Create(CreateSliderVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            Slider slider = new Slider
            {
                Discount = vm.Discount,
                CreatedTime = DateTime.Now,
                ImageUrl = vm.ImageUrl,
                IsDeleted = false,
                Subtitle = vm.Subtitle,
                Title = vm.Title,
            };
             await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();
            return View();
        }
    }
}
