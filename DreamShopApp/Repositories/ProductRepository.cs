using DreamShopApp.Data;
using DreamShopApp.Interfaces;
using DreamShopApp.Models;

namespace DreamShopApp.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public ICollection<Product> GetAllProducts()
        {
            return _context.Products.OrderBy(p=>p.Id).ToList();
        }
    }
}
