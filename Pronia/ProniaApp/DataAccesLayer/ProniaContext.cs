using Microsoft.EntityFrameworkCore;
using ProniaApp.Models;

namespace ProniaApp.DataAccesLayer
{
    public class ProniaContext: DbContext
    {
        public ProniaContext(DbContextOptions options):base(options) 
        {
            
        }
        public DbSet<Category>categories { get; set; } 
        public DbSet<Slider>Sliders { get; set; }  
        public DbSet<ProductImage> ProductImages { get; set; } 
        public DbSet<Product>Products { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-B5OV3RE\\SQLEXPRESS;DataBase=Pronia;Trusted_Connection=true;TrustServerCertificate=True"); 
            base.OnConfiguring(options);
        }
    }
}
