using DreamShopApp.Models;

namespace DreamShopApp.Interfaces
{
    public interface IProductRepository
    {
        ICollection<Product> GetAllProducts();

    }
}
