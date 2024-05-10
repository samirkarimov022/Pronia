using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaApp.DataAccesLayer;
using ProniaApp.Models;
using ProniaApp.viewModels.Categories;

namespace ProniaApp.Controllers
{
    public class HomeController : Controller
    {



        private readonly ProniaContext _context;
        private object id;

        public HomeController(ProniaContext context)
        {
            _context = context;
        }



        public async Task<IActionResult> Index()
        {
            //var data = await _context.categories.Where(c=>c.Name.Length > 6 ).ToListAsync();
            var data = await _context.categories
                .Where(x => x.IsDeleted == false)
               .Select(x => new GetCategoryVM
               {
                   Id = x.Id,
                   Name = x.Name,
               })
                //.OrderByDescending(c=>c.Id)
                //.Take(4)
                .ToListAsync();
            return View(data);
        }


        public async Task<IActionResult> Test(int? id)
        {
            if (id == null || id < 1) return BadRequest();
            var cat = await _context.categories.FindAsync(id);
            if (cat == null) return NotFound();
            _context.categories.Remove(cat);
            await _context.SaveChangesAsync();
            return Content(cat.Name);



            //Category category = new Category
            //{
            //    Name = name,
            //    CreatedTime = DateTime.UtcNow,
            //    IsDeleted = false
            //};
            //await _context.categories.AddAsync(category);
            //await _context.SaveChangesAsync();
            //return Ok(name);

        }




        public async Task<IActionResult> Index2()
        {
            return View();
        }




        public async Task<IActionResult> Shop()
        {
            return View();
        }




        public async Task<IActionResult> Blog()
        {
            return View();
        }




        public async Task<IActionResult> About()
        {
            return View();
        }






        public async Task<IActionResult> Contact()
        {
            return View();
        }





        public async Task<IActionResult> Faq()
        {
            return View();
        }









        public async Task<IActionResult> Error()
        {
            return View();
        }
    }
}
