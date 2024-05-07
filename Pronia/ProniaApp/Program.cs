using ProniaApp.DataAccesLayer;

namespace ProniaApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ProniaContext>();
              

            var app = builder.Build();

           app.UseStaticFiles();
            app.MapControllerRoute(
                 "default",
                 "{controller=Home}/{action=Index}");

            app.Run();
        }
    }
}
