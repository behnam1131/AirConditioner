using AirConditioner.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace AirConditioner.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().MigrateDatabase<ApplicationDbContext>().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
