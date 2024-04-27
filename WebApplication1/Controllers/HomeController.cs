using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Factories;
using WebApplication1.Models;
using WebApplication1.Models.Entitties;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductFactory _productFactory;
       
        public HomeController(ILogger<HomeController> logger, IProductFactory productFactory)
        {
            _logger = logger;
            _productFactory = productFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddProduct()
        {
            return View();
        }
        public IActionResult SaveProduct(ProductViewModel model)
        {
            _productFactory.InsertProduct(model);
            return View();
        }
        public IActionResult Edit(int Id)
        {
            ProductViewModel model = new ProductViewModel();
            model=_productFactory.GetProductById(Id);
            return View(model);
        }
        public IActionResult Update(ProductViewModel model)
        {
            if(!ModelState.IsValid && model== null){
                return View("Edit");
            }
            _productFactory.Edit(model);
            return View();
        }

        public JsonResult GetAllCategories()
        {

            var list = _productFactory.GetCategories();
            return Json(list);
        }
        public JsonResult GetallBrands()
        {

            var list = _productFactory.GetProductBrands();
            return Json(list);
        }

    }
}