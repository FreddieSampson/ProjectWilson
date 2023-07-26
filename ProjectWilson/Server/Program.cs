using Microsoft.AspNetCore.ResponseCompression;
using ProjectWilson.Server.Services.CategoryService;
using ProjectWilson.Server.Services.ProductService;
using ProjectWilson.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace ProjectWilson.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}