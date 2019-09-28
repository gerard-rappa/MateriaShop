using System.Collections.Generic;
using System.Linq;

namespace MateriaShop.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Fire", Category = "Magic", Description = "Fire based magic", Price = 250 },
            new Product { Name = "Ice", Category = "Magic", Description = "Ice based magic", Price = 250 },
            new Product { Name = "Restore", Category = "Magic", Description = "Healing magic", Price = 500 }
        }.AsQueryable<Product>();
    }
}
