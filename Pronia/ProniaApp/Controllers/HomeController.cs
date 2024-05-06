using Microsoft.AspNetCore.Mvc;

namespace ProniaApp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index() 
        {
            return View();
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
    }
}
