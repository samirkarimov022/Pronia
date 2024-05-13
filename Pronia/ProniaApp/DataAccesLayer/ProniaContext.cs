using Microsoft.EntityFrameworkCore;
using ProniaApp.Models;

namespace ProniaApp.DataAccesLayer
{
    public class ProniaContext: DbContext
    {
        public ProniaContext(DbContextOptions options):base(options) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }     
        public DbSet<Slider> Sliders { get; set; }  
        public DbSet<ProductImage> ProductImages { get; set; } 
        public DbSet<Product>Products { get; set; } 
        public DbSet<ProductCategory>ProductCategories { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=CA-R214-PC17\\SQLEXPRESS01;DataBase=ProniaDbFirst;Trusted_Connection=true;TrustServerCertificate=True"); 
            base.OnConfiguring(options);
        }
    }
}
