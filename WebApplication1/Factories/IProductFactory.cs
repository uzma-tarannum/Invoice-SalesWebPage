using WebApplication1.Models.Entitties;
using WebApplication1.ViewModels;

namespace WebApplication1.Factories
{
    public interface IProductFactory
    {
        IList<ProductViewModel> GetAllProducts();

        void InsertProduct(ProductViewModel x);
        void Edit(ProductViewModel product);
        ProductViewModel GetProductById(int id);

        IList<ProductCategoryViewModel> GetCategories();
        IList<ProductBrandViewModel> GetProductBrands();
    }
}
