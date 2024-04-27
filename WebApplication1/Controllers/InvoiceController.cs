using Microsoft.AspNetCore.Mvc;
using WebApplication1.Factories;

namespace WebApplication1.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IProductFactory _productFactory;
        public InvoiceController(IProductFactory productFactory)
        {
            _productFactory = productFactory;
        }
        public IActionResult Invoice()
        {

            var list = _productFactory.GetAllProducts();
            return View(list);
        }
       
    }
}

