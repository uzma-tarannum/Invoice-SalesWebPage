using WebApplication1.Models.DataAccess;
using WebApplication1.Models.Entitties;
using WebApplication1.ViewModels;

namespace WebApplication1.Factories
{
    public class ProductFactory : IProductFactory
    {
        private readonly IProductRepository _productRepository;
        public ProductFactory(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Edit(ProductViewModel product)
        {
            var model = new Product
            {
                Name = product.Name,
                Id = product.Code,
                CategoryCode = product.CategoryCode,
                BrandCode = product.BrandCode,
                CostRate = product.CostRate,
                SalesRate = product.SalesRate,
                Total = (product.CostRate + product.SalesRate),
            };
            _productRepository.Edit(model);
        }

        public IList<ProductViewModel> GetAllProducts()
        {
           var result= _productRepository.GetProducts();

            var model = result.Select(x => new ProductViewModel
            {
                Name = x.Name,
                Code = x.Id,
                CategoryCode = x.CategoryCode,
                BrandCode = x.BrandCode,
                CostRate = x.CostRate,
                SalesRate = x.SalesRate,
                Total=x.Total,
            }).ToList();

            return model;
        }

        public IList<ProductCategoryViewModel> GetCategories()
        {
            var result = _productRepository.GetCategories();
            var model = result.Select(x => new ProductCategoryViewModel
            {
                Name = x.Name,
                Id = x.Id,
              
            }).ToList();

            return model;
        }

        public IList<ProductBrandViewModel> GetProductBrands()
        {
            var result = _productRepository.GetProductBrands();
            var model = result.Select(x => new ProductBrandViewModel
            {
                Name = x.Name,
                Id = x.Id,

            }).ToList();

            return model;
        }

        public ProductViewModel GetProductById(int id)
        {
            var result = _productRepository.GetProductById(id);

            var model = new ProductViewModel
            {
                Name = result.Name,
                Code = result.Id,
                CategoryCode = result.CategoryCode,
                BrandCode = result.BrandCode,
                CostRate = result.CostRate,
                SalesRate = result.SalesRate,
                Total = result.Total,
            };

            return model;
        }

        public void InsertProduct(ProductViewModel x)
        {
            var model = new Product
            {
                Name = x.Name,
                Id = x.Code,
                CategoryCode = x.CategoryCode,
                BrandCode = x.BrandCode,
                CostRate = x.CostRate,
                SalesRate = x.SalesRate,
                Total =(x.CostRate + x.SalesRate) ,
            };
            _productRepository.AddProduct(model);
        }
    }
}
