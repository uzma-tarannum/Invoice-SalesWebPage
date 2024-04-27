using Microsoft.AspNetCore.Mvc;
using WebApplication1.Factories;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerFactory _customeFactory;

        public CustomerController(ICustomerFactory customerFactory)
        {

            _customeFactory = customerFactory;
        }
        public IActionResult AddCustomer()
        {
            return View();
        }
        public IActionResult SaveCustomer(CustomerViewModel model)
        {
            _customeFactory.AddCustomer(model);
            return View();
        }
        public IActionResult Edit(int Id)
        {
            CustomerViewModel model = new CustomerViewModel();
            model = _customeFactory.GetCustomerById(Id);
            return View(model);
        }
        public IActionResult Update(CustomerViewModel model)
        {
            if (!ModelState.IsValid && model == null)
            {
                return View("Edit");
            }
            _customeFactory.Edit(model);
            return View();
        }

        public JsonResult GetAllCustomerCategory()
        {

            var list = _customeFactory.GetCustomerCategory();
            return Json(list);
        }
        public JsonResult GetAllCustomerArea()
        {

            var list = _customeFactory.GetCustomerArea();
            return Json(list);
        }

    }
}
}
