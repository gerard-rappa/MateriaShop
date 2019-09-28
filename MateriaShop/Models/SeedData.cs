using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace MateriaShop.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if(!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product{
                        Name = "Fire",
                        Description = "Fire based magic",
                        Category = "Magic",
                        Price = 250},
                    new Product{
                        Name = "Ice",
                        Description = "Ice based magic",
                        Category = "Magic",
                        Price = 250},
                    new Product{
                        Name = "Restore",
                        Description = "Healing magic",
                        Category = "Magic",
                        Price = 500},
                    new Product{
                        Name = "Ultima",
                        Description = "Awesome magic",
                        Category = "Magic",
                        Price = 50000},
                    new Product{
                        Name = "Bahamut",
                        Description = "Non-Elemental Summon",
                        Category = "Summon",
                        Price = 65000}
                    );
                context.SaveChanges();
            }
        }
    }
}
