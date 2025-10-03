using Microsoft.AspNetCore.Builder;
using PlatformService.Models;
//sameple db filler code

namespace PlatformService.Data
{
    public class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                SeedData(context);
            }
        }

        private static void SeedData(AppDbContext context)
        {
            // Check if data already exists
            if (!context.Platforms.Any())
            {
                Console.WriteLine("Seeding data........");
                context.Platforms.AddRange(
                    new Platform() { Name = ".NET", Publisher = "Microsoft", Cost =  0},
                    new Platform() { Name = ".SQL Server", Publisher = "Microsoft", Cost =  0},
                    new Platform() { Name = ".Kubernetes", Publisher = "Cloud Boys", Cost =  0}
                );

                context.SaveChanges();
            }else{
                Console.WriteLine("Data already exists");
            }
        }
    }

}