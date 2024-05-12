using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProniaApp.DataAccesLayer;
using ProniaApp.Models;
using ProniaApp.viewModels.Slider;

namespace ProniaApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController(ProniaContext _context) : Controller
    {


        public async Task<IActionResult> Index()
        {
         var data = await _context.Sliders
                .Where(x=>!x.IsDeleted)
                .Select
                (s => new GetSlidersVM
            {
                Discount = s.Discount,
                Id = s.Id,
                ImageUrl = s.ImageUrl,
                Subtitle = s.Subtitle,
                Title = s.Title,
            }).ToListAsync();
            return View(data);
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
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null || id < 1)return BadRequest();

            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            
            if (slider is null) return NotFound();

            UpdateSliderVM sliderVM = new UpdateSliderVM
            {
                Discount = slider.Discount,
                Title = slider.Title,
                Subtitle = slider.Subtitle,
                ImageUrl = slider.ImageUrl

            };

            return View(sliderVM);
        }
        [HttpPost]
        public async Task<IActionResult> Update(int? id, UpdateSliderVM sliderVM)
        {
            if(id == null || id < 1)return BadRequest();

            Slider existed = await _context.Sliders.FirstOrDefaultAsync(s=> s.Id == id);

            if(existed is null) return NotFound();

            existed.Title = sliderVM.Title;
            existed.Subtitle = sliderVM.Subtitle;
            existed.ImageUrl = sliderVM.ImageUrl;
            existed.Discount = sliderVM.Discount;

            
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }
    }
}