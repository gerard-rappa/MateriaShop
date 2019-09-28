using System.Linq;

namespace MateriaShop.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
