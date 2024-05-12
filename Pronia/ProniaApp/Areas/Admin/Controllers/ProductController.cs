

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProniaApp.DataAccesLayer;
using ProniaApp.viewModels.Products;

namespace ProniaApp.Areas.Admin.Controllers;
[Area("Admin")]
public class ProductController(ProniaContext _context): Controller
{
    public async Task<IAsyncResult> Index()
    {
        
        //return View(await _context.Products
        //    .Select(p=> new GetProductAdminVM
        //    {
        //        CostPrice = p.CostPrice,
        //        Discount = p.Discount,
        //        Id = p.Id,
        //        ImageUrl = p.ImageUrl,
        //        Name = p.Name,
        //        Raiting = p.Raiting,
        //        SellPrice = p.SellPrice,
        //        StockCount = p.StockCount,
        //    })
        //    .ToListAsync());
        // burda errorum var alinmir
    }
}
