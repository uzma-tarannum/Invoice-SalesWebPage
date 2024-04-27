using WebApplication1.Models.Entitties;

namespace WebApplication1.Models.DataAccess
{
    public class ProductRepository : IProductRepository
    {
        private readonly EBMContext _db;
        public ProductRepository(EBMContext db)
        {
            _db = db;
        }

        public void AddProduct(Product product)
        {
            _db.product.Add(product);
            _db.SaveChanges();
        }

        public void Edit(Product product)
        {
                _db.product.Update(product);
           
                _db.SaveChanges();
        }

        public IList<ProductCategory> GetCategories()
        {
            return _db.productCategory.ToList();
        }

        public IList<ProductBrand> GetProductBrands()
        {
            return _db.productBrand.ToList();
        }

        public Product GetProductById(int id)
        {
            var result= _db.product.Find(id);
            return result;
        }

        public IList<Product> GetProducts()
        {
            return _db.product.ToList();

            //var result = from prd in _db.product
            //              join prdBrand in _db.productBrand on prd.BrandCode equals prdBrand.Id
            //             join prdCategory in _db.productCategory on prd.CategoryCode equals prdCategory.Id
            //             select new Product
            //             {
            //                 Id = prd.Id,
            //                 Name = prd.Name,
            //                 CategoryCode = prd.CategoryCode,
            //                 SalesRate = prd.SalesRate,
            //                 CostRate = prd.CostRate,
            //                 BrandCode = prd.BrandCode,

            //             };

            
            //return result.ToList();

        }
    }
}
