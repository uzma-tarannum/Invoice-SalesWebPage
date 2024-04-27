using WebApplication1.Models.Entitties;
using WebApplication1.ViewModels;

namespace WebApplication1.Models.DataAccess
{
    public interface IProductRepository
    {
        IList<Product> GetProducts();

        void AddProduct(Product product);
        void Edit(Product product);
        Product GetProductById(int id);
        IList<ProductCategory> GetCategories();
        IList<ProductBrand> GetProductBrands();
    }
}
