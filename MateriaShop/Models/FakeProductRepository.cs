using System.Collections.Generic;
using System.Linq;

namespace MateriaShop.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
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
        }.AsQueryable<Product>();
    }
}
